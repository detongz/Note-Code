using System;
using System.Collections.Generic;
using System.Text;

namespace RentalSystem
{
    public class Truck:Vehicle
    {
        public Truck(string licenseNO, string name, string color, int yearsOfService, double dailyRent, int load)
            : base(licenseNO, name, color, yearsOfService, dailyRent)
        {
            this.Load = load;
        }
        
        private int load;
        public int Load
        {
            get { return load; }
            set { load = value; }
        }

        /// <summary>
        /// �������ü��㷽��
        /// 30������(��30)����������
        /// 30�����ϳ�������:ÿ�죬ÿ�֣������������������10%
        /// </summary>
        public override double CalcPrice()
        {
            double totalPrice = 0;
            double basicPrice = this.RentDate * this.DailyRent;
            if (this.RentDate <= 30)
            {
                totalPrice = basicPrice;
            }
            else
            { 
                //30�����ϳ�������:ÿ�죬ÿ�֣������������������10%
                totalPrice = basicPrice + (this.RentDate - 30) * this.Load * this.DailyRent * 0.1;
            }
            return totalPrice;
        }
    }
}
