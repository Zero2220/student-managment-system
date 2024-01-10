using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace ConsoleApp1
{
    internal class Program
    {
        static Stopwatch stopwatch = new Stopwatch();
        static void Main(string[] args)
        {
            //2. Menu penceresini consoleda gostermek.Menu penceresi asagidaki yazilardan ibaretdir.
            //1.Butun telebelere bax

            // 2.Telebe elave et

            // 3.Telebeler uzerinde axtaris et

            // 4.Secilmis nomreli telebeni goster

            //5.Secilmis nomreli telebeni sil

            //0.Cix
           

            string operation;
            string[] students = {"Ekber","Akif","Asif","Adem"};
            int[] ages = { 16, 24, 26, 20 };
            string name;
            int age;
            DateTime date1 = DateTime.Now;
            
            do
            {

                Console.WriteLine("--------------Menu---------------");
                Console.WriteLine("1.Butun telebelere bax");
                Console.WriteLine("2.Telebe elave et");
                Console.WriteLine("3.Telebeler uzerinde axtaris et");
                Console.WriteLine("4.Secilmish nomreli telebeni goster");
                Console.WriteLine("5.Secilmish nomreli telebeni sil");
                Console.WriteLine("0.Cix");


                operation = Console.ReadLine();

                switch (operation)
                {
                    case "1":
                        for (int i = 0; i < students.Length; i++)
                        {
                            Console.WriteLine($"Ad:{students[i]} Yas:{ages[i]}");


                        }
                        break;
                    case "2":

                        do
                        {
                            Console.WriteLine("Telebenin adini daxil edin ");
                            name = Console.ReadLine();
                            Console.WriteLine("Telebenin yasini daxil edin ");
                            age = Convert.ToInt32(Console.ReadLine());

                        }
                        while (name.Length < 3 || name.Length >20 || age>65 || age<3);
                        

                        addStudent(ref students,  name);
                        Array.Resize(ref ages, ages.Length + 1);

                        ages[ages.Length - 1] = age;
                        break;
                    case "3":
                        Console.WriteLine("herf daxil edin ");

                        int count =0;

                        char  search = Convert.ToChar(Console.ReadLine());

                        string[] matchNames = new string[1];

                        for(int i = 0;i<students.Length;i++)
                        {

                            for(int j = 0;j < students[i].Length; j++)
                            {
                                if (students[i][j] == search)
                                {

                                    
                                    matchNames[count] = students[i] ;
                                    count++;
                                    Array.Resize(ref matchNames, count);
                                }


                            }

                        }
                        for(int i = 0; i < count; i++)
                        {
                            Console.WriteLine(matchNames[i]);

                        }
                        break;

                    case "4":
                        Console.WriteLine("Telebe adini daxil edin ");
                            int studentName = Convert.ToInt32(Console.ReadLine());

                            for(int i = 0;i<students.Length;i++)
                            {

                              if (studentName == i)
                              {

                                Console.WriteLine($"Ad:{students[i]} Yas:{ages[i]}"); 
                                
                                break;
                              }

                            }

                    break;

                    case "5":

                          Console.WriteLine("Telebenin nomresini daxil edin");
                                
                          int nameIndex = Convert.ToInt32(Console.ReadLine());
                          
                          deleteName(ref students,nameIndex);
                        int[] newArray = new int[ages.Length - 1];

                        for (int i = 0; i < newArray.Length; i++)
                        {

                            if (i == nameIndex)
                            {

                                continue;

                            }
                            newArray[i] = ages[i];
                        }

                        Array.Resize(ref ages, ages.Length - 1);

                        ages = newArray;






                    break;

                    case "0":


                       
                    break;

                    default:
                        
                        Console.WriteLine("yanlish eded");

                    break;

                    


                }



            }
            while (operation !="0");


            
            stopwatch.Stop();
            Console.WriteLine($"kecirilen umumi vaxt: {stopwatch.Elapsed}");


        }
        static void addStudent(ref string[] students,string name)
        {
            Array.Resize(ref students,students.Length +1);

            students[students.Length-1] = name;

            

        }

        static void deleteName(ref string[] students,int nameIndex)
        {

            string[]  newArray = new string[students.Length -1];

            for(int i = 0;i<newArray.Length; i++)
            {

                if (i == nameIndex)
                {

                    continue;

                }
                newArray[i]= students[i];
            }

            Array.Resize(ref students,students.Length-1) ;

            students = newArray;



        }


    }
}
