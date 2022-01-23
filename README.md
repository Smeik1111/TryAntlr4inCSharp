# Demo Antlr Project for C#
This is a Demo-Project for Antlr in C#. The Goal of this Project is to make the Setup and Use of Antlr4 in C# on Windows easier and more accessible. This project contains all needed files and two examples to get started with antlr4 right away.

All needed files except for Java and Visual Studio are included.

## Setup
Clone the Repository to your workspace and open the Project in Visual Studio.
Compile the project once to load the Nuget References
To add your own grammar add an .g4 file in the "Grammatic" folder and save as "File with Encoding", select the Encoding "Unicode (UTF-8 without Signature) Codepage 65001" near the bottom of the list.

## Build
On each Build the grammars in the folder "Grammatic" are regenerated.
If nothing in the code has changed Visual Studio doesn't recompile the project, so a rebuild has to be executed.
Alternativly the BuildScript.bat can be executed.

## Usage
The compiled files are put in a respective folder with the grammar name.
In the folder there is a Lexer and a Parser, these are responsible for the parsing of a file.
A Listener and a Visitor are also generated. These are not supposed to be used but rather inherited from. 
The Lexer and Parser in series generate an CST (Context Syntax Tree). This CST can then be visited or listened to by the respective Listener or Parser.

Again: Don't modify the files in the folder as they are regenerated at each build. Inherit from Listener or Visitors in a folder outside the grammatic.  

## PrettyPrint
A simple PrettyPrint function has been made available. Feel free to modify and experiment with it. The ParseTree and the tokens of the Parser have to be provided to print the Tree to the console.

## Tests
A test project has been set up with a few simple tests.
Your own tests can be added, are autodetected and can be found in Visual Studio under the test window.

## Links
[antlr - Official Site](https://www.antlr.org/)

[antlr4 - Github](https://github.com/antlr/antlr4)

[antlr4 - Github - Getting Started](https://github.com/antlr/antlr4/blob/master/doc/getting-started.md)

[antlr4 - Github - A collection of example grammars](https://github.com/antlr/grammars-v4)

[antlr - Collection of Tutorials](https://tomassetti.me/antlr-mega-tutorial/)

[Let's build a compiler - Yankee's Coding Workshops - Youtube - A very helpful Video series in German](https://www.youtube.com/watch?v=2uvKTmfPNzE&list=PLOfFbVTfT2vbJ9qiw_6fWwBAmJAYV4iUm)
