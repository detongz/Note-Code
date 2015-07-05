using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    public enum Gender
    {
        男, 女
    }
    public enum Relationship
    {
        朋友, 家人, 同事
    }
    public class Person_zdt
    {
        /// <summary>
        /// 联系人姓名
        /// </summary>
        public string Name_zdt{ get; set; }
        /// <summary>
        /// 联系人性别
        /// </summary>
        public Gender Gender_zdt { get; set; }
        /// <summary>
        /// 联系人单位
        /// </summary>
        public string Unit_zdt { get; set; }
        /// <summary>
        /// 联系人电话
        /// </summary>
        public string Number_zdt { get; set; }
        /// <summary>
        /// 联系人住址
        /// </summary>
        public string Address_zdt { get; set; }
        /// <summary>
        /// 联系人关系
        /// </summary>
        public Relationship Relationship_zdt { get; set; }
            

    }
}
