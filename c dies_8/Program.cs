using System.Data.Common;
using System.IO;
using System.Runtime.CompilerServices;
using System.Text;
using System.Text.Json;
using System;

namespace c_dies_8

{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Directory.CreateDirectory("C:\\Users\\C - 6\\Documents\\Чепурина\\c dies_8\\t");  создаёт папку
            //string ppp = "C:\\Users\\C - 6\\Documents\\Чепурина\\c dies_8";

            //FileInfo file = new FileInfo("C:\\Users\\C - 6\\Documents\\Чепурина\\c dies_8\\text.txt");
            //FileInfo file = new FileInfo("text.txt");
            /*if (!File.Exists("C:\\Users\\C - 6\\Documents\\Чепурина\\c dies_8\\text1.txt"))
            {
                File.Create("C:\\Users\\C - 6\\Documents\\Чепурина\\c dies_8\\text1.txt");
            }
            
            FileStream fstream = new FileStream("C:\\Users\\C - 6\\Documents\\Чепурина\\c dies_8\\text1.txt", FileMode.OpenOrCreate);

            using (StreamWriter fs1 = new StreamWriter(fstream))
            {
                fs1.WriteLine("bebebebe");
            }
            using (StreamReader reader1 = new StreamReader("C:\\Users\\C - 6\\Documents\\Чепурина\\c dies_8\\text1.txt", true))
            {
                string line1 = reader1.ReadLine();
                Console.WriteLine(line1);
            }
            // file.Create();
            // file.CopyTo("");
            fstream.Close();*/

            //Logger log = new Logger("C:\\Users\\C - 6\\Documents\\Чепурина\\c dies_8\\text1.txt");
            //log.Log("text - brrr");
            int o = 1;
            int y = 0;
            ExceptionHandler han ;
            try
            {
                o= o / 0;
               
            }
            catch (Exception g)
            {
                DateTime date1 = DateTime.Now;
                han = new ExceptionHandler(g);
                han?.lo.LLL(g,date1);
            }
           // ExceptionHandler han2;
            try
            {
                y = o / y;
            }
            catch (Exception k)
            {
                DateTime date2 = DateTime.Today;

                han = new ExceptionHandler(k);
                han?.lo.LLL(k,date2);
            }
        }
        public class Logger
        {
            private string filePath;
            public Logger(string filePath)
            {
                this.filePath = filePath;
            }
            public void Log(string message)
            {
                try
                {
                    using (StreamWriter writer=new StreamWriter(filePath, true))
                    {
                        writer.WriteLine($"{message}");
                    }
                }
                catch (Exception)
                {
                    Console.WriteLine("Exception");
                }
            }
            public void LLL(Exception eee,DateTime t)
            {
                using (StreamWriter fs1 = new StreamWriter("C:\\Users\\C - 6\\Documents\\Чепурина\\c dies_8\\text1.txt", true))
                {
                    fs1.WriteLine(t);
                    fs1.WriteLine(eee.GetObjectData);
                    fs1.WriteLine(eee.Message);
                    fs1.WriteLine(eee.Data);


                }
                using (StreamReader reader1 = new StreamReader("C:\\Users\\C - 6\\Documents\\Чепурина\\c dies_8\\text1.txt", true))
                {
                    string line1 = reader1.ReadLine();
                    string[] lines = File.ReadAllLines("C:\\Users\\C - 6\\Documents\\Чепурина\\c dies_8\\text1.txt");
                    foreach (var line in lines)
                    {
                        Console.WriteLine(line);
                    }
                }
                
            }
        }
        public class ExceptionHandler
        {
            public Exception str;
            public Logger lo = new Logger("C:\\Users\\C - 6\\Documents\\Чепурина\\c dies_8\\text1.txt");
            public ExceptionHandler(Exception ex)
            {
                str = ex;
            }

            public void Excep(string a)
            {
                lo = new Logger("C:\\Users\\C - 6\\Documents\\Чепурина\\c dies_8\\text1.txt");

            }
        }
    }
}