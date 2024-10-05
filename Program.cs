using System;
using System.IO;

namespace NumberLogger{
    class Program{
        static void Main(string[] args){

            //ask and read user input
            Console.WriteLine("Enter a number: ");
            string userInput = Console.ReadLine();

            //specify file pathj
            string fp = "loggedNumber.txt";

            //call the method to write the user's input to the text file
            LogNumberToFile(userInput, fp);

            //call method to print the context of a text file
            PrintFileContents(fp);
        }
        

        //method to write the user's input to the text file
        static void LogNumberToFile(string number, string fp){
            
            //use StreamWriter and write the user's input to the file
            using (StreamWriter writer = new StreamWriter(fp)){
                writer.WriteLine(number);
            }

           // Console.WriteLine("Number written in file.");
        }

        //method that prints the contents of the text file
        static void PrintFileContents(string fp){
            if(File.Exists(fp)){
                using (StreamReader reader = new StreamReader(fp)){
                    
                    string fileContent = reader.ReadToEnd();
                    Console.WriteLine("Contents of the file:");
                    Console.WriteLine(fileContent);
                }
            }else{
                Console.WriteLine("File not found");
            }
        }
    }
}
