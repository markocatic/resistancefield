using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtporniciVezba.BiznisSloj
{

    public enum EnumVrstaOtpornika
    {
        Ugljenoslojni,
        MetalFilm,
        Folijski,
        Zicani,
        Film
    }
    public class Otpornik : RezistivniElement
    {
        private double r;
        private EnumVrstaOtpornika vrsta;

        public double R
        {
            get { return r; }
            set
            {
                if (value > 0)
                    r = value;
            }
        }

        public EnumVrstaOtpornika Vrsta
        {
            get { return vrsta; }
            set { vrsta = value; }
        }

        public Otpornik(double r, EnumVrstaOtpornika vrsta = EnumVrstaOtpornika.Ugljenoslojni)
        {
            if(r<=0) 
                throw new ArgumentException();
            this.r = r;
            this.vrsta = vrsta;
        }
        public override double Re
        {
            get { return r; }
        }

        public static implicit operator Otpornik(double d)
        {
            return new Otpornik(d);
        }
    }
}
