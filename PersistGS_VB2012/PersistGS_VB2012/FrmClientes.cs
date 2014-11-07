using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PersistGS_VB2012
{
    public partial class FrmClientes : FrmABMBase
    {
        
        public FrmClientes()
        {
            InitializeComponent();
          
        }

        private void FrmClientes_Load(object sender, EventArgs e)
        {

        }
        private void nuevo(object sender, PersistEvent o) {
            MessageBox.Show("Nuevo"+o.IdRegistroActual);
        }
    }
}
