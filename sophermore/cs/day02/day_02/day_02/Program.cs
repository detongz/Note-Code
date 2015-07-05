using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day_02
{
    public class Email{
        public void GetUserName()
        {
            string choice;//用户的选择
            do{
                PicckNameFromEmail();
                Console.WriteLine("continue or not? yes/no");
                choice = Console.ReadLine();
                choice = choice.Trim().ToLower();
            }while(choice.Equals("yes"));
        }
        //接受用户邮箱
        private void PicckNameFromEmail()
        {
            string name;//username
            string email;//邮箱
            Console.WriteLine("input email add");
            email = Console.ReadLine();
            int position = email.IndexOf("@");
            if (position > 0)
            {
                name = email.Substring(0, position);
                Console.WriteLine("your user name is{0}", name);
            }
            else
            {
                Console.WriteLine("email input error");
            }
        }
    }
    class Student
    {
        public string name;
        public int age;
        public void Show()
        {
            Console.WriteLine("name{0},age{1}",name,age);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            /*int[] array = new int[5] { 9, 8, 7, 6, 5 };
            Console.WriteLine("数组元素个数是{0}", array.Length);
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);
            }

            foreach (int i in array)
            {
                Console.WriteLine(i);
            }
            Student [] stu = new Student[3];
            stu[0] = new Student();
            stu[0].name = "mike";
            stu[0].age = 20;

            stu[1] = new Student();
            stu[1].name = "miaaasdfasdfae";
            stu[1].age = 22;

            stu[2] = new Student();
            stu[2].name = "shdfike";
            stu[2].age = 29;

            foreach (Student student in stu)
            {
                student.Show();
            }*/
            ///
            /// c#冒泡排序
            ///
            /*
            int[] scors = new int[5];
            int i, j;
            int temp;
            Console.WriteLine("input 6 student scores:");
            for (i = 0; i < 5; i++)
            {
                Console.WriteLine("please input score NO.{0}:", i + 1);
                scors[i] = Convert.ToInt16(Console.ReadLine());
            }
            for (i = 0; i < scors.Length-1; i++)
            {
                for (j = 0; j < scors.Length - 1 - i; j++)
                {
                    if (scors[j]>scors[j + 1])
                    {
                        temp = scors[j];
                        scors[j] = scors[j + 1];
                        scors[j + 1] = temp;
                    }
                }
            }
            Console.WriteLine("\nthe result is");
            foreach (int s in scors)
            {
                Console.Write("{0}\t", s);
            }*/
            //Email email = new Email;
            //email.GetUserName();
        }
    }
}
