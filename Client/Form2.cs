using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;

namespace Client
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void buttonsubmit_Click(object sender, EventArgs e)
        {

            string temp1 = textBox1.Text;
            string temp2 = textBox2.Text;
            string temp3 = textBox3.Text;
            string temp4 = textBox4.Text;
            string[] temparray = { temp1, temp2, temp3, temp4 };
            TextBox[] textboxes = { textBox1, textBox2, textBox3, textBox4 };

            /* string gender = radioButton2.Checked ? "男" : "女";
             bool a = true;
             if (gender == "男") a = true;
             if (gender == "女") a = false;
            */

            if (((!string.IsNullOrEmpty(temp1)) && (!string.IsNullOrEmpty(temp2)) && (!string.IsNullOrEmpty(temp3)) && (!string.IsNullOrEmpty(temp4)) && (radioButton1.Checked || radioButton2.Checked)) == false)
            {
                MessageBox.Show("有欄為空，請補全");
                DialogResult result = MessageBox.Show("您是否強制添加？", "選擇窗口", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {

                    /*
                     * 把數據添加進DB
                     * */
                    MessageBox.Show("添加成功！");
                    textBox1.Text = "";
                    textBox2.Text = "";
                    textBox3.Text = "";
                    textBox4.Text = "";
                    textBox1.Focus();
                }
                else
                {
                    for (int i = 0; i < temparray.Length; i++)
                        if (string.IsNullOrEmpty(temparray[i]) == true)
                        {
                            textboxes[i].Focus();
                            break;
                        }
                }
            }

            else
            { /*
                 * 把數據添加進DB
                 * */
                MessageBox.Show("添加成功！");
                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
                textBox4.Text = "";
                textBox1.Focus();
            }
        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

            if (radioButton2.Checked)
            {
                comboBox1.Items.Clear();
                comboBox1.Items.Add("4");
                comboBox1.Items.Add("5");
                comboBox1.Items.Add("6");
                comboBox1.SelectedIndex = 0;


            }
            else
            {
                comboBox1.Items.Clear();
                comboBox1.SelectedIndex = -1;
            }

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                SendKeys.Send("{tab}");
            }
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                SendKeys.Send("{tab}");
            }
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                SendKeys.Send("{tab}");
            }
        }

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            buttonsubmit.Focus();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {

                comboBox1.Items.Clear();
                comboBox1.Items.Add("1");
                comboBox1.Items.Add("2");
                comboBox1.Items.Add("3");
                comboBox1.SelectedIndex = 0;

            }
            else
            {
                comboBox1.Items.Clear();
                comboBox1.SelectedIndex = -1;
            }
        }

        /* private void radioButton1_Click(object sender, EventArgs e)
         {
             if (radioButton1.Checked)
                 radioButton1.Checked = false;

         }*/

        /*private void radioButton2_Click(object sender, EventArgs e)
        {
            if (radioButton2.Checked)
                radioButton2.Checked = false;
        }*/

        private void radioButton1_MouseClick(object sender, MouseEventArgs e)
        {

            radioButton1.Checked = !radioButton1.Checked;
        }

        private void radioButton2_MouseClick(object sender, MouseEventArgs e)
        {

            radioButton2.Checked = !radioButton2.Checked;
        }
    }
}
