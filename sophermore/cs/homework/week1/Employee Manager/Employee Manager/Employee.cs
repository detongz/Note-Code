using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee_Manager
{
    public enum Gender
    {
        男, 女
    }
    public enum Department
    {
        技术部, 市场部, 人事部
    }
    public class Employee
    {
        public string Name { get; set; }
        public string ID { get; set; }
        public Gender Gender { get; set; }
        public string Birtyday { get; set; }
        public string Email { get; set; }
        public Department Department { get; set; }

    }
}
