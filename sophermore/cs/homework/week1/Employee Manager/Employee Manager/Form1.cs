using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Employee_Manager
{
    public partial class Form1 : Form
    {
        /// <summary>
        /// 用于保存员工信息
        /// </summary>
        public List<Employee> emList = new List<Employee>();
        public Form1()
        {
            InitializeComponent();
            radioButton1.Checked = true;
            radioButton3.Checked = true;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            //判断操作
            #region
            int choice = 0;
            foreach (Control c in groupBox2.Controls)
            {
                if (c is RadioButton)
                {
                    if (((RadioButton)c).Checked == true)
                    {
                        if(c.Text.Equals("Insert"))
                        {
                            choice = 0;
                        }
                        else if(c.Text.Equals("Update"))
                        {
                            choice = 1;
                        }
                        else
                        {
                            choice = 2;
                        }

                    }
                }
            }
            #endregion
            //插入操作
            #region
            if (choice == 0)
            {
                Employee em = new Employee();
                em.ID = txtID.Text.Trim();
                em.Name = txtName.Text;
                em.Email = txtEmail.Text;
                em.Birtyday = dtpBirthday.Text;
                foreach (Control c in groupBox1.Controls)
                {
                    if (c is RadioButton)
                    {
                        if (((RadioButton)c).Checked == true)
                        {
                            if (c.Text.Equals("Male"))
                            {
                                em.Gender = Gender.男;
                            }
                            else
                            {
                                em.Gender = Gender.女;
                            }
                        }
                    }
                }
                if (cmbDepartment.SelectedItem.ToString().Equals("技术部"))
                {
                    em.Department = Department.技术部;
                }
                else if (cmbDepartment.SelectedItem.ToString().Equals("市场部"))
                {
                    em.Department = Department.市场部;
                }
                else
                {
                    em.Department = Department.人事部;
                }
                foreach (Employee item in emList)
                {
                    if (item.ID == em.ID)
                    {
                        MessageBox.Show("此员工号已经存在，请重新输入");
                        return;
                    }
                }
                emList.Add(em);
                lbName.Items.Add(em.Name);
            }
            #endregion
            //修改操作
            #region
            else if(choice == 1)
            {
                Employee em = new Employee();
                string name = lbName.SelectedItem.ToString();
                foreach (Employee item in emList)
                {
                    if (item.Name == name)
                    {
                        em.ID = txtID.Text.Trim();
                        em.Name = txtName.Text;
                        em.Email = txtEmail.Text;
                        em.Birtyday = dtpBirthday.Text;
                        foreach (Control c in groupBox1.Controls)
                        {
                            if (c is RadioButton)
                            {
                                if (((RadioButton)c).Checked == true)
                                {
                                    if (c.Text.Equals("Male"))
                                    {
                                        em.Gender = Gender.男;
                                    }
                                    else
                                    {
                                        em.Gender = Gender.女;
                                    }
                                }
                            }
                        }
                        if (cmbDepartment.SelectedItem.ToString().Equals("技术部"))
                        {
                            em.Department = Department.技术部;
                        }
                        else if (cmbDepartment.SelectedItem.ToString().Equals("市场部"))
                        {
                            em.Department = Department.市场部;
                        }
                        else
                        {
                            em.Department = Department.人事部;
                        }
                        //foreach (Employee EM in emList)
                        //{
                        //    if (EM.Name == em.Name && EM.Name != name)
                        //    {
                        //        MessageBox.Show("此员工号已经存在，请重新输入");
                        //        return;
                        //    }
                        //}
                        emList.Remove(item);
                        emList.Add(em);
                        lbName.Items.Remove(lbName.SelectedItem);
                        lbName.Items.Add(em.Name);
                        return;
                    }
                }
            }
            #endregion
            //删除操作
            #region
            else
            {
                Employee em = new Employee();
                if (lbName.SelectedItems.Count <= 0)
                {
                    MessageBox.Show("请选择你要删除的联系人");
                    return;
                }
                else
                {
                    DialogResult rt_hs = MessageBox.Show("确实要删除该员工信息吗？", "确认信息", MessageBoxButtons.YesNo);
                    if (rt_hs != DialogResult.Yes)
                    {
                        return;
                    }
                    string name = lbName.SelectedItem.ToString();
                    foreach (Employee item in emList)
                    {
                        if (item.Name == name)
                        {
                            emList.Remove(item);
                            MessageBox.Show("删除成功！");
                            lbName.Items.Remove(lbName.SelectedItem);
                            return;
                        }
                    }
                }
                
                
            }
            #endregion

        }

        /// <summary>
        /// 选中名字显示详细信息
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lbName_MouseClick(object sender, MouseEventArgs e)
        {
            Employee em = new Employee();
            string name = lbName.SelectedItem.ToString();
            foreach (Employee item in emList)
            {
                if (item.Name == name)
                {
                    txtID.Text = item.ID;
                    txtName.Text = item.Name;
                    txtEmail.Text = item.Email;
                    dtpBirthday.Text = item.Birtyday;
                    if(item.Gender == Gender.男)
                    {
                        radioButton1.Checked = true;
                    }
                    else
                    {
                        radioButton2.Checked = true;
                    }
                    if(item.Department == Department.技术部)
                    {
                        cmbDepartment.SelectedIndex = 0;
                        
                    }
                    else if(item.Department == Department.人事部)
                    {
                        cmbDepartment.SelectedIndex = 1;
                        
                    }
                    else
                    {
                        cmbDepartment.SelectedIndex = 2;
                        
                    }
                    
                }
                
            }
            
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCancle_Click(object sender, EventArgs e)
        {
            txtID.Text = "";
            txtName.Text = "";
            txtEmail.Text = "";
            dtpBirthday.Text = DateTime.Now.ToString();
            radioButton1.Checked = true;
            radioButton3.Checked = true;
            cmbDepartment.SelectedIndex = 0;
        }

        
    }
}
