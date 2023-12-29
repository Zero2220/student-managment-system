using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace project1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int[] nums = { 1, 2, 3, 4 };


            int num2 = 5;


            addArrey(ref nums,ref  num2);


            for (int i = 0;i<nums.Length;i++)
            {

                Console.WriteLine(nums[i]);


            }




        }


        //Verilmiş ədədi kvadratına yüksəldən metod. (Metodu cağırdıqdan sonra variable kvadratına yüksəlmiş olmalıdı)

        static void result(ref int num)
        {
            int total = 1;

            for (int i = 0; i < 2; i++)
            {
                total *= num;


            }

            num = total;


        }

        //Verilmiş ədədlər siyahısını içindəki
        //bütün ədədlər kvadratına yüksəlmiş array-ə çevirən metod

        static void listpower(ref int[] num1)
        {


            

            
            for (int i = 0;i < num1.Length; i++)
            {
                num1[i] *= num1[i];


            }

            

        }

        //Parametr olaraq 1 string dəyər qəbul edən və həmin
        //string dəyəri icində bosluqlar qalmayacaq hala gətirən metod
        //.Misal olaraq, name = " Hikmet  Abbasov " deyə bir variable-mız varsa
        //onu yaratdigimiz metoda göndərdikdə variable-daki dəyər "HikmətAbbasov" olmalıdır.


        static void noSpace(ref string text)
        {

            string newText = "";

            for (int i =0;i<text.Length;i++)
            {
                if(text[i]!=' ')
                {

                    newText += text[i];

                }


            }

            text = newText;
            

        }

        //Parameter olaraq integer array variable-i ve
        //bir integer value qebul eden ve hemin integer value-nu integer array-e yeni element kimi elave eden metod
        //. Misal üçün int[] nums = {1,5,7} deyə bir variable-mız var.yazdığımız metodu
        //çağırıb arqument olaraq nums və 3 göndərsək nums arrayının dəyəri  {1,5,7,3} olmalıdır.

        static void addArrey(ref int[] nums, ref int num2)
        {

            int[] newArr = new int[nums.Length + 1];


            for (int i = 0;i<nums.Length;i++)
            {

                newArr[i] = nums[i];



            }

            newArr[nums.Length] = num2;

            nums = newArr;



        }
    }



}
