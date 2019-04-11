using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Threading;
using System.Diagnostics;

namespace XORfind
{
    public partial class FrmMain : Form
    {
        public List<string[]> m_lstDictionary = new List<string[]> ();
        public List<string> m_lstXorString = new List<string>();
        public List<string> m_lstXorStringWords = new List<string>();
        public List<List<string>> m_lstWordsFound = new List<List<string>>();
        public List<string> m_lstLanguage = new List<string>();
        public string m_path = "";
        public FrmMain()
        {
            InitializeComponent();
            cboEncoding.SelectedIndex = 5;
        }

        private void btnProcess_Click(object sender, EventArgs e)
        {
            m_lstLanguage = new List<string>();
            m_lstDictionary = new List<string[]>();
            lblWAIT.Visible = true;
            try
            {
                if (rboLanguageAll.Checked)
                    for (int i = 0; i < cboLanguageSpecific.Items.Count; i++)
                        LoadLanguage(cboLanguageSpecific.Items[i].ToString().ToLower());

                else if (rboLanguageSpecific.Checked)
                {
                    switch (cboLanguageSpecific.SelectedIndex)
                    {
                        case 0:
                            LoadLanguage("french");
                            break;
                        case 1:
                            LoadLanguage("english");
                            break;
                    }
                }

                Encoding encoding = null;
                switch (cboEncoding.SelectedIndex)
                {
                    case 0:
                        encoding = Encoding.UTF7;
                        break;
                    case 1:
                        encoding = Encoding.ASCII;
                        break;
                    case 2:
                        encoding = Encoding.UTF8;
                        break;
                    case 3:
                        encoding = Encoding.Unicode;
                        break;
                    case 4:
                        encoding = Encoding.BigEndianUnicode;
                        break;
                    case 5:
                        encoding = Encoding.UTF32;
                        break;
                    case 6:
                        encoding = Encoding.Default;
                        break;
                }

                if (rboTypeBruteforce.Checked)
                {
                    ulong limit = 1;
                    ulong nbBits = ulong.Parse(txtBits.Text);

                    for (ulong i = 1; i < ulong.Parse(txtBits.Text); i++)
                    {
                        limit <<= 1;
                        limit |= 1;
                    }             

                    XorOneByOneCharacter(limit, encoding);
                }
                else if (rboTypeSpecificCharacter.Checked)
                {
                    XorSpecificCharacter(ulong.Parse(txtTypeSpecificCharacter.Text), encoding);
                }


                lblWAIT.Visible = false;
                var process = new Process();
                process.StartInfo = new ProcessStartInfo()
                {
                    UseShellExecute = true,
                    FileName = m_path
                };

                process.Start();
                process.WaitForExit();
            }
            catch (Exception)
            {
                lblWAIT.Visible = false;
                MessageBox.Show("Please enter all parameters before trying to process.");
            }           
        }

        public void XorSpecificCharacter(ulong character, Encoding encoding)
        {
            DateTime first = DateTime.Now;
            string outputCurrent = "";

            for (int i = 0; i < txtInitialText.Text.Length; i++)            
                outputCurrent += (char)(txtInitialText.Text[i] ^ character);

            byte[] bytes= encoding.GetBytes(outputCurrent);
            outputCurrent = encoding.GetString(bytes);

            using (FileStream f = File.Open(m_path, FileMode.Create, FileAccess.ReadWrite, FileShare.ReadWrite))
            {
                using (StreamWriter writer = new StreamWriter(f))
                {
                    writer.WriteLine("-------------------- XOR WITH " + character + " --------------------" + Environment.NewLine + outputCurrent);
                }
            }
            MessageBox.Show("Done! " + (DateTime.Now - first).TotalSeconds + " seconds elapsed.");
        }

