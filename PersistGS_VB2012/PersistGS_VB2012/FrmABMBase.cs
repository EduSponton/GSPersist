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
    public partial class FrmABMBase : Form
    {

        public EventHandler<PersistEvent> onLoad;

        public EventHandler<PersistEvent> beforeNew;
        public EventHandler<PersistEvent> beforeCancelNew;
        public EventHandler<PersistEvent> beforeEdit;
        public EventHandler<PersistEvent> beforeCancelEdit;
        public EventHandler<PersistEvent> beforeSave;
        public EventHandler<PersistEvent> beforeDelete;
        public EventHandler<PersistEvent> beforeRecordChange;

        public EventHandler<PersistEvent> afterNew;
        public EventHandler<PersistEvent> afterCancelNew;
        public EventHandler<PersistEvent> afterEdit;
        public EventHandler<PersistEvent> afterCancelEdit;
        public EventHandler<PersistEvent> afterSave;
        public EventHandler<PersistEvent> afterDelete;
        public EventHandler<PersistEvent> afterRecordChange;

             
        public FrmABMBase()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btNuevo_Click(object sender, EventArgs e)
        {
          


        }

        private void pnCampos_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tableLayoutPanel2_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
