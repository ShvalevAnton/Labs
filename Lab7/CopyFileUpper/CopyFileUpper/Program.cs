using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CopyFileUpper
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string sFrom; // Имя входного файла
            string sTo; // Имя выходного файла
            StreamReader srFrom; // хранится ссылка на входной файл
            StreamWriter srTo;  // хранится ссылка на выходной файл

            // Запрос имени входного файла
            Console.Write("Копировать из:");
            sFrom = Console.ReadLine();
            // Запрос имени выходного файла
            Console.Write("Копировать в:");
            sTo = Console.ReadLine();
            Console.WriteLine("Копировать из {0} в {1}", sFrom, sTo);
            try
            {
                srFrom = new StreamReader(sFrom);
                srTo = new StreamWriter(sTo);
                while (srFrom.Peek() != -1)
                {
                    string sBuffer = srFrom.ReadLine();
                    sBuffer = sBuffer.ToUpper();
                    srTo.WriteLine(sBuffer);
                }
                srTo.Close();
                srFrom.Close();
            }
            catch (FileNotFoundException e)
            {
                Console.WriteLine("Неожиданное исключение");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
        }
    }
}
