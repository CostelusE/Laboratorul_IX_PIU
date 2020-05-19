using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proiect
{
    public partial class Forma_Destinatie : Form
    {
        IStocareData adminPersoane = StocareFactory.GetAdministratorStocare();
        public Agenda persoana_curenta;
        public Forma_Destinatie()
        {
            InitializeComponent();
        }
        public Forma_Destinatie(Agenda persoana) : this()
        {
            persoana_curenta = persoana;
           
        }
        private void Forma_Destinatie_Load(object sender, EventArgs e)
        {

        }

        private void buttonFinalizare_Click(object sender, EventArgs e)
        {
            if (Validare() == "adevarat")
            {
                persoana_curenta.provenienta = GetProvenientaSelectata();
                persoana_curenta.grup = GetGrupSelectat();
                adminPersoane.UpdateStudent(persoana_curenta);
                ResetareControale();
                labelProvenienta.ForeColor = Color.Black;
                labelGrup.ForeColor = Color.Black;
                DialogResult = DialogResult.OK;
            }
            else
                if (Validare() == "false")
            {
                labelGrup.ForeColor = Color.Red;
                labelProvenienta.ForeColor = Color.Red;
            }
            else
                    if (Validare() == "grup")
            {
                labelGrup.ForeColor = Color.Red;
                labelProvenienta.ForeColor = Color.Black;
            }
            else
            {
                labelGrup.ForeColor = Color.Black;
                labelProvenienta.ForeColor = Color.Red;

            }
        }
        private Provenienta GetProvenientaSelectata()
        {
            if (rbAnglia.Checked)
                return Provenienta.Anglia;
            if (rbRomania.Checked)
                return Provenienta.Romania;
            if (rbGermania.Checked)
                return Provenienta.Germania;
            if (rbOlanda.Checked)
                return Provenienta.Olanda;
            if (rbItalia.Checked)
                return Provenienta.Italia;
            if (rbSpania.Checked)
                return Provenienta.Spania;
            return Provenienta.Anglia;
        }

        private Grup GetGrupSelectat()
        {
            if (rbScoala.Checked)
                return Grup.Scoala;
            if (rbServici.Checked)
                return Grup.Serviciu;
            if (rbPrieteni.Checked)
                return Grup.Prieteni;
            if (rbFamilie.Checked)
                return Grup.Familie;
            return Grup.Familie;
        }
        private string Validare()
        {

            int provenientaSelecatata = 0;
            foreach (var control in gbProvenienta.Controls)
            {
                RadioButton rdb = null;
                try
                {
                    rdb = (RadioButton)control;
                }
                catch { }

                if (rdb != null && rdb.Checked == true)
                    provenientaSelecatata = 1;
            }
            int grupSelecatat = 0;
            foreach (var control1 in gbGrup.Controls)
            {
                RadioButton rdb1 = null;
                try
                {
                    rdb1 = (RadioButton)control1;
                }
                catch { }

                if (rdb1 != null && rdb1.Checked == true)
                    grupSelecatat = 1;
            }
            if (grupSelecatat == 1 && provenientaSelecatata == 1)
                return "adevarat";
            else
                if (grupSelecatat == 0 && provenientaSelecatata == 1)
                return "grup";
            else
                if (grupSelecatat == 1 && provenientaSelecatata == 0)
                return "provenienta";
            else
                return "fals";


        }
        private void ResetareControale()
        {
            rbAnglia.Checked = false;
            rbRomania.Checked = false;
            rbSpania.Checked = false;
            rbGermania.Checked = false;
            rbItalia.Checked = false;
            rbOlanda.Checked = false;
            rbPrieteni.Checked = false;
            rbScoala.Checked = false;
            rbServici.Checked = false;
            rbFamilie.Checked = false;
  

        }
    }
}
