using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace RentalSystem
{
    public partial class MainForm : Form
    {
        //保存可租用车的集合
        Dictionary<string, Vehicle> vehicles ;
        //保存租出的车的集合
        Dictionary<string, Vehicle> rentVehicles;
        
        public MainForm()
        {
            InitializeComponent();
        }
        


        private void MainForm_Load(object sender, EventArgs e)
        {
            this.txtLoad.Enabled = false;
            //给程序录入初始数据
            vehicles = new Dictionary<string, Vehicle>();
            Car car = new Car("京R00000", "奥迪A6", "黑色", 3, 240);
            Truck truck = new Truck("京D11111", "东风", "蓝色", 3, 240, 20);
            vehicles.Add(car.LicenseNO, car);
            vehicles.Add(truck.LicenseNO, truck);

            rentVehicles = new Dictionary<string, Vehicle>();
            //录入结算车的初始信息
            Car rentCar = new Car("沪R00000", "宝马318", "白色", 3, 250);
            rentCar.RentUser = this.txtRenter.Text; ;
            Truck rentTruck = new Truck("粤D11111", "东风", "蓝色", 3, 240, 20);
            rentTruck.RentUser = this.txtRenter.Text; 

            rentVehicles.Add(rentCar.LicenseNO, rentCar);
            rentVehicles.Add(rentTruck.LicenseNO, rentTruck);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                string LicenseNO = this.txtAutoNum.Text;
                string name = this.txtName.Text;
                string color = this.cobColor.Text;
                int years = int.Parse(this.txtYears.Text);
                double DailyRent = double.Parse(this.txtLetting.Text);
                int load = 0;
                string type = null;
                if (rdoCar.Checked)
                {
                    type = "car";
                }
                if (rdoTruck.Checked)
                {
                    type = "truck";
                    int.Parse(this.txtLoad.Text);
                }
                Vehicle auto = VehicleFactory.CreateVehicle(LicenseNO, name, color, years, DailyRent, load, type);
                vehicles.Add(auto.LicenseNO, auto);
                MessageBox.Show("添加成功。");
            }
            catch (Exception ex)
            {
                MessageBox.Show("入库数据不正确。");
            }
        }

        private void rdoTruck_CheckedChanged(object sender, EventArgs e)
        {
            this.txtLoad.Enabled = true;
        }

        private void rdoCar_CheckedChanged(object sender, EventArgs e)
        {
            this.txtLoad.Enabled = false;
        }

        private void btnQueryRent_Click(object sender, EventArgs e)
        {
            this.PrintAutos(vehicles,lvRent);
        }

        private void PrintAutos(Dictionary<string, Vehicle> autos,ListView listView)
        {
            listView.Items.Clear();
            if (autos.Count == 0)
            {
                MessageBox.Show("没有数据");
            }
            else
            {
                foreach (Vehicle auto in autos.Values)
                {
                    ListViewItem item = new ListViewItem(auto.LicenseNO);
                    if (auto is Car)
                    {
                        item.SubItems.AddRange(new string[]{auto.Name,auto.Color,auto.YearsOfService.ToString(),
                        auto.DailyRent.ToString(),"无"});
                    }
                    if (auto is Truck)
                    {
                        item.SubItems.AddRange(new string[]{auto.Name,auto.Color,auto.YearsOfService.ToString(),
                        auto.DailyRent.ToString(),((Truck)auto).Load.ToString()});
                    }
                    listView.Items.Add(item);
                }
            }
        }

        private void btnRent_Click(object sender, EventArgs e)
        {
            string key = null;
            if (String.IsNullOrEmpty(this.txtRenter.Text))
            {
                MessageBox.Show("请输入租车人姓名");
                return;
            }
            if (this.lvRent.SelectedItems.Count == 0)
            {
                MessageBox.Show("请选择车辆");
            }
            else
            {
                key = lvRent.SelectedItems[0].Text;
                vehicles[key].RentUser = this.txtRenter.Text;
                rentVehicles.Add(vehicles[key].LicenseNO, vehicles[key]);
                if(vehicles.ContainsKey(key))
                {
                    vehicles.Remove(key);
                }
                PrintAutos(vehicles,lvRent);
                MessageBox.Show("已出租。");
            }
        }

        private void btnQueryReturn_Click(object sender, EventArgs e)
        {
            this.PrintAutos(rentVehicles,lvReturn);
        }

        private void btnCompute_Click(object sender, EventArgs e)
        {
            double totalPrice = 0;
            string key = null;
            if (String.IsNullOrEmpty(this.txtRentDate.Text))
            {
                MessageBox.Show("请输入租车天数");
                return;
            }
            if (this.lvReturn.SelectedItems.Count == 0)
            {
                MessageBox.Show("请选择车辆");
            }
            else
            {
                key = lvReturn.SelectedItems[0].Text;
                rentVehicles[key].RentDate = int.Parse(this.txtRentDate.Text);
                //调用抽象方法
                totalPrice = rentVehicles[key].CalcPrice();
                string msg = string.Format("您的总价是{0}。", totalPrice.ToString());
                MessageBox.Show(msg);

                vehicles.Add(rentVehicles[key].LicenseNO, rentVehicles[key]);

                if (rentVehicles.ContainsKey(key))
                {
                    rentVehicles.Remove(key);
                }
                this.PrintAutos(rentVehicles, lvReturn);
            }
        }
    }
}