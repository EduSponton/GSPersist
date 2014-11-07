using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersistGS_VB2012
{

    public class PersistEvent:EventArgs
    {
        private Int64 idRegistroActual;
        private Int64 idRegistroAnterior;

        public PersistEvent(Int64 idRegistroActual, Int64 idRegistroAnterior)
        {
            this.idRegistroActual = idRegistroActual;
            this.idRegistroAnterior = idRegistroAnterior;
        }


        public Int64 IdRegistroAnterior
        {
            get { return idRegistroAnterior; }
            set { idRegistroAnterior = value; }
        }

        public Int64 IdRegistroActual
        {
            get { return idRegistroActual; }
            set { idRegistroActual = value; }
        }
       


    }
}
