using System;


namespace ConAppAssignment10
{
    public class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Select the Operation");
                Console.WriteLine("1.Create a File\n2.Read a File \n3.Append to a File\n4.Delete a File");
                
                string input;
                input = Console.ReadLine();
                
                    switch (input)
                    {

                        case "1":

                            string fPAth;
                            Console.WriteLine("Enter File Path");
                            fPAth = Console.ReadLine();
                            String Content;
                            Console.WriteLine("Enter the Content");
                            Content = Console.ReadLine();
                          
                            FilleHandling.CreateFile(fPAth, Content);
                            break;

                        case "2":
                            Console.WriteLine("Enter the file name:");
                            string fName = Console.ReadLine();

                            string fileContent = FilleHandling.ReadFile(fName);
                            Console.WriteLine(fileContent);
                        Console.WriteLine("File Readed Successfully");
                        break;

                        case "3":
                            Console.WriteLine("Enter File Path");
                            string FPath = Console.ReadLine();
                            Console.WriteLine("ENter File Content");
                            string ConTent = Console.ReadLine();
                            FilleHandling.AppendToFIle(FPath, ConTent);
                            break;

                        case "4":
                            Console.WriteLine("Enter File NAme");
                            String DeleFile = Console.ReadLine();
                            FilleHandling.DeleteFIle(DeleFile);
                            break;

                        default:
                            Console.WriteLine("Invalid choice. Please try again.");
                            break;
                    }
                

                    Console.ReadKey();
                }
        }
        }
    }

