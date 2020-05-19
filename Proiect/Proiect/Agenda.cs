using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Proiect

{
   public class Agenda
    {
        //constate

        private const int aceeasi_varsta = 0;
        private const int mai_mica_persoana_curenta = 1;
        private const int mai_mare_persoana_curenta = -1;
        private const char SEPARATOR_PRINCIPAL_FISIER = ',';
        private const char SEPARATOR_NUME_PRENUME = ' ';

        //date membre private

        private string nr_telefon;
        private string adresa_email;
        private string data_nastere;

        //proprietati auto-implemented

        public string nume { get; set; }
        public string prenume { get; set; }
        public Provenienta provenienta { get; set; }
        public Grup grup { get; set; }
        public string NumeComplet
        {
            get
            {
                return nume + " " + prenume;
            }
        }
         public string getDataNastere
        {
            get
            {
                return data_nastere;
            }
        }

        //proprietati
        public string Data_curenta()
        {
            return DateTime.Now.ToString("MM/dd/yyyy");
        }
        public string Varsta()
        {
          /* int[] luna = new int[2];
            int[] zi = new int[2];
            int[] luna_curenta = new int[2];
            int[] zi_curenta = new int[2];*/
            int varsta;
            string[] buf = data_nastere.Split('.');
            string data_curenta = Data_curenta();
            string[] buf2 = data_curenta.Split('/');

            int an_curent= Convert.ToInt32(buf2[2]);
            int luna_curenta = Convert.ToInt32(buf2[1]);
            int zi_curenta = Convert.ToInt32(buf2[0]);
            /*  luna_curenta[0] = Convert.ToInt32(buf2[1][0]);
              luna_curenta[1] = Convert.ToInt32(buf2[1][1]);
              zi_curenta[0] = Convert.ToInt32(buf2[0][0]);
              zi_curenta[1] = Convert.ToInt32(buf2[0][1]);*/

            int an = Convert.ToInt32(buf[2]);
            int luna= Convert.ToInt32(buf[1]);
            int zi= Convert.ToInt32(buf[0]);
            /* luna[0]= Convert.ToInt32(buf[1][0]);
             luna[1]= Convert.ToInt32(buf[1][1]);
             zi[0] = Convert.ToInt32(buf[0][0]);
             zi[1] = Convert.ToInt32(buf[0][1]);*/
            if (luna < luna_curenta)
                varsta = an_curent - an;
            else if(luna > luna_curenta)
                varsta = an_curent - an-1;
            else
            {
                if(zi>zi_curenta)
                    varsta = an_curent - an-1;
                else
                    if (zi < zi_curenta)
                    varsta = an_curent - an;
                else
                    varsta = an_curent - an;

            }
            return Convert.ToString(varsta);
        }
        public string Nume_Complet()
        {
            return String.Format("\t{1}{0}{0}{2}",SEPARATOR_NUME_PRENUME,nume,prenume);
        }

        //Constructor implicit

        public Agenda()
        {
            this.nume = string.Empty;
            this.prenume = string.Empty;
            this.adresa_email = string.Empty;
            this.data_nastere = string.Empty;
            this.nr_telefon = string.Empty;
            provenienta = Provenienta.Romania;
            grup = Grup.Prieteni;
           
        }

        //Constructor cu parametri

        public Agenda(string _nume,string _prenume,string _data_nastere,string _nr_telefon, string _adresa_email,Grup _grup,Provenienta _provenienta)
        {
            this.nume = _nume;
            this.prenume = _prenume;
            this.adresa_email = _adresa_email;
            this.data_nastere = _data_nastere;
            this.nr_telefon = _nr_telefon;
            provenienta = _provenienta;
            grup = _grup;


        }

        //Constructor cu parametru de tip string

        public Agenda(string sir)
        {
            string[] buf = sir.Split(',');
            this.nume = buf[0];
            this.prenume = buf[1];
            this.data_nastere = buf[2];
            this.nr_telefon = buf[3];
            this.adresa_email = buf[4];
            grup = (Grup)Enum.Parse(typeof(Grup), buf[5]);
            provenienta = (Provenienta)Enum.Parse(typeof(Provenienta), buf[6]);

        }

       //Compararea varstei a doua persoane din agenda

         public int ComparareVarsta(Agenda b)
         {
            string []sir2 = data_nastere.Split('.');
            string []sir1 = b.data_nastere.Split('.');
            int []s1 = new int[3];
            int []s2 = new int[3];
            for (int i=0;i<3;i++)
            {
                s2[i] = Convert.ToInt32(sir2[i]);
                s1[i] = Convert.ToInt32(sir1[i]);
   
            }
            if (s1[2] == s2[2])
                    if (s1[1] == s2[1])
                           if (s1[0] == s2[0])
                                   return aceeasi_varsta;
                           else if (s1[0] < s2[0])
                                   return mai_mare_persoana_curenta;
                           else
                                   return mai_mica_persoana_curenta;

                    else if (s1[1] < s2[1])
                           return mai_mare_persoana_curenta;
                    else
                           return mai_mica_persoana_curenta;

            else if (s1[2] < s2[2])
                return mai_mare_persoana_curenta; 
            else
                return mai_mica_persoana_curenta;

         }

        //Functia de modificare a unei persoane din Agenda 

         public void CautaSiModifica(string nume_nou, string prenume_nou)
         {
            nume = nume_nou;
            prenume = prenume_nou;
         } 

        //Afisare date in Consola

        public string ConversieLaSir()
        {
           
            return String.Format("{0,-12}{1,8}{2,20}{3,21}{4,29}{5,15}{6,26}", nume,prenume,data_nastere,nr_telefon, adresa_email,grup,provenienta);
        }

        //Afisare date in Fisier

        public string ConversieLaSir_PentruFisier()
        {
            
            string s = string.Format("{1}{0}{2}{0}{3}{0}{4}{0}{5}{0}{6}{0}{7}",
                SEPARATOR_PRINCIPAL_FISIER, nume , prenume , data_nastere,nr_telefon,adresa_email,grup,provenienta);
            return s;
        }

        //Afisare date pentru Forma

        public string ConversieLaSir_PentruForma()
        {

            string s = string.Format("\t{0}\t{1}\t{2}\t{3}\t{4}\t{5}\t{6}\t",
                 nume, prenume, data_nastere, nr_telefon, adresa_email, grup, provenienta);
            return s;
        }
    }
   

}