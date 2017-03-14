using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Password_add_Sample
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int P_int_Num, P_int_Key;//定义两个值类型变量
            if (int.TryParse(textBox1.Text, out P_int_Num) && int.TryParse(textBox2.Text, out P_int_Key))
            {
                label4.Text = (P_int_Num ^ P_int_Key).ToString();
            }
            else {
                MessageBox.Show("please input the num again.", "error occured");
            }
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int P_int_Keys,P_int_Encrypt;

            P_int_Keys = int.Parse(label4.Text);
            P_int_Encrypt = int.Parse(textBox2.Text);
            if (int.TryParse(label4.Text, out P_int_Keys) && int.TryParse(textBox2.Text, out P_int_Encrypt))
            {
                label3.Text = (P_int_Encrypt ^ P_int_Keys).ToString();
            }
            else {
                MessageBox.Show("please input again.","error");
            }
        }
    }
}
