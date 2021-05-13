using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace puebas_parcial_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            try
            {
                int dato1 = 16;
                String dato2 = "25g";
                int resultado = dato1 + Convert.ToInt32(dato2);

            }
            catch(Exception ex)
            {
                MessageBox.Show("Lo sentimos no se puede realizar la operacionsolicitada" + ex.ToString());
            }
            
        }
    }
}
