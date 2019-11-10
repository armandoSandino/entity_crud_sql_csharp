using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using TestEntity.Models;
using TestEntity.Views;

namespace TestEntity
{
    public partial class Principal : Form
    {
        bool si;
        public Principal()
        {
            InitializeComponent();
            si= false;
        }
        private void Principal_Load(object sender, EventArgs e)
        {
            update_rejilla();
        }

        private void bt_agregar_Click(object sender, EventArgs e)
        {
            Registrar re = new Registrar();
            re.ShowDialog();
            update_rejilla();

        }
        
        private void bt_editar_Click(object sender, EventArgs e)
        {
            if (!si)
            {
                MessageBox.Show("Seleccione un registro a editar.");
                si = false;
                return;
            }
            int? id = getID();
            if (id != null) {
                Registrar re = new Registrar( id );
                re.ShowDialog();
                update_rejilla(); si = false;
            }
        }
        private void bt_delete_Click(object sender, EventArgs e)
        {
            if (!si) {
                MessageBox.Show("Seleccione un registro a borrar."); 
                si = false;
                return;
            }
            int? id = getID();
            if (id != null)
            {
                using(var con = new personasEntities() ){
                    persona per = con.persona.Find( id );
                    con.persona.Remove( per );
                    con.SaveChanges();
                }
                update_rejilla(); si = false;
            }
        }
        private void update_rejilla()
        {
            using (var db = new personasEntities())
            {
                var lt = from per in db.persona
                         select per;
                dgv_show_datos.DataSource = lt.ToList();
            }
        }

        //ontenemos el ID del registro seleccionado
        private int? getID()
        {
            try
            {
                return Int32.Parse(dgv_show_datos.Rows[dgv_show_datos.CurrentRow.Index].Cells[0].Value.ToString());
            }
            catch
            {
                return null;
            }
        }

    
        private void dgv_show_datos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            si = true;
        }

       

    }
}
