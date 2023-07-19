using System;
using System.IO;


namespace ConAppAssignment10
{
    public class FilleHandling
    {
        public static void CreateFile(string fileName, string content)
        {
            string filePath = fileName + ".txt";
            if (File.Exists(filePath))
            {
                Console.WriteLine("File already Exists");
            }
            else
            {
                File.WriteAllText(filePath, content);
                Console.WriteLine("File Created Succesfully");
            }
        }
        public static string ReadFile(string FName)
        {

            string filePath = FName + ".txt";
                return File.ReadAllText(filePath);
            }
           
        
        public static void AppendToFIle(string fileName, string ConTent)
        {
            string filePath = fileName + ".txt";
            if (File.Exists(filePath))
            {
                File.AppendAllText(filePath, ConTent);
                Console.WriteLine("Content appended successfully");
            }
            else
            {
                Console.WriteLine("File Not Avilable");
            }
        }
        public static void DeleteFIle(string fileName)
        {
            string filePath = fileName + ".txt";
            if (File.Exists(filePath))
            {
                File.Delete(filePath);
                Console.WriteLine("File Deleted Successfully");
            }
            else
            {
                Console.WriteLine("File not Avilable");
            }
        }
    }
}
