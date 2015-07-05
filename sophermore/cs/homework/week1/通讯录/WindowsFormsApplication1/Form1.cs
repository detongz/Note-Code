using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        /// <summary>
        /// 用于保存联系人信息
        /// </summary>
        public List<Person_zdt> manList_hs = new List<Person_zdt>();
        /// <summary>
        /// 用户保存要修改联系人的信息
        /// </summary>
        public List<Person_zdt> changeList_hs = new List<Person_zdt>();
        /// <summary>
        /// 用户保存查找的联系人的信息
        /// </summary>
        public List<Person_zdt> searchList_hs = new List<Person_zdt>();
        public Form1()
        {
            InitializeComponent();
            this.dgvContact.AutoGenerateColumns = false;
            cmbGroup.SelectedIndex = 0;
        }

        /// <summary>
        /// 绑定集合中的信息到控件中
        /// </summary>
        /// <param name="list"></param>
        public void BinddgvContact_hs(List<Person_zdt> list)
        {
            this.dgvContact.DataSource = new BindingList<Person_zdt>(list);
        }

        /// <summary>
        /// 添加联系人
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAdd_Click(object sender, EventArgs e)
        {
            Form2 frm2_hs = new Form2();
            frm2_hs.frm1_hs = this;
            frm2_hs.ShowDialog();
        }

       
        /// <summary>
        /// 删除联系人
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (this.dgvContact.SelectedRows.Count == 0)
            {
                MessageBox.Show("请选择你要删除的联系人");
                return;
            }
            DialogResult rt_hs = MessageBox.Show("确实要删除这个联系人吗？", "确认信息",MessageBoxButtons.YesNo);
            if (rt_hs != DialogResult.Yes)
            {
                return;
            }
            string Name_zdt = this.dgvContact.CurrentRow.Cells["Name_zdt"].Value.ToString();
            string Number_zdt = this.dgvContact.CurrentRow.Cells["Number_zdt"].Value.ToString();

            foreach (Person_zdt item_hs in manList_hs)
            {
                if (item_hs.Name_zdt == Name_zdt && item_hs.Number_zdt == Number_zdt)
                {
                    manList_hs.Remove(item_hs);
                    break;
                }
            }
            BinddgvContact_hs(manList_hs);
            MessageBox.Show("删除成功");
        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            if (this.dgvContact.SelectedRows.Count == 0)
            {
                MessageBox.Show("请选择你要修改的联系人");
                return;
            }
            string Name_zdt = this.dgvContact.CurrentRow.Cells["Name_zdt"].Value.ToString();
            string Number_zdt = this.dgvContact.CurrentRow.Cells["Number_zdt"].Value.ToString();
            foreach(Person_zdt item_hs in manList_hs)
            {
                if(Name_zdt == item_hs.Name_zdt && Number_zdt == item_hs.Number_zdt)
                {
                    changeList_hs.Add(item_hs);
                    break;
                }
            }
            Form2 frm2_hs = new Form2(changeList_hs);
            frm2_hs.frm1_hs = this;
            frm2_hs.ShowDialog();
            changeList_hs.RemoveAt(0);//清空修改列表
        }

        private void btnSearchByName_Click(object sender, EventArgs e)
        {
            searchList_hs.Clear();
            string Name_zdt = txtByName.Text;
            foreach(Person_zdt item_hs in manList_hs)
            {
                if(item_hs.Name_zdt.Contains(Name_zdt))
                {
                    searchList_hs.Add(item_hs);
                }
            }
            if(searchList_hs.Count > 0)
            {
                this.BinddgvContact_hs(searchList_hs);
            }
            else
            {
                MessageBox.Show("没有匹配的联系人！");
                return;
            }
        }

        private void btnSearchByNumber_Click(object sender, EventArgs e)
        {
            searchList_hs.Clear();
            string Number_zdt = txtByNumber.Text;
            foreach (Person_zdt item_hs in manList_hs)
            {
                if (item_hs.Number_zdt.Contains(Number_zdt))
                {
                    searchList_hs.Add(item_hs);
                }
            }
            if (searchList_hs.Count > 0)
            {
                this.BinddgvContact_hs(searchList_hs);
            }
            else
            {
                MessageBox.Show("没有匹配的联系人！");
                return;
            }
        }

        private void btnSearchByGroup_Click(object sender, EventArgs e)
        {
            if(searchList_hs.Count > 0)
            {
                searchList_hs.Clear();
            } 
            Relationship group = Relationship.朋友;
            if(cmbGroup.SelectedIndex == 0)
            {
                group = Relationship.朋友;
            }
            else if(cmbGroup.SelectedIndex == 1)
            {
                group = Relationship.同事;
            }
            else if(cmbGroup.SelectedIndex == 2)
            {
                group = Relationship.家人;
            }
            if(cmbGroup.SelectedIndex != 3)
            {
                foreach (Person_zdt item_hs in manList_hs)
                {
                    if (item_hs.Relationship_zdt == group)
                    {
                        searchList_hs.Add(item_hs);
                    }
                }
                if (searchList_hs.Count > 0)
                {
                    this.BinddgvContact_hs(searchList_hs);
                }
                else
                {
                    MessageBox.Show("没有匹配的联系人！");
                    return;
                }
            }
            else
            {
                this.BinddgvContact_hs(manList_hs);
            }

        }

        private void dgvContact_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        
    }
}
