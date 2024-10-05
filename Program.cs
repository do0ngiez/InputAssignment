using System;
using System.IO;

namespace NumberLogger{
    class Program{
        static void Main(string[] args){
            Console.WriteLine("Enter a number: ");
            string userInput = Console.ReadLine();
            string fp = "loggedNumber.txt";
            LogNumberToFile(userInput, fp);
            PrintFileContents(fp);
        }

        static void LogNumberToFile(string number, string fp){
            using (StreamWriter writer = new StreamWriter(fp)){
                writer.WriteLine(number);
            }

           // Console.WriteLine("Number written in file.");
        }

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
