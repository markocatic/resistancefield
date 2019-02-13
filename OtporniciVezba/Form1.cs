using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OtporniciVezba.BiznisSloj;

namespace OtporniciVezba
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.Text = "Otornici: primer za kompozit";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SerijskaVeza serijskaR3R4 = new SerijskaVeza();
            serijskaR3R4.dodaj(new Otpornik(4));
            serijskaR3R4.dodaj(new Otpornik(2));
            ParalelnaVeza paralelnaR2_serijskaR3R4 = new ParalelnaVeza();
            paralelnaR2_serijskaR3R4.dodaj(new Otpornik(6));
            paralelnaR2_serijskaR3R4.dodaj(serijskaR3R4);
            SerijskaVeza serijslaR1_paralelnaOstaliElementi = new SerijskaVeza();
            serijslaR1_paralelnaOstaliElementi.dodaj(new Otpornik(5));
            serijslaR1_paralelnaOstaliElementi.dodaj(paralelnaR2_serijskaR3R4);
            double reUkupno = serijslaR1_paralelnaOstaliElementi.Re;
            this.textBoxRe.Text = reUkupno.ToString();
        }
    }
}
