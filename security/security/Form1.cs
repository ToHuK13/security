using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace security
{
    public partial class AutorizeForm : Form
    {
        public AutorizeForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Static.Con = new SqlConnection("Data Source='" + textBox1.Text + "';Password=078013;User ID=sa;Initial Catalog=LIG;Persist Security Info=True;"); 
            SqlDataAdapter sda = new SqlDataAdapter("Select Count(*) From Users where UserName = '" + textBox2.Text + "' and Password = '" + maskedTextBox1.Text + "'", Static.Con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            if (dt.Rows[0][0].ToString() == "1")
            {
                this.Hide();   
                Main ss = new Main();
                ss.Show();
            }
            else {
                MessageBox.Show("check username or password");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
