using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Nhom8_Bai3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dateTimePicker1.Text = DateTime.Now.ToString();
            string[] s1 = { "SV001", "Trần Văn Nam", "20/08/1985 ", "Công nghệ thông tin" };
            string[] s2 = { "SV002", "Nguyễn Thị Tuyết", "25/08/1986 ", "Kế toán khoa 1" };
            string[] s3 = { "SV003", "Nguyễn Thị Kim Tuyến", "21/03/1984", "Kế toán khoa 1" };
            ListViewItem item1 = new ListViewItem(s1);
            ListViewItem item2 = new ListViewItem(s2);
            ListViewItem item3 = new ListViewItem(s3);
            listView1.Items.Add(item1);
            listView1.Items.Add(item2);
            listView1.Items.Add(item3);
            btn_save.Enabled = false;
            btn_notsave.Enabled = false;
            string[] temp = { "Công nghệ thông tin", "Kế toán khoa !" };
            foreach(string s in temp)
            {
                comboBox1.Items.Add(s);
            }
            comboBox1.Text = "Công nghệ thông tin ";
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            try
            {
                int idx = findIndex(textBox1.Text);
                if (idx == -1)
                {
                    string[] s = { textBox1.Text, textBox2.Text, dateTimePicker1.Text, comboBox1.Text };
                    ListViewItem item = new ListViewItem(s);
                    listView1.Items.Add(item);
                    MessageBox.Show("Them thanh cong !");
                }
                else
                {
                    MessageBox.Show("Da co data");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private int findIndex(string stk)
        {
            if (listView1.Items.Count > 0)
            {
                for (int i = 0; i < listView1.Items.Count; i++)
                {
                    if ((listView1.Items[i].SubItems[0].Text) == stk)
                    {
                        return i;
                    }
                }
            }
            return -1;
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                btn_save.Enabled = true;
                btn_notsave.Enabled = true;
                textBox1.Text = listView1.SelectedItems[0].SubItems[0].Text;
                textBox2.Text = listView1.SelectedItems[0].SubItems[1].Text;
                dateTimePicker1.Text = listView1.SelectedItems[0].SubItems[2].Text;
                comboBox1.Text = listView1.SelectedItems[0].SubItems[3].Text;
            }
           
        }

        private void btn_mod_Click(object sender, EventArgs e)
        {
            try
            {
                int idx = findIndex(textBox1.Text);
                if (idx != -1)
                {
                    listView1.Items[idx].SubItems[0].Text = textBox1.Text;
                    listView1.Items[idx].SubItems[1].Text = textBox2.Text;
                    listView1.Items[idx].SubItems[2].Text = dateTimePicker1.Text;
                    listView1.Items[idx].SubItems[3].Text = comboBox1.Text;
                    MessageBox.Show("Sua thanh cong !");
                }
                else
                {
                    MessageBox.Show("Da co data");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_del_Click(object sender, EventArgs e)
        {
            if (listView1.Items.Count > 0)
            {
                listView1.Items.RemoveAt(findIndex(textBox1.Text));
            }
            else
            {
                MessageBox.Show("Khong co tai khoan can xoa !");
            }

        }
    }
}
