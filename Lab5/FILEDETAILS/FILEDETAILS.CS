
using System;                // Console
using System.IO;             // FileStream, FileReader

class FileDetails
{
    static void Main(string[] args) 
	{
        Console.WriteLine(args.Length);
        foreach (string arg in args){
            //Console.WriteLine(arg);
        }
        
        string fileName = args[0];
        
		
		FileStream stream = new FileStream(fileName, FileMode.Open);
        StreamReader reader = new StreamReader(stream);
        int size = (int) stream.Length;





    }
}
