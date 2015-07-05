using System;
using System.Collections.Generic;
using System.Text;

namespace RentalSystem
{
    /// <summary>
    /// 简单工厂创建汽车对象
    /// </summary>
    public class VehicleFactory
    {
        public static Vehicle CreateVehicle(string licenseNO, string name, string color, int yearsOfService, 
            double dailyRent, int load, string type)
        {
            Vehicle vehicle = null;
            switch (type)
            {
                case "car":
                    vehicle = new Car(licenseNO, name, color, yearsOfService,dailyRent);
                    break;
                case "truck":
                    vehicle = new Truck(licenseNO, name, color,yearsOfService, dailyRent,load);
                    break;
            }
            return vehicle;
        }
    }
}
