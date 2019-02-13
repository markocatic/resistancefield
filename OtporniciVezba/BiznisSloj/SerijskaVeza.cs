using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtporniciVezba.BiznisSloj
{
    public class SerijskaVeza : RezistivnaMreza
    {
        public override double Re
        {
            get
            {
                if (this.BrojElemenata == 0)
                    return 0;

                double tmp = this.lista.Select(x => x.Re).Sum();
                return tmp;
            }
        }
    }
}
