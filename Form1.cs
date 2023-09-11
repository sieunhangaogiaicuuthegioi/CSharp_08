using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharp_08
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
        String can, chi;

        private void button1_Click(object sender, EventArgs e)
        {
            switch (Convert.ToInt32(txtDuongLich.Text.Substring(3,  1)))  {
                case 0:
                    can = "Canh";
                    break;
                case 1:
                    can = "Tân";
                    break;
                case 2:
                    can = "Nhâm";
                    break;
                case 3:
                    can = "Quý";
                    break;
            }
            switch (Convert.ToInt32(txtDuongLich.Text)  % 12) {
                case 7:
                    chi = "Mão";
                    break;
                case 1:
                    chi = "Tân";
                    break;
                case 2:
                    chi = "Nhâm";
                    break;
                case 3:
                    chi = "Quý";
                    break;
                
            }
            txtAmLich.Text = can + " " + chi;
        }
    }
}
