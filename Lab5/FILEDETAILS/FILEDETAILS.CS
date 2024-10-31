
using System;                // Console
using System.IO;             // FileStream, FileReader

class FileDetails
{
    static public void Summarize(char[] contents)
    {
        int vowels = 0, consonants = 0, lines = 0; 
        foreach (char current in contents){ 
            if (Char.IsLetter(current)){ 
                if ("AEIOUaeiou".IndexOf(current) != -1){ 
                    vowels++; 
                } 
                else{ 
                    consonants++; 
                } 
            } 
            else if (current == '\n'){ 
                lines++; 
            } 
        }
        Console.WriteLine("Общее количество символов в файле: {0}", contents.Length);
        Console.WriteLine("Общее количество гласных в файле: {0}", vowels);
        Console.WriteLine("Общее количество согласных в файле: {0}", consonants);
        Console.WriteLine("Общее количество строк в файле: {0}", lines);
    }


    static void Main(string[] args) 
	{
        string fileName = args[0];
        FileStream stream = new FileStream(fileName, FileMode.Open);
        StreamReader reader = new StreamReader(stream);
        int size = (int)stream.Length;
        char[] contents = new char[size];
        for (int i = 0; i < size; i++){
            contents[i] = (char)reader.Read();
        }
        //foreach (char ch in contents)
        //{
        //    Console.Write(ch);
        //}
        reader.Close();
        Summarize(contents);
    }
}
