using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proiect
{
    public partial class Control_Display : UserControl
    {
        IStocareData adminPersoane = StocareFactory.GetAdministratorStocare();
        int nr_persoane=0;
        public Control_Display()
        {
            InitializeComponent();

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string message = "Agenda is empty";
            string title = "    Error";
            rtbPersoane.Clear();
            if (adminPersoane.GetPersoane().Capacity ==0 )
            
                MessageBox.Show(message, title);
            
            foreach (Agenda s in adminPersoane.GetPersoane())
            {
               
                rtbPersoane.AppendText(s.ConversieLaSir_PentruForma());
                rtbPersoane.SelectionTabs = new int[] { 5, 110, 210, 320, 440, 620, 710 };
                rtbPersoane.AppendText(Environment.NewLine);
            }
        }
       
    }
}
