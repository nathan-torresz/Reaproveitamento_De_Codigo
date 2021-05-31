using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Reaproveitamento_de_codigo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btSortear_Click(object sender, EventArgs e)
        {
            int num1 = int.Parse(tbNum1.Text);
            int num2 = int.Parse(tbNum2.Text);

            Random numAleatorio = new Random();
            int a = numAleatorio.Next(num1, num2);

            MessageBox.Show(a.ToString());
        }
    }
}
