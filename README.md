# ProjectXOR
Heavily multithreaded tool for bruteforcing XOR Encryption. Multiple options available for specific bruteforcing rules. Made in Visual Studio 2017 in C#.

# Installation :

Well the software is made in C#, so you need the .NET Framwework installed( If you don't have it installed, when you wil try to open the software, Windows will give you the choice to install it). Run the Xorfind.exe file in the bin/Debug folder. If you dont trust the compiled executable, just re-build it through Visual Studio. You have access to the source code.

# Usage

Well it is pretty damn easy to use. When you run the Xorfind.exe file, this GUI will appear: 

![alt text](https://i.imgur.com/YAyAvsf.png)


As you can notice, about the only thing you can do is enter the string you want to Xor (in Hexadecimal) in the "initial text" text field. As an example, let's enter the sentence "My name is FanaticPythoner." with each character xor'd with the letter "A", giving us the Hexadecimal string "2c18410f000c044108124127000f00150802311815090e0f04134f". Now, the section "Type" and "Language" are available for modification:

- The "Type" section specify the type of bruteforce. We can either specify a bit range (1 to 64), or a specific character (example "A").

- The "Language" section specify what language the software must lookup in when it tries to find similiarities between the UnXor'd string and words in a language dictionnary. ProjectXOR classes UnXor'd string in the output file by similarities between a dictionnary of words and the UnXor'd string. Currently, ProjectXOR supports French and English. We can either chose one of them, or all of them with the "search in all languages" option.


In the "Type" section, let's check the option "Bruteforce" and enter "8" in the bit range.
In the "Language" section, let's check the option "Specific language" and chose "English" in the scrolldown list.

![alt text](https://i.imgur.com/w6jmBjj.png)


The "Encoding in file" option is pretty straight foward: It specify what encoding the output file must be saved in. Let's leave it to UTF-32, because it doesn't matter in our case.

The "output" option specify the path of the output text file wich will contain all the UnXor'd string in UTF-32 format. All UnXor'd string will be ordered by the number of words ProjectXOR find in the specified language dictionary (English) that are present in the UnXor'd string.

Lets click the "..." button in the "output" option to chose the output text file path. Here, let's specify the "outputFile.txt" file on my desktop (if it already exists, ProjectXOR will overwrite it. If it doesn't exist, ProjectXOR will create it).

![alt text](https://i.imgur.com/UhyEV8N.png)
