using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRC
{
    public partial class Form1 : Form
    {
        public string Zprava;
        public string PrijataZpravaString;
        public int DelkaGenPolynomu;
        public int DelkaZpravy;
        public bool[] ZpravaBin;

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

        private void button2_Click(object sender, EventArgs e) //decode button
        {
            PrijataZpravaString = NacteniZpravyPrijate();
            string GenPolynomOdeslanyString = NacteniGenPolynomu();
            bool[] GenPolynomOdeslany = NacteniDoPolePrijatouZpravu(GenPolynomOdeslanyString);
            bool[] PrijataZpravaBin = NacteniDoPolePrijatouZpravu(PrijataZpravaString);
            bool PrenosJeSpravny = JePrenosSpravny(PrijataZpravaString, GenPolynomOdeslany);
            if (PrenosJeSpravny)
            {
                PrenosChybny.Text = ("Přenos je bez chyby");
                string[] PrijatyPolynom = PrepisPolynom(PrijataZpravaBin);
                string PrijatyPolynomString = String.Concat(PrijatyPolynom);
                OdeslanaZpravaPol.Text = PrijatyPolynomString;
            }
                
            else
            {
                PrenosChybny.Text = ("Přenos je s chybou");
                string[] PrijatyPolynom = PrepisPolynom(PrijataZpravaBin);
                string PrijatyPolynomString = String.Concat(PrijatyPolynom);
                OdeslanaZpravaPol.Text = PrijatyPolynomString;
                
                bool[] Chyby = HledaniChyby(PrijataZpravaString, GenPolynomOdeslany);
                bool[] OpravenaZpravaBin = OpravaChyby(PrijataZpravaString, Chyby);

                int[] OpravenaZprava = PrepisBin(OpravenaZpravaBin);

                string OpravenaZpavaString = VypisOdeslaneZpravy(OpravenaZprava);
                string[] OpravenyPolynom = PrepisPolynom(OpravenaZpravaBin);
                string OpravenyPolynomString = String.Concat(OpravenyPolynom);
                string PoziceChyby = "";
                for (int i = 0; i < Chyby.Length; i++)
                {
                    if (Chyby[i])
                    {
                        PoziceChyby = ("x^" + (Chyby.Length - i - 1));
                    }
                }

                OprZpravaBin.Text = OpravenaZpavaString;
                OprZpravaPol.Text = OpravenyPolynomString;
                ChybaPozice.Text = PoziceChyby;
                
             
            }
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void EncodeButton_Click(object sender, EventArgs e) //encode button 
        {
            Zprava = NacteniZpravy();
            int r = NactiPocetZabezpecujicichZnaku();
            DelkaGenPolynomu = r + 1;
            DelkaZpravy = Zprava.Length;

            if(DelkaGenPolynomu == 1)
            {
                Console.Text = "Zadání počtu zabezpečujících znaků je chybný";
            }
            else if (Zprava == "chyba")
            {
                Console.Text = "Zadání zprávy je chybné";
            }
            else
            {
                Console.Text = " ";
            ZpravaBin = NacteniDoPoleARozsireni(Zprava, DelkaGenPolynomu);
            bool[][] MoznostiGenPolynom = VypocetGenPolnomu(DelkaGenPolynomu,DelkaZpravy);
            
                for (int i = 0; i < MoznostiGenPolynom.Length; i++)
                {
                    string a = VypisOdeslaneZpravy(PrepisBin(MoznostiGenPolynom[i]));
                    KodovanaZpravaVypis.Items.Add(a);
                }
            }
        }

        private string NacteniZpravy()
        {
            string Zprava = ZpravaBox.Text;
            string Chyba = "chyba";
            int Delka = Zprava.Length;
            bool e = false;

            if (Delka == 0)
            {
                return Chyba;
            }

            for (int i = 0; i < Delka; i++)
            {
                if (Zprava[i].ToString() == "0" || Zprava[i].ToString() == "1")
                {
                    e = true;
                }
                else
                {
                    e = false;
                    break;
                }
            }

            if (e)
            {
                return Zprava;
            }
            return Chyba;
        }//načte zprávu, kterou chceme zakódovat z text boxu

        private string NacteniZpravyPrijate()
        {
            string Zprava = PrijataZpravaBox.Text;
            string Chyba = "chyba";
            int Delka = Zprava.Length;
            bool e = false;

            if (Delka == 0)
            {
                return Chyba;
            }

            for (int i = 0; i < Delka; i++)
            {
                if (Zprava[i].ToString() == "0" || Zprava[i].ToString() == "1")
                {
                    e = true;
                }
                else
                {
                    e = false;
                    break;
                }
            }

            if (e)
            {
                return Zprava;
            }
            return Chyba;
        } //načte zprávu z text boxu, kterou jsme přijali

        private string NacteniGenPolynomu()
        {
            string Zprava = GenPolynomBox.Text;
            string Chyba = "chyba";
            int Delka = Zprava.Length;
            bool e = false;

            if (Delka == 0)
            {
                return Chyba;
            }

            for (int i = 0; i < Delka; i++)
            {
                if (Zprava[i].ToString() == "0" || Zprava[i].ToString() == "1")
                {
                    e = true;
                }
                else
                {
                    e = false;
                    break;
                }
            }

            if (e)
            {
                return Zprava;
            }
            return Chyba;
        }//načte gen polynom z text boxu

        public int NactiPocetZabezpecujicichZnaku()
        {
            int r;
            int n = -1;
            if (int.TryParse(rBox.Text, out r))
            {
                return r;
            }
            else
            {
                return n;
            }

        }//načte kolika znaky se zabezprčí zpráva, z text boxu

        public bool[][] VypocetGenPolnomu(int DelkaGenPolynomu, int DelkaZpravy)
        {
            
            bool[][] MoznyGenPolynom = new bool[((int)Math.Pow(2, DelkaGenPolynomu))][];

            bool Pridat = false;
            int Pocitadlo = 0;

            for (int i = 0; i < Math.Pow(2, DelkaGenPolynomu); i++)
            {
                string bin = Convert.ToString(i, 2);
                while (bin.Length < DelkaGenPolynomu)
                {
                    bin = "0" + bin;
                }

                bool[] Moznost = new bool[DelkaGenPolynomu];
                for (int j = 0; j < DelkaGenPolynomu; j++)
                {
                    if (bin[j].ToString() == "1")
                    {
                        Moznost[j] = true;
                    }
                    else
                    {
                        Moznost[j] = false;
                    }
                }

                if (Moznost[0] == false)
                {
                    continue;
                }

                bool[] znPolynom = new bool[DelkaGenPolynomu + DelkaZpravy];
                znPolynom[0] = true;
                znPolynom[DelkaGenPolynomu + DelkaZpravy - 1] = true;

                bool[] Zbytek = Deleni(znPolynom, Moznost);

                for (int k = 0; k < Zbytek.Length; k++)
                {
                    if (Zbytek[k] == false)
                    {
                        Pridat = true;
                    }
                    else
                    {
                        Pridat = false;
                        break;
                    }
                }

                if (Pridat)
                {
                    for (int l = 0; l < Zbytek.Length; l++)
                    {
                        MoznyGenPolynom[Pocitadlo] = Moznost;
                    }
                    Pocitadlo++;
                }
            }

            bool[][] GenPolynom = new bool[Pocitadlo][];
            for (int i = 0; i < Pocitadlo; i++)
            {
                GenPolynom[i] = MoznyGenPolynom[i];
            }
            return GenPolynom;
        }//vygeneruje možně gen polynomy

        public bool[] NacteniDoPoleARozsireni(string Polynom, int DelkaGenerujicihoPolynomu)
        {
            int DelkaZpravy = Polynom.Length;
            bool[] BinPolynom = new bool[DelkaZpravy + DelkaGenerujicihoPolynomu - 1];

            for (int i = 0; i < (DelkaZpravy); i++)
            {
                if ((int)Char.GetNumericValue(Polynom[i]) == 1)
                {
                    BinPolynom[i] = true;
                }
                else if ((int)Char.GetNumericValue(Polynom[i]) == 0)
                {
                    BinPolynom[i] = false;
                }
            }
            return BinPolynom;
        }//uloží zprávu do pole a rozšíří ji o daný počet nul

        public bool[] NacteniDoPolePrijatouZpravu(string Polynom)
        {
            int DelkaZpravy = Polynom.Length;
            bool[] BinPolynom = new bool[DelkaZpravy];

            for (int i = 0; i < (DelkaZpravy); i++)
            {
                if ((int)Char.GetNumericValue(Polynom[i]) == 1)
                {
                    BinPolynom[i] = true;
                }
                else if ((int)Char.GetNumericValue(Polynom[i]) == 0)
                {
                    BinPolynom[i] = false;
                }
            }
            return BinPolynom;
        } //Načte zprávu do pole

        public bool[] Deleni(bool[] Delenec, bool[] GenPolynom)
        {
            int DelkaZpravy = Delenec.Length;
            int DelkaGenerujicihoPolynomu = GenPolynom.Length;

            bool[] Zbytek = new bool[DelkaGenerujicihoPolynomu - 1];
            bool[] Rozdil = new bool[DelkaZpravy];
            bool[] Delitel = new bool[DelkaZpravy];

            for (int i = 0; i <= DelkaZpravy - DelkaGenerujicihoPolynomu; i++)
            {
                for (int l = 0; l < Delitel.Length; l++)
                {
                    Delitel[l] = false;
                }

                for (int j = 0; j < DelkaGenerujicihoPolynomu; j++)
                {
                    Delitel[j + i] = GenPolynom[j];
                }

                if (Delenec[i] != false)
                {
                    for (int k = 0; k < DelkaZpravy; k++)
                    {
                        Delenec[k] = Delenec[k] != Delitel[k];
                    }
                }
            }
            for (int i = 0; i < DelkaGenerujicihoPolynomu - 1; i++)
            {
                Zbytek[i] = Delenec[DelkaZpravy - DelkaGenerujicihoPolynomu + 1 + i];
            }
            return Zbytek;
        }//Dělení polynomů pomocí XOR

        public bool[] OdeslanaZpravaBin(string Zprava, bool[] Zbytek, int DelkaGenPolynomu)
        {
            
            bool[] OdeslanaZpravaBin = NacteniDoPoleARozsireni(Zprava, DelkaGenPolynomu);
            int Delka = Zprava.Length;
            for (int i = 0; i < (DelkaGenPolynomu - 2); i++)
            {
                OdeslanaZpravaBin[i + Delka] = Zbytek[i];
            }
            return OdeslanaZpravaBin;
        }//Vygeneruje zprávu kterou odesíláme

        public int[] PrepisBin(bool[] OdeslanaZpravaBin)
        {
            int Delka = OdeslanaZpravaBin.Length;
            int[] OdeslanaZprava = new int[Delka];

            for (int i = 0; i < (Delka); i++)
            {
                if (OdeslanaZpravaBin[i] == true)
                {
                    OdeslanaZprava[i] = 1;
                }

                if (OdeslanaZpravaBin[i] == false)
                {
                    OdeslanaZprava[i] = 0;
                }
            }
            return OdeslanaZprava;
        }//přvede typ bool[] do int[]

        public string VypisOdeslaneZpravy(int[] OdeslanaZprava)
        {
            string PrepisZpravy="";
            for (int i = 0; i < OdeslanaZprava.Length; i++)
            {
                PrepisZpravy += OdeslanaZprava[i].ToString();
            }
            return PrepisZpravy;
        }//převede typ int[] do datového typu string

        public string[] PrepisPolynom(bool[] OdeslanaZpravaBin)
        {
            int Delka = OdeslanaZpravaBin.Length;
            string[] OdeslanyPolynom = new string[Delka];
            for (int i = 0; i < Delka; i++)
            {
                if (OdeslanaZpravaBin[i] == true)
                {
                    OdeslanyPolynom[i] = "z^" + (Delka - 1 - i) +" + ";
                }
            }
            return OdeslanyPolynom;
        }//vypíše zprávu ve formě polynomu

        public bool JePrenosSpravny(string PrijataZprava, bool[] GenPolynom)
        {
            
            bool[] PrijataZpravaBin = NacteniDoPolePrijatouZpravu(PrijataZprava);
            bool[] Zbytek = Deleni(PrijataZpravaBin, GenPolynom);
            int Delka = Zbytek.Length;
            bool PrenosJeSpravny = false;

            for (int i = 0; i < Delka; i++)
            {
                if (Zbytek[i] == false)
                {
                    PrenosJeSpravny = true;
                }
                else
                {
                    PrenosJeSpravny = false;
                    break;
                }
            }
            return PrenosJeSpravny;
        }// určí zda přenos proběhl správne 

        public bool[] HledaniChyby(string PrijataZpravy, bool[] GenPolynom)
        {
            

            bool[] PrijataZpravaBin = NacteniDoPolePrijatouZpravu(PrijataZpravy);
            int Delka = PrijataZpravaBin.Length;
            bool[] Chyby = new bool[Delka];
            bool Porovnani = false;

            bool[] ZbytekPorovnani = Deleni(PrijataZpravaBin, GenPolynom);

            for (int i = 0; i < Delka; i++)
            {
                bool[] Delenec = new bool[Delka];
                Delenec[i] = true;
                bool[] Zbytek = Deleni(Delenec, GenPolynom);

                for (int j = 0; j < Zbytek.Length; j++)
                {
                    if (Zbytek[j] == ZbytekPorovnani[j])
                    {
                        Porovnani = true;
                    }
                    else
                    {
                        Porovnani = false;
                        break;
                    }
                }

                if (Porovnani)
                {
                    Chyby[i] = true;
                    break;
                }
            }
            return Chyby;
        }// Najde chybu v přijaté zprávě

        public bool[] OpravaChyby(string PrijataZprava, bool[] Chyby)
        {
            
            bool[] PrijataZpravaBin = NacteniDoPolePrijatouZpravu(PrijataZprava);
            int Delka = PrijataZpravaBin.Length;
            bool[] OpravenaZprava = PrijataZpravaBin;
            for (int i = 0; i < Delka; i++)
            {
                if (Chyby[i] == true)
                {
                    OpravenaZprava[i] = !OpravenaZprava[i];
                }
            }
            return OpravenaZprava;
        }// opraví chybu ve zprávě 

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e) //tlačítko odeslat 
        {
            StringBuilder stringBuilder = new StringBuilder();
            foreach (var item in KodovanaZpravaVypis.Items)
            {
                stringBuilder.Append(item.ToString());
                stringBuilder.Append(" ");
            }
            bool[] GenerujiciPolynom = NacteniDoPolePrijatouZpravu(stringBuilder.ToString());
            bool[] ZpravaBin = NacteniDoPoleARozsireni(Zprava, DelkaGenPolynomu);

            bool[] Zbytek = Deleni(ZpravaBin, GenerujiciPolynom);
            bool[] OdesZpravaBin = OdeslanaZpravaBin(Zprava, Zbytek, DelkaGenPolynomu);

            int[] OdeslanaZprava = PrepisBin(OdesZpravaBin);
            string[] OdeslanyPolynom = PrepisPolynom(OdesZpravaBin);

            string OdeslanaZpavaString = VypisOdeslaneZpravy(OdeslanaZprava);
            string OdeslanyPolynomString = String.Concat(OdeslanyPolynom);

            ZpravaOdeslanyTextBox.Text = OdeslanaZpavaString;
            OdeslanyPolynomtextBox.Text = OdeslanyPolynomString;
        }

    }
}
