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

        public event EventHandler<PersistEvent> onLoad;

        public event EventHandler<PersistEvent> beforeNew;
        public event EventHandler<PersistEvent> beforeCancelNew;
        public event  EventHandler<PersistEvent> beforeEdit;
        public event EventHandler<PersistEvent> beforeCancelEdit;
        public event EventHandler<PersistEvent> beforeSave;
        public event EventHandler<PersistEvent> beforeDelete;
        public event EventHandler<PersistEvent> beforeRecordChange;

        public event EventHandler<PersistEvent> afterNew;
        public event EventHandler<PersistEvent> afterCancelNew;
        public event EventHandler<PersistEvent> afterEdit;
        public event EventHandler<PersistEvent> afterCancelEdit;
        public event EventHandler<PersistEvent> afterSave;
        public event EventHandler<PersistEvent> afterDelete;
        public event EventHandler<PersistEvent> afterRecordChange;

             
        public FrmABMBase()
        {
            InitializeComponent();
        }

        private void btNuevo_Click(object sender, EventArgs e)
        {
            PersistEvent pe= new PersistEvent(0,0);

            if (this.btNuevo.Text == "Nuevo")
            {
                if (this.beforeNew!=null)
                {
                    this.beforeNew(this, pe);
                }
                //Conectar con persistencia
                if (this.afterNew != null)
                {
                    this.afterNew(this, pe);
                }
                this.btNuevo.Text = "Cancelar Nuevo";
                this.btEditar.Enabled=false;
                this.btEditar.Text="Editar";
                this.btEliminar.Enabled = false;
                this.btGuardar.Enabled=true;
            }
            else if (this.btNuevo.Text == "Cancelar Nuevo")
            {
                if (this.beforeCancelNew!=null)
                {
                    this.beforeCancelNew(this, pe);
                }
                //Conectar con persistencia
                if (this.afterCancelNew != null)
                {
                    this.afterCancelNew(this, pe);
                }
                this.btNuevo.Text = "Nuevo";
                
                this.btEditar.Enabled=false;
                this.btEliminar.Enabled=false;
                this.btGuardar.Enabled=false;
            }
        }

        private void btEditar_Click(object sender, EventArgs e)
        {
            PersistEvent pe = new PersistEvent(0, 0);

            if (this.btEditar.Text=="Editar"){
                if (this.beforeEdit!=null)
                {
                    this.beforeEdit(this, pe);
                }
                //Conectar con persistencia
                if (this.afterEdit != null)
                {
                    this.afterEdit(this, pe);
                }
                this.btEditar.Text = "Cancelar Edición";
                this.btNuevo.Enabled=true;
                this.btEliminar.Enabled=false;
                this.btGuardar.Enabled=true;
            }else if (this.btEditar.Text == "Cancelar Edición")
            {
                if (this.beforeCancelEdit != null)
                {
                    this.beforeCancelEdit(this, pe);
                }
                //Conectar con persistencia
                if (this.afterCancelEdit != null)
                {
                    this.afterCancelEdit(this, pe);
                }
                this.btEditar.Text = "Editar";
                this.btNuevo.Enabled=true;
                //this.btEditar;
                this.btEliminar.Enabled=true;
                this.btGuardar.Enabled=false;
            }
        }

        private void btEliminar_Click(object sender, EventArgs e)
        {
            PersistEvent pe = new PersistEvent(0, 0);

            if (this.beforeDelete != null)
            {
                this.beforeDelete(this, pe);
            }
            //Conectar con persistencia
            if (this.afterDelete!= null)
            {
                this.afterDelete(this, pe);
            }
            this.btNuevo.Enabled=true;
            this.btEditar.Enabled=false;
            this.btEliminar.Enabled=false;
            this.btGuardar.Enabled=false;
        }

        private void btGuardar_Click(object sender, EventArgs e)
        {
            PersistEvent pe = new PersistEvent(0, 0);

            

            if (this.beforeSave != null)
            {
                this.beforeSave(this, pe);
            }

            
            if (validateDataIntegrity()) {
                this.btNuevo.Text = "Nuevo";
                this.btNuevo.Enabled = true;
                this.btEditar.Enabled = true;
                this.btEditar.Text = "Editar";
                this.btEliminar.Enabled = true;
                this.btGuardar.Enabled = false;
                //Conectar con persistencia
                if (this.afterSave != null)
                {
                   

                    this.afterSave(this, pe);
                }
            }
            
        }

        private void dgvRegistros_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Int64 id = 0;
            PersistEvent pe; 
            if (this.dgvRegistros.Rows[e.RowIndex].Cells[0].Value != null) {
                id = Int64.Parse(this.dgvRegistros.Rows[e.RowIndex].Cells[0].Value.ToString());
                pe= new PersistEvent(id,0);
                if (this.beforeRecordChange != null)
                {
                    this.beforeRecordChange(this, pe);
                }
                //Conectar con persistencia
                this.btNuevo.Text = "Nuevo";
                this.btNuevo.Enabled=true;
                this.btEditar.Text = "Editar";
                this.btEditar.Enabled=true;
                this.btEliminar.Enabled=true;
                this.btGuardar.Enabled=false;

                if (this.afterRecordChange!= null)
                {
                    this.afterRecordChange(this, pe);
                }
            }
        }

        private void FrmABMBase_Load(object sender, EventArgs e)
        {
            PersistEvent pe = new PersistEvent(0, 0);
            if (this.onLoad != null)
            {
                this.onLoad(this, pe);
            }
        }

        public virtual Boolean validateDataIntegrity() {
            return true;
        }
        
    }
}
