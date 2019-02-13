using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtporniciVezba.BiznisSloj
{
    public class ParalelnaVeza : RezistivnaMreza
    {
        public override double Re
        {
            get
            {
                if (this.BrojElemenata == 0)
                    return 0;
                double sumaRecVrednosti = this.lista.Select(x => 1 / x.Re).Sum();
                double tmp = 1 / sumaRecVrednosti;
                return tmp;
            }
        }
    }
}
