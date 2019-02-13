using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtporniciVezba.BiznisSloj
{
    public abstract class RezistivniElement
    {
        public abstract double Re { get; }

        public static explicit operator double(RezistivniElement r)
        {
            return r.Re;
        }
    }
}