        public void XorOneByOneCharacter(ulong limit, Encoding encoding)
        {
            DateTime first = DateTime.Now;
            int limitOfDictionnary = m_lstDictionary.Count;
            bool matchesFound = false;
            string[] currentArrayDictionnary = null;
            List<string> lstCurrentWords = new List<string>();
            string wordsFound = "";

            m_lstWordsFound = new List<List<string>>();
            m_lstXorString = new List<string>();
            m_lstXorStringWords = new List<string>();

            string outputCurrent = "";
            string currentLanguage = "";
            byte[] bytes = null;
            string itemToAdd = "";
            string itemToAdd2 = "";
            string findItem = "";
            int indexOfFindItem = 0;
            bool containsValue = false;

            for (ulong i = 1; i != limit; i++)
            {
                wordsFound = "";
                for (int i2 = 0; i2 < txtInitialText.Text.Length; i2++)
                    outputCurrent += (char)(txtInitialText.Text[i2] ^ i);

                bytes = encoding.GetBytes(outputCurrent);
                outputCurrent = encoding.GetString(bytes);


                for (int index = 0; index < limitOfDictionnary; index++)
                {
                    wordsFound = "";
                    currentArrayDictionnary = m_lstDictionary[index];
                    currentLanguage = m_lstLanguage[index];
                    Parallel.For(0, currentArrayDictionnary.Length, index2 =>
                     {
                         if (outputCurrent.Contains(currentArrayDictionnary[index2]))
                         {
                             lstCurrentWords.Add(currentArrayDictionnary[index2]);
                             wordsFound += "'" + lstCurrentWords[lstCurrentWords.Count - 1] + "', ";
                             matchesFound = true;
                         }
                     });
                    
                    if (matchesFound)
                    {
                        matchesFound = false;
                        //wordsFound = wordsFound.Substring(0, wordsFound.Length - 2);
                        itemToAdd = "-------------------- XOR WITH " + i + " => WORD(S) " + "(" + currentLanguage + ") :" + wordsFound + " FOUND --------------------" + Environment.NewLine + outputCurrent;
                        itemToAdd2 = "-------------------- XOR WITH " + i + " --------------------" + Environment.NewLine + outputCurrent;

                        findItem = m_lstXorStringWords.Find(x => x.Contains(outputCurrent) && x.Contains(currentLanguage));
                        containsValue = m_lstXorString.Contains(m_lstXorString.Find(x => x.Contains(outputCurrent)));
                        if (!containsValue && findItem != null)
                        {
                            indexOfFindItem = m_lstXorStringWords.IndexOf(findItem);
                            string t = m_lstXorStringWords[indexOfFindItem].Substring(0, m_lstXorStringWords[indexOfFindItem].IndexOf("FOUND --------------------") + 1); ;
                            m_lstXorStringWords[indexOfFindItem] = m_lstXorStringWords[indexOfFindItem].Substring(0, m_lstXorStringWords[indexOfFindItem].IndexOf("FOUND --------------------") + 1);
                            wordsFound = "";
                            lstCurrentWords = new List<string>();
                        }
                        else if (findItem == null)
                        {
                            m_lstXorStringWords.Add(itemToAdd);
                            wordsFound = "";
                            lstCurrentWords = new List<string>();
                        }
                        //if (!m_lstXorStringWords.Contains(findItem))
                        //{
                        //    containsValue = m_lstXorString.Contains(m_lstXorString.Find(x => x.Contains(outputCurrent)));
                        //    if (!containsValue && findItem != null)
                        //    {
                        //        indexOfFindItem = m_lstXorStringWords.IndexOf(findItem);
                        //        string t = m_lstXorStringWords[indexOfFindItem].Substring(0, m_lstXorStringWords[indexOfFindItem].IndexOf("FOUND --------------------") + 1); ;
                        //        m_lstXorStringWords[indexOfFindItem] = m_lstXorStringWords[indexOfFindItem].Substring(0, m_lstXorStringWords[indexOfFindItem].IndexOf("FOUND --------------------") + 1);
                        //        wordsFound = "";
                        //        lstCurrentWords = new List<string>();
                        //    }
                        //    else if (findItem == null)
                        //    {
                        //        m_lstXorStringWords.Add(itemToAdd);
                        //        wordsFound = "";
                        //        lstCurrentWords = new List<string>();
                        //    }
                        //}
                    }
                    else
                    {
                        itemToAdd = "-------------------- XOR WITH " + i + " --------------------" + Environment.NewLine + outputCurrent;
                        if (!m_lstXorString.Contains(itemToAdd) && !m_lstXorStringWords.Contains(m_lstXorStringWords.Find(x => x.Contains(outputCurrent))))
                            m_lstXorString.Add("-------------------- XOR WITH " + i + " --------------------" + Environment.NewLine + outputCurrent);
                    }
                    //lstCurrentWords = new List<string>();
                }
                outputCurrent = "";
            }

            string[] array = m_lstXorStringWords.ToArray();
            Array.Sort(array, (x, y) => x.Length.CompareTo(y.Length));
            Array.Reverse(array);

            using (var f = File.Open(m_path, FileMode.Create, FileAccess.ReadWrite, FileShare.ReadWrite))
            {
                using (var objStreamWriter = new StreamWriter(f))
                {
                    for (int i = 0; i < array.Length; i++)                   
                        objStreamWriter.WriteLine(array[i]);                    

                    string temp;
                    string toContain1;
                    bool toContain2;
                    for (int i = 0; i < m_lstXorString.Count; i++)
                    {
                        temp = m_lstXorString[i];
                        toContain1 = temp.Split(new string[] { "--------------------" }, StringSplitOptions.RemoveEmptyEntries)[0];
                        toContain2 = array.Any(x => x.Contains(toContain1));
                        if (!toContain2 && temp != null && !string.IsNullOrWhiteSpace(temp))
                            objStreamWriter.WriteLine(temp);
                    }
                }
            }
            MessageBox.Show("Done! " + (DateTime.Now - first).TotalSeconds + " seconds elapsed.");
        }

        public void LoadLanguage(string pLanguage)
        {
            m_lstDictionary.Add(File.ReadAllLines("Languages\\" + pLanguage + ".txt"));
            m_lstLanguage.Add(pLanguage);
        }

        private void rboLanguageSpecific_CheckedChanged(object sender, EventArgs e)
        {
            if (rboLanguageSpecific.Checked)
            {
                cboLanguageSpecific.Enabled = true;
                cboLanguageSpecific.SelectedIndex = 0;
            }
            else
            {
                cboLanguageSpecific.Enabled = false;
                cboLanguageSpecific.SelectedIndex = -1;
            }
        }

        private void rboTypeSpecificCharacter_CheckedChanged(object sender, EventArgs e)
        {
            if (rboTypeSpecificCharacter.Checked)
                txtTypeSpecificCharacter.Enabled = true;
            else
            {
                txtTypeSpecificCharacter.Enabled = false;
                txtTypeSpecificCharacter.Text = "";
            }
        }

        private void rboTypeBruteforce_CheckedChanged(object sender, EventArgs e)
        {
            txtBits.Enabled = rboTypeBruteforce.Checked;
            lblBitsRange.Enabled = rboTypeBruteforce.Checked;
            pnlLanguage.Enabled = rboTypeBruteforce.Checked;
            lblLanguage.Enabled = rboTypeBruteforce.Checked;
        }

        private void btnOutput_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();

            saveFileDialog1.Filter = "txt files (*.txt)|*.txt";
            saveFileDialog1.FilterIndex = 2;
            saveFileDialog1.RestoreDirectory = true;

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                m_path = saveFileDialog1.FileName;
                txtOutput.Text = m_path;
            }
        }
    }
}
