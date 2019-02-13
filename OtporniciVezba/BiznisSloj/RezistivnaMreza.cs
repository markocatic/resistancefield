using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtporniciVezba.BiznisSloj
{
    public abstract class RezistivnaMreza : RezistivniElement
    {
        protected List<RezistivniElement> lista = new List<RezistivniElement>();

        public int BrojElemenata
        {
            get { return this.lista.Count; }
        }

        public void dodaj(RezistivniElement obj)
        {
            if(obj!=null)
                this.lista.Add(obj);
        }

        public RezistivniElement getRezistivniElement(int indeks)
        {
            if((indeks<0) || (indeks>=this.lista.Count))
                throw new IndexOutOfRangeException();
            return this.lista.ElementAt(indeks);
        }
    }
}
