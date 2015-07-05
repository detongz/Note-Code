using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace day_02_part2
{
    class Program
    {
        static void Main(string[] args)
        {
           /* ArrayList arr = new ArrayList();
            arr.Add(5);
            arr.Add("hello");
            arr.Add(8.9);
            arr.Add(new student());

            int i = Convert.ToInt32(arr[0]);
            string s = arr[1].ToString();
            double d = Convert.ToDouble(arr[2]);
            student stu = (student)arr[3];

            arr.RemoveAt(0);
            arr.Remove("hello");
            arr.Insert(1, "pp");*/
           
            
            student stu1 = new student();
            stu1.id = 1001;
            stu1.name = "mike";

            student stu2 = new student();
            stu1.id = 1002;
            stu1.name = "aike";

            student stu3 = new student();
            stu1.id = 1003;
            stu1.name = "bike";

            /*
            Hashtable ht = new Hashtable();
            ht.Add(stu1.id, stu1);
            ht.Add(stu2.id, stu2);
            ht.Add(stu3.id, stu3);

            Console.WriteLine(ht.Count);

            foreach (Object obj in ht.Keys)
            {
                Console.WriteLine("student id:" + obj.ToString());
            }
            foreach(Object obj in ht.Values){
                Console.WriteLine("student name" + ((student)obj).name);
            }
            foreach (DictionaryEntry en in ht)
            {
                Console.WriteLine("student id:"+en.Key);
                Console.WriteLine("student name:" + ((student)en.Value).name);
            }

            ht.Remove("1001");//字典删除要删除键，不根据值删除*/
            //list<>是arraylist的泛型集合
            List<student> list = new List<student>();
            list.Add(stu1);
            list.Add(stu2);
            //dictionary<>是hashtable的泛型集合
            Dictionary<int, student> dic = new Dictionary<int, student>();
            dic.Add(stu1.id, stu1);


            ///用反省集合完成一个个人通讯录
            ///功能：查看个人所有通讯记录，可以增删改查通讯录，查找：根据姓名找到电话号码
            ///窗体应用或控制台应用
        }
    }
}
