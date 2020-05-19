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
    public partial class Control_Insert : UserControl
    {
        IStocareData adminPersoane1 = StocareFactory.GetAdministratorStocare();

        Grup textFlagsGrup = Grup.Familie;
        Provenienta textFlagsProvenienta = Provenienta.Anglia;

    
        public Control_Insert()
        {
            InitializeComponent();
            foreach (string name in Enum.GetNames(typeof(Grup)))
            {
                cmbGrupa.Items.Add(name);
            }
            cmbGrupa.SelectedIndex = -1;
            cmbGrupa.SelectedIndexChanged += new EventHandler(cmbGrupa_SelectedIndexChanged);

            foreach (string name in Enum.GetNames(typeof(Provenienta)))
            {
                cmbProvenienta.Items.Add(name);
            }

            cmbProvenienta.SelectedIndex = -1;
            cmbProvenienta.SelectedIndexChanged += new EventHandler(cmbProvenienta_SelectedIndexChanged);
           
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAdauga_Click(object sender, EventArgs e)
        {
            if (txtNume.Text == "" || txtPrenume.Text == "" || txtData_nasterii.Text == "" || txtNumar_telefon.Text == "" || txtAdresa_email.Text == "" || cmbGrupa.Text == "" || cmbProvenienta.Text == "")
            {
                if (txtNume.Text == "")
                    lblNume.ForeColor = Color.Red;
                else
                    lblNume.ForeColor = Color.Black;
                if (txtPrenume.Text == "")
                    lblPrenume.ForeColor = Color.Red;
                else
                    lblPrenume.ForeColor = Color.Black;
                if (txtNumar_telefon.Text == "")
                    lblNumar_telefon.ForeColor = Color.Red;
                else
                    lblNumar_telefon.ForeColor = Color.Black;
                if (txtData_nasterii.Text == "")
                    lblData_nasterii.ForeColor = Color.Red;
                else
                    lblData_nasterii.ForeColor = Color.Black;
                if (txtAdresa_email.Text == "")
                    lblAdresa_email.ForeColor = Color.Red;
                else
                    lblAdresa_email.ForeColor = Color.Black;
                if (cmbProvenienta.Text == "")
                    lblProvenienta.ForeColor = Color.Red;
                else
                    lblProvenienta.ForeColor = Color.Black;
                if (cmbGrupa.Text == "")
                    lblGrup.ForeColor = Color.Red;
                else
                    lblGrup.ForeColor = Color.Black;
            }
            else
            {
                Agenda persoana = new Agenda(txtNume.Text, txtPrenume.Text, txtData_nasterii.Text, txtNumar_telefon.Text, txtAdresa_email.Text, textFlagsGrup, textFlagsProvenienta);
                adminPersoane1.AddSPersoana_InFisier(persoana);
                lblGrup.ForeColor = Color.Black;
                lblProvenienta.ForeColor = Color.Black;
                lblAdresa_email.ForeColor = Color.Black;
                lblNume.ForeColor = Color.Black;
                lblPrenume.ForeColor = Color.Black;
                lblData_nasterii.ForeColor = Color.Black;
                lblNumar_telefon.ForeColor = Color.Black;
                lblAdd.Text = "The person has been added";

            }
        }

        private void cmbGrupa_SelectedIndexChanged(object sender, EventArgs e)
        {

            this.textFlagsGrup = (Grup)Enum.Parse(typeof(Grup), (string)cmbGrupa.Items[cmbGrupa.SelectedIndex]);
            Invalidate();

        }
       
        private void cmbProvenienta_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.textFlagsProvenienta = (Provenienta)Enum.Parse(typeof(Provenienta), (string)cmbProvenienta.Items[cmbProvenienta.SelectedIndex]);
            Invalidate();

        }

        private void lblGrup_Click(object sender, EventArgs e)
        {

        }

        private void Control_Insert_Load(object sender, EventArgs e)
        {

        }

        private void lblAdd_Click(object sender, EventArgs e)
        {
            
                
        }
    }
}
