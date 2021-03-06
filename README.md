# ProjectXOR
Heavily multithreaded tool for bruteforcing XOR Encryption. Multiple options available for specific bruteforcing rules. Made in Visual Studio 2017 in C#.

### Limitations: ###

- ProjectXOR language dictionaries contain irrelevant words, because they are free dictionaries I found on the Internet. They aren't paid dictionaries. I am planning to remove the irrelevant words in a near future.

- For now, ProjectXOR only support a single character Bruteforce. For example, it cannot bruteforce the string "My name is FanaticPythoner." with the string "abcdefghijklmnopqrstuvwxyzz". I am planning to implement that functionality in a near future.

# Installation :

Well the software is made in C#, so you need the .NET Framwework installed( If you don't have it installed, when you wil try to open the software, Windows will give you the choice to install it). Run the Xorfind.exe file in the bin/Debug folder. If you dont trust the compiled executable, just re-build it through Visual Studio. You have access to the source code.

# Usage

Well it is pretty damn easy to use. When you run the Xorfind.exe file, this GUI will appear: 

![alt text](https://i.imgur.com/YAyAvsf.png)


As you can notice, about the only thing you can do is enter the string you want to Xor (in Hexadecimal) in the "initial text" text field. As an example, let's enter the sentence "My name is FanaticPythoner." with each character xor'd with the letter "a", giving us the Hexadecimal string "2c18410f000c044108124127000f00150802311815090e0f04134f". Now, the section "Type" and "Language" are available for modification:

- The "Type" section specify the type of bruteforce. We can either specify a bit range (1 to 64), or a specific character (example "a").

- The "Language" section specify what language the software must lookup in when it tries to find similiarities between the UnXor'd string and words in a language dictionnary. ProjectXOR classes UnXor'd string in the output file by similarities between a dictionnary of words and the UnXor'd string. Currently, ProjectXOR supports French and English. We can either chose one of them, or all of them with the "search in all languages" option.


In the "Type" section, let's check the option "Bruteforce" and enter "8" in the bit range.
In the "Language" section, let's check the option "Specific language" and chose "English" in the scrolldown list.

![alt text](https://i.imgur.com/w6jmBjj.png)


The "Encoding in file" option is pretty straight foward: It specify what encoding the output file must be saved in. Let's leave it to UTF-32, because it doesn't matter in our case.

The "output" option specify the path of the output text file wich will contain all the UnXor'd string in UTF-32 format. All UnXor'd string will be ordered by the number of words ProjectXOR find in the specified language dictionary (English) that are present in the UnXor'd string.

Lets click the "..." button in the "output" option to chose the output text file path. Here, let's specify the "outputFile.txt" file on my desktop (if it already exists, ProjectXOR will overwrite it. If it doesn't exists, ProjectXOR will create it).

![alt text](https://i.imgur.com/UhyEV8N.png)

Now we can click the "Process" button and let the magic happen. When the process is done, a little message box will appear, telling us how long it took for the process to complete.

### WARNING : This is a Heavily Mulithreaded software, so if you specified, for example, a 64 bits bruteforce, it will literally use 100% of your processing power for quite a long time: that mean your PC can become unresponsive during the Bruteforce.

![alt text](https://i.imgur.com/Q8EUrro.png)

As we can see, it only took 0.7 second to do a 8 bits bruteforce on our sentence. If we click "Ok", the output text file we specified in the "output" option will open, and we will see our decrypted sentence "My name is FanaticPythoner." as the top result :

![alt text](https://i.imgur.com/l674DY8.png)
