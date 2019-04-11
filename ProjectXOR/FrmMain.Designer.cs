namespace XORfind
{
    partial class FrmMain
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtInitialText = new System.Windows.Forms.TextBox();
            this.lblInitialText = new System.Windows.Forms.Label();
            this.btnProcess = new System.Windows.Forms.Button();
            this.txtTypeSpecificCharacter = new System.Windows.Forms.TextBox();
            this.cboLanguageSpecific = new System.Windows.Forms.ComboBox();
            this.lblLanguage = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.rboTypeSpecificCharacter = new System.Windows.Forms.RadioButton();
            this.rboTypeBruteforce = new System.Windows.Forms.RadioButton();
            this.lblType = new System.Windows.Forms.Label();
            this.pnlType = new System.Windows.Forms.Panel();
            this.lblBitsRange = new System.Windows.Forms.Label();
            this.txtBits = new System.Windows.Forms.TextBox();
            this.pnlLanguage = new System.Windows.Forms.Panel();
            this.rboLanguageSpecific = new System.Windows.Forms.RadioButton();
            this.rboLanguageAll = new System.Windows.Forms.RadioButton();
            this.lblOutput = new System.Windows.Forms.Label();
            this.btnOutput = new System.Windows.Forms.Button();
            this.txtOutput = new System.Windows.Forms.TextBox();
            this.lblWAIT = new System.Windows.Forms.Label();
            this.cboEncoding = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pnlType.SuspendLayout();
            this.pnlLanguage.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtInitialText
            // 
            this.txtInitialText.Location = new System.Drawing.Point(40, 118);
            this.txtInitialText.Name = "txtInitialText";
            this.txtInitialText.Size = new System.Drawing.Size(242, 20);
            this.txtInitialText.TabIndex = 0;
            // 
            // lblInitialText
            // 
            this.lblInitialText.AutoSize = true;
            this.lblInitialText.Location = new System.Drawing.Point(125, 102);
            this.lblInitialText.Name = "lblInitialText";
            this.lblInitialText.Size = new System.Drawing.Size(57, 13);
            this.lblInitialText.TabIndex = 1;
            this.lblInitialText.Text = "Initial text :";
            // 
            // btnProcess
            // 
            this.btnProcess.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProcess.Location = new System.Drawing.Point(103, 571);
            this.btnProcess.Name = "btnProcess";
            this.btnProcess.Size = new System.Drawing.Size(108, 32);
            this.btnProcess.TabIndex = 2;
            this.btnProcess.Text = "Process";
            this.btnProcess.UseVisualStyleBackColor = true;
            this.btnProcess.Click += new System.EventHandler(this.btnProcess_Click);
            // 
            // txtTypeSpecificCharacter
            // 
            this.txtTypeSpecificCharacter.Enabled = false;
            this.txtTypeSpecificCharacter.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTypeSpecificCharacter.Location = new System.Drawing.Point(188, 9);
            this.txtTypeSpecificCharacter.MaxLength = 20;
            this.txtTypeSpecificCharacter.Name = "txtTypeSpecificCharacter";
            this.txtTypeSpecificCharacter.Size = new System.Drawing.Size(50, 22);
            this.txtTypeSpecificCharacter.TabIndex = 5;
            this.txtTypeSpecificCharacter.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // cboLanguageSpecific
            // 
            this.cboLanguageSpecific.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboLanguageSpecific.Enabled = false;
            this.cboLanguageSpecific.FormattingEnabled = true;
            this.cboLanguageSpecific.Items.AddRange(new object[] {
            "French",
            "English"});
            this.cboLanguageSpecific.Location = new System.Drawing.Point(141, 9);
            this.cboLanguageSpecific.Name = "cboLanguageSpecific";
            this.cboLanguageSpecific.Size = new System.Drawing.Size(103, 21);
            this.cboLanguageSpecific.TabIndex = 8;
            // 
            // lblLanguage
            // 
            this.lblLanguage.AutoSize = true;
            this.lblLanguage.Enabled = false;
            this.lblLanguage.Location = new System.Drawing.Point(124, 321);
            this.lblLanguage.Name = "lblLanguage";
            this.lblLanguage.Size = new System.Drawing.Size(61, 13);
            this.lblLanguage.TabIndex = 9;
            this.lblLanguage.Text = "Language :";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(29, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(273, 39);
            this.lblTitle.TabIndex = 10;
            this.lblTitle.Text = "PROJECT: XOR";
            // 
            // rboTypeSpecificCharacter
            // 
            this.rboTypeSpecificCharacter.AutoSize = true;
            this.rboTypeSpecificCharacter.Location = new System.Drawing.Point(24, 12);
            this.rboTypeSpecificCharacter.Name = "rboTypeSpecificCharacter";
            this.rboTypeSpecificCharacter.Size = new System.Drawing.Size(158, 17);
            this.rboTypeSpecificCharacter.TabIndex = 11;
            this.rboTypeSpecificCharacter.TabStop = true;
            this.rboTypeSpecificCharacter.Text = "Specific character (base 10)";
            this.rboTypeSpecificCharacter.UseVisualStyleBackColor = true;
            this.rboTypeSpecificCharacter.CheckedChanged += new System.EventHandler(this.rboTypeSpecificCharacter_CheckedChanged);
            // 
            // rboTypeBruteforce
            // 
            this.rboTypeBruteforce.AutoSize = true;
            this.rboTypeBruteforce.Location = new System.Drawing.Point(24, 41);
            this.rboTypeBruteforce.Name = "rboTypeBruteforce";
            this.rboTypeBruteforce.Size = new System.Drawing.Size(77, 17);
            this.rboTypeBruteforce.TabIndex = 15;
            this.rboTypeBruteforce.TabStop = true;
            this.rboTypeBruteforce.Text = "BruteForce";
            this.rboTypeBruteforce.UseVisualStyleBackColor = true;
            this.rboTypeBruteforce.CheckedChanged += new System.EventHandler(this.rboTypeBruteforce_CheckedChanged);
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Location = new System.Drawing.Point(133, 174);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(37, 13);
            this.lblType.TabIndex = 16;
            this.lblType.Text = "Type :";
            // 
            // pnlType
            // 
            this.pnlType.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlType.Controls.Add(this.lblBitsRange);
            this.pnlType.Controls.Add(this.txtBits);
            this.pnlType.Controls.Add(this.txtTypeSpecificCharacter);
            this.pnlType.Controls.Add(this.rboTypeBruteforce);
            this.pnlType.Controls.Add(this.rboTypeSpecificCharacter);
            this.pnlType.Location = new System.Drawing.Point(22, 190);
            this.pnlType.Name = "pnlType";
            this.pnlType.Size = new System.Drawing.Size(282, 98);
            this.pnlType.TabIndex = 17;
            // 
            // lblBitsRange
            // 
            this.lblBitsRange.AutoSize = true;
            this.lblBitsRange.Enabled = false;
            this.lblBitsRange.Location = new System.Drawing.Point(40, 61);
            this.lblBitsRange.Name = "lblBitsRange";
            this.lblBitsRange.Size = new System.Drawing.Size(95, 13);
            this.lblBitsRange.TabIndex = 17;
            this.lblBitsRange.Text = "- Bits Range (1-64)";
            // 
            // txtBits
            // 
            this.txtBits.Enabled = false;
            this.txtBits.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBits.Location = new System.Drawing.Point(141, 56);
            this.txtBits.MaxLength = 2;
            this.txtBits.Name = "txtBits";
            this.txtBits.Size = new System.Drawing.Size(50, 22);
            this.txtBits.TabIndex = 16;
            this.txtBits.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // pnlLanguage
            // 
            this.pnlLanguage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlLanguage.Controls.Add(this.rboLanguageSpecific);
            this.pnlLanguage.Controls.Add(this.rboLanguageAll);
            this.pnlLanguage.Controls.Add(this.cboLanguageSpecific);
            this.pnlLanguage.Enabled = false;
            this.pnlLanguage.ForeColor = System.Drawing.SystemColors.ControlText;
            this.pnlLanguage.Location = new System.Drawing.Point(22, 337);
            this.pnlLanguage.Name = "pnlLanguage";
            this.pnlLanguage.Size = new System.Drawing.Size(282, 65);
            this.pnlLanguage.TabIndex = 19;
            // 
            // rboLanguageSpecific
            // 
            this.rboLanguageSpecific.AutoSize = true;
            this.rboLanguageSpecific.Location = new System.Drawing.Point(24, 10);
            this.rboLanguageSpecific.Name = "rboLanguageSpecific";
            this.rboLanguageSpecific.Size = new System.Drawing.Size(110, 17);
            this.rboLanguageSpecific.TabIndex = 17;
            this.rboLanguageSpecific.TabStop = true;
            this.rboLanguageSpecific.Text = "Specific language";
            this.rboLanguageSpecific.UseVisualStyleBackColor = true;
            this.rboLanguageSpecific.CheckedChanged += new System.EventHandler(this.rboLanguageSpecific_CheckedChanged);
            // 
            // rboLanguageAll
            // 
            this.rboLanguageAll.AutoSize = true;
            this.rboLanguageAll.Location = new System.Drawing.Point(24, 36);
            this.rboLanguageAll.Name = "rboLanguageAll";
            this.rboLanguageAll.Size = new System.Drawing.Size(135, 17);
            this.rboLanguageAll.TabIndex = 18;
            this.rboLanguageAll.TabStop = true;
            this.rboLanguageAll.Text = "Search in all languages";
            this.rboLanguageAll.UseVisualStyleBackColor = true;
            // 
            // lblOutput
            // 
            this.lblOutput.AutoSize = true;
            this.lblOutput.Location = new System.Drawing.Point(133, 477);
            this.lblOutput.Name = "lblOutput";
            this.lblOutput.Size = new System.Drawing.Size(45, 13);
            this.lblOutput.TabIndex = 20;
            this.lblOutput.Text = "Output :";
            // 
            // btnOutput
            // 
            this.btnOutput.Location = new System.Drawing.Point(279, 492);
            this.btnOutput.Name = "btnOutput";
            this.btnOutput.Size = new System.Drawing.Size(34, 23);
            this.btnOutput.TabIndex = 22;
            this.btnOutput.Text = "...";
            this.btnOutput.UseVisualStyleBackColor = true;
            this.btnOutput.Click += new System.EventHandler(this.btnOutput_Click);
            // 
            // txtOutput
            // 
            this.txtOutput.Location = new System.Drawing.Point(15, 493);
            this.txtOutput.Name = "txtOutput";
            this.txtOutput.Size = new System.Drawing.Size(261, 20);
            this.txtOutput.TabIndex = 23;
            // 
            // lblWAIT
            // 
            this.lblWAIT.AutoSize = true;
            this.lblWAIT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWAIT.ForeColor = System.Drawing.Color.Green;
            this.lblWAIT.Location = new System.Drawing.Point(89, 548);
            this.lblWAIT.Name = "lblWAIT";
            this.lblWAIT.Size = new System.Drawing.Size(142, 20);
            this.lblWAIT.TabIndex = 24;
            this.lblWAIT.Text = "PLEASE WAIT...";
            this.lblWAIT.Visible = false;
            // 
            // cboEncoding
            // 
            this.cboEncoding.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboEncoding.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboEncoding.FormattingEnabled = true;
            this.cboEncoding.Items.AddRange(new object[] {
            "UTF7",
            "ASCII",
            "UTF8",
            "Unicode",
            "BigEndianUnicode",
            "UTF32",
            "OS Default"});
            this.cboEncoding.Location = new System.Drawing.Point(87, 438);
            this.cboEncoding.Name = "cboEncoding";
            this.cboEncoding.Size = new System.Drawing.Size(134, 24);
            this.cboEncoding.TabIndex = 19;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(112, 422);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 13);
            this.label1.TabIndex = 25;
            this.label1.Text = "Encoding in file :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(78, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(161, 13);
            this.label3.TabIndex = 26;
            this.label3.Text = "** TYPO IS IMPORTANT **";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(325, 610);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cboEncoding);
            this.Controls.Add(this.lblWAIT);
            this.Controls.Add(this.txtOutput);
            this.Controls.Add(this.btnOutput);
            this.Controls.Add(this.lblOutput);
            this.Controls.Add(this.lblType);
            this.Controls.Add(this.pnlLanguage);
            this.Controls.Add(this.pnlType);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblLanguage);
            this.Controls.Add(this.btnProcess);
            this.Controls.Add(this.lblInitialText);
            this.Controls.Add(this.txtInitialText);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PROJECT:  XOR";
            this.pnlType.ResumeLayout(false);
            this.pnlType.PerformLayout();
            this.pnlLanguage.ResumeLayout(false);
            this.pnlLanguage.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtInitialText;
        private System.Windows.Forms.Label lblInitialText;
        private System.Windows.Forms.Button btnProcess;
        private System.Windows.Forms.TextBox txtTypeSpecificCharacter;
        private System.Windows.Forms.ComboBox cboLanguageSpecific;
        private System.Windows.Forms.Label lblLanguage;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.RadioButton rboTypeSpecificCharacter;
        private System.Windows.Forms.RadioButton rboTypeBruteforce;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.Panel pnlType;
        private System.Windows.Forms.Panel pnlLanguage;
        private System.Windows.Forms.RadioButton rboLanguageSpecific;
        private System.Windows.Forms.RadioButton rboLanguageAll;
        private System.Windows.Forms.Label lblOutput;
        private System.Windows.Forms.Button btnOutput;
        private System.Windows.Forms.TextBox txtOutput;
        private System.Windows.Forms.Label lblWAIT;
        private System.Windows.Forms.TextBox txtBits;
        private System.Windows.Forms.ComboBox cboEncoding;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblBitsRange;
        private System.Windows.Forms.Label label3;
    }
}

