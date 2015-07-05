using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
  
    public partial class Form2 : Form
    {
        Person_zdt man_hs = new Person_zdt();
        string tempName_zdt;
        string tempNumber_zdt;
        /// <summary>
        /// 判断是否是修改联系人调用
        /// </summary>
        Boolean change_hs = false;
        public Form1 frm1_hs { get; set; }
        public Form2 frm2_hs { get; set; }
        /// <summary>
        /// 重载构造函数实现修改联系人时初始化控件
        /// </summary>
        /// <param name="changeList"></param>
        public Form2(List<Person_zdt> changeList)
        {
            InitializeComponent();
            this.cmbGender.SelectedIndex = 0;
            this.cmbRelationship.SelectedIndex = 0;
            //若为修改联系人，则初始化控件信息
            #region
            if (changeList.Count == 1)
            {
                //初始化控件
                foreach(Person_zdt item_hs in changeList)
                {
                    this.txtName.Text = item_hs.Name_zdt;
                    this.txtAddress.Text = item_hs.Address_zdt;
                    this.txtNumber.Text = item_hs.Number_zdt;
                    this.txtUnit.Text = item_hs.Unit_zdt;
                    if (item_hs.Gender_zdt == Gender.男)
                    {
                        this.cmbGender.SelectedIndex = 0;
                    }
                    else
                    {
                        this.cmbGender.SelectedIndex = 1;
                    }
                    if (item_hs.Relationship_zdt == Relationship.朋友)
                    {
                        this.cmbRelationship.SelectedIndex = 0;
                    }
                    else if (item_hs.Relationship_zdt == Relationship.同事)
                    {
                        this.cmbRelationship.SelectedIndex = 1;
                    }
                    else
                    {
                        this.cmbRelationship.SelectedIndex = 2;
                    }
                    //保留信息
                    man_hs.Name_zdt = item_hs.Name_zdt;
                    man_hs.Address_zdt = item_hs.Address_zdt;
                    man_hs.Number_zdt = item_hs.Number_zdt;
                    man_hs.Unit_zdt = item_hs.Unit_zdt;
                    tempName_zdt = item_hs.Name_zdt;
                    tempNumber_zdt = item_hs.Number_zdt;
                }
                change_hs = true;
            }
            #endregion

        }
        public Form2()
        {
            InitializeComponent();
            this.cmbGender.SelectedIndex = 0;
            this.cmbRelationship.SelectedIndex = 0;

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            #region
            {
                
                man_hs.Name_zdt = txtName.Text;
                man_hs.Number_zdt = txtNumber.Text.Trim();
                man_hs.Address_zdt = txtAddress.Text;
                man_hs.Unit_zdt = txtUnit.Text;
                //获取信息
                if(cmbGender.SelectedItem.ToString() == "男")
                {
                    man_hs.Gender_zdt = Gender.男;
                }
                else
                {
                    man_hs.Gender_zdt = Gender.女;
                }
                if(cmbRelationship.SelectedItem.ToString() == "朋友")
                {
                    man_hs.Relationship_zdt = Relationship.朋友;
                }
                else if(cmbRelationship.SelectedItem.ToString() == "家人")
                {
                    man_hs.Relationship_zdt = Relationship.家人;
                }
                else
                {
                    man_hs.Relationship_zdt = Relationship.同事;
                }
                
                foreach (Person_zdt item_hs in frm1_hs.manList_hs)
                {
                    if(!change_hs)
                    {
                        if (item_hs.Name_zdt == man_hs.Name_zdt && item_hs.Number_zdt == man_hs.Number_zdt)
                        {
                            MessageBox.Show("联系人已经存在，请重新输入");
                            return;
                        }
                    }
                    else
                    {
                        if (item_hs.Name_zdt == tempName_zdt && item_hs.Number_zdt == tempNumber_zdt)
                        {
                            frm1_hs.manList_hs.Remove(item_hs);
                            break;
                        }
                    }
                    
                }             
               frm1_hs.manList_hs.Add(man_hs);
            }
            #endregion
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                this.Close();
                frm1_hs.BinddgvContact_hs(frm1_hs.manList_hs);
            }
        }

        private void phonePress_hs(object sender, KeyPressEventArgs e)
        {
            if(!(Char.IsNumber(e.KeyChar)) && e.KeyChar != (char)8)
            {
                e.Handled = true;//判断为数字
            }
           
        }
    }
}
