using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persist_Forms
{

    public class PersistEvent:EventArgs
    {
        private Int64 id;

        public Int64 Id
        {
            get { return id; }
            set { id = value; }
        }
        public PersistEvent(Int64 id) {
            this.id = id;
        }
    }
}
