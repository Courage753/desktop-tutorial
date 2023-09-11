

using Npgsql;
using Npgsql.Internal;
using System.Data;
using System.Data.SqlTypes;
using System.DirectoryServices.ActiveDirectory;
using System.Runtime.CompilerServices;

namespace Client
{

    public partial class Form1 : Form
    {
        NpgsqlConnection conn;
        NpgsqlCommand cmd;
        NpgsqlDataAdapter adp;
        DataSet dat;

        public Form1()
        {
            InitializeComponent();
            comboBox1.SelectedIndex = 0;//默認顯示Combox中的第一個選項

        }
        private void Form1_load(object sender, EventArgs e)
        {
            DataGridViewDataLoad();
        }
        private void DataGridViewDataLoad()
        {
            string sql1 = "select * from Prowell";
            adp = new NpgsqlDataAdapter(sql1, conn);
            dat = new DataSet();
            adp.Fill(dat);
            dataGridView1.DataSource = dat.Tables[0];

        }
        public void adddata()
        {
            InitializeComponent();
        }
        public void adddata_load(object sender, EventArgs e)
        {

        }

        private void buttonadd_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
        
            form2.Show();
            form2.textBox1.Focus();
            //默認男段
           
            
        }
    
        private void comboBox1_SelectedValueChanged(object sender, EventArgs e)
        {
            /*
             * 當combox裡面的名字與數據庫裡面的名字相對應，Datagrid顯示出那一行的信息
             * */
        }

        private void buttondelete_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("是否刪除改信息？", "刪除", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (result == DialogResult.OK)
            {
                /*
                 * 刪除DB中的數據，選中一個刪除整行
                 * */
            }
        }
    }

}