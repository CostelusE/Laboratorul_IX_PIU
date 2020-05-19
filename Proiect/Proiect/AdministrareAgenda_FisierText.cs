using System;

using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Proiect
{
    public class AdministrareAgenda_FisierText : IStocareData
    {
        //date membrea ale clasei

        private const int PAS_ALOCARE = 20;
        string NumeFisier { get; set; }

        //constructor cu parametru de tip string

        public AdministrareAgenda_FisierText(string numeFisier)
        {
            this.NumeFisier = numeFisier;
            Stream sFisierText = File.Open(numeFisier, FileMode.OpenOrCreate);
            sFisierText.Close();
        }

        //implementare functii din IStocareData

        public void AddSPersoana_InFisier(Agenda persoana)
        {
            try
            {
                //instructiunea 'using' va apela la final swFisierText.Close();
                //al doilea parametru setat la 'true' al constructorului StreamWriter indica modul 'append' de deschidere al fisierului
                using (StreamWriter swFisierText = new StreamWriter(NumeFisier, true))
                {
                    swFisierText.WriteLine(persoana.ConversieLaSir_PentruFisier());
                }
            }

            catch (IOException eIO)
            {
                throw new Exception("Eroare la deschiderea fisierului. Mesaj: " + eIO.Message);
            }

            catch (Exception eGen)
            {
                throw new Exception("Eroare generica. Mesaj: " + eGen.Message);
            }
        }


        public Agenda[] GetPersoane(out int nrPersoane)
        {

            Agenda[] persoane = new Agenda[PAS_ALOCARE];

            try
            {
                // instructiunea 'using' va apela sr.Close()
                using (StreamReader sr = new StreamReader(NumeFisier))
                {
                    string line;
                    nrPersoane = 0;

                    //citeste cate o linie si creaza un obiect de tip Agenda pe baza datelor din linia citita
                    while ((line = sr.ReadLine()) != null)
                    {
                        persoane[nrPersoane++] = new Agenda(line);
                        if (nrPersoane == PAS_ALOCARE)
                        {
                            Array.Resize(ref persoane, nrPersoane + PAS_ALOCARE);
                        }
                    }
                    sr.ReadLine();

                }
            }

            catch (IOException eIO)
            {
                throw new Exception("Eroare la deschiderea fisierului. Mesaj: " + eIO.Message);
            }

            catch (Exception eGen)
            {
                throw new Exception("Eroare generica. Mesaj: " + eGen.Message);
            }

            return persoane;
        }

        public void ModificareDateFisier(Agenda[] persoane, int nrPersoane)
        {

            using (StreamWriter newFisierText = new StreamWriter(NumeFisier))
                for (int j = 0; j < nrPersoane; j++)
                    newFisierText.WriteLine(persoane[j].ConversieLaSir_PentruFisier());
        }

        public ArrayList GetPersoane()
        {
            ArrayList persoane = new ArrayList();
            try
            {
                // instructiunea 'using' va apela sr.Close()
                using (StreamReader sr = new StreamReader(NumeFisier))
                {
                    string line;
                    //citeste cate o linie din fisier si
                    //creaza un obiect de tip Student pe baza datelor din linia citita
                    while ((line = sr.ReadLine()) != null)
                    {
                        Agenda s = new Agenda(line);
                        persoane.Add(s);
                    }
                }

            }
            catch (IOException eIO)
            {
                throw new Exception("Eroare la deschiderea fisierului. Mesaj: " + eIO.Message);
            }

            catch (Exception eGen)
            {
                throw new Exception("Eroare generica. Mesaj: " + eGen.Message);
            }

            return persoane;
        }

        public Agenda GetPersoana(string Nume, string Prenume)
        {
            try
            {
                // instructiunea 'using' va apela sr.Close()
                using (StreamReader sr = new StreamReader(NumeFisier))
                {
                    string line;

                    //citeste cate o linie si creaza un obiect de tip Student pe baza datelor din linia citita
                    while ((line = sr.ReadLine()) != null)
                    {
                       Agenda persoana = new Agenda(line);
                        if (persoana.nume.Equals(Nume) && persoana.prenume.Equals(Prenume))
                            return persoana;
                    }
                }
            }
            catch (IOException eIO)
            {
                throw new Exception("Eroare la deschiderea fisierului. Mesaj: " + eIO.Message);
            }
            catch (Exception eGen)
            {
                throw new Exception("Eroare generica. Mesaj: " + eGen.Message);
            }
            return null;
        }

        public bool UpdateStudent(Agenda persoanaActualizata)
        {
            ArrayList persoane = GetPersoane();
            bool actualizareCuSucces = false;
            try
            {
                //instructiunea 'using' va apela la final swFisierText.Close();
                //al doilea parametru setat la 'false' al constructorului StreamWriter indica modul 'overwrite' de deschidere al fisierului
                using (StreamWriter swFisierText = new StreamWriter(NumeFisier, false))
                {
                    foreach (Agenda pers in persoane)
                    {
                        //informatiile despre studentul actualizat vor fi preluate din parametrul "studentActualizat"
                        if (pers.getDataNastere != persoanaActualizata.getDataNastere)
                        {
                            swFisierText.WriteLine(pers.ConversieLaSir_PentruFisier());
                        }
                        else
                        {
                            swFisierText.WriteLine(persoanaActualizata.ConversieLaSir_PentruFisier());
                        }
                    }
                    actualizareCuSucces = true;
                }
            }
            catch (IOException eIO)
            {
                throw new Exception("Eroare la deschiderea fisierului. Mesaj: " + eIO.Message);
            }
            catch (Exception eGen)
            {
                throw new Exception("Eroare generica. Mesaj: " + eGen.Message);
            }

            return actualizareCuSucces;
        }

        public Agenda GetNume_Complet(int NumeComplet)
        {
            int nr = 0;
            try
            {
                // instructiunea 'using' va apela sr.Close()
                using (StreamReader sr = new StreamReader(NumeFisier))
                {
                    string line;

                    //citeste cate o linie si creaza un obiect de tip Student pe baza datelor din linia citita
                    while ((line = sr.ReadLine()) != null)
                    {
                      
                        Agenda persoana = new Agenda(line);
                        if (nr==NumeComplet)
                            return persoana;
                        else
                            nr++;
                    }
                }
            }
            catch (IOException eIO)
            {
                throw new Exception("Eroare la deschiderea fisierului. Mesaj: " + eIO.Message);
            }
            catch (Exception eGen)
            {
                throw new Exception("Eroare generica. Mesaj: " + eGen.Message);
            }
            return null;
        }

    }
}  
