using System;
using System.Collections.Generic;
using System.Text;

namespace RentalSystem
{
    public class Car:Vehicle
    {
        public Car(string licenseNO, string name, string color, int yearsOfService, double dailyRent)
            : base(licenseNO, name, color, yearsOfService, dailyRent)
        {
            ;
        }

        /// <summary>
        /// �γ��ļ۸���㷽����
        /// 30������(��30)����������
        /// 30�����ϳ�������:ÿ�����������10%
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
                totalPrice = basicPrice + (this.RentDate - 30) * this.DailyRent * 0.1;
            }
            return totalPrice;
        }
    }
}
