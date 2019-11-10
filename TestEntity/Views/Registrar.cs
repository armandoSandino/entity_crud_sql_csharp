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

namespace TestEntity.Views
{
    public partial class Registrar : Form
    {
        int? id;
        persona ta= null;
        public Registrar(int?  id= null )
        {
            InitializeComponent();

            this.id = id;
            if (this.id != null)
                llenar_form();
        }

        private void Registrar_Load(object sender, EventArgs e)
        {

        }

        private  void bt_registrar_Click(object sender, EventArgs e)
        {
           using( var contexto = new personasEntities()  ){

               if( id == null )
               ta = new persona(); // nombre de la tabla en la DB

               ta.nombre = ct_nombre.Text.ToString().Trim();
               ta.correo = ct_correo.Text.ToString().Trim();
               ta.fecha_nacimiento = dtp_fecha.Value;
               if (id == null)
                   contexto.persona.Add(ta);//agregamos 
               else {
                   contexto.Entry(ta).State = System.Data.Entity.EntityState.Modified; 
               }
               contexto.SaveChanges();
               //int i = await salvar(contexto);
               MessageBox.Show("todo salio bien"," Genial ",MessageBoxButtons.OK,MessageBoxIcon.Information);
              this.Close();
           } 
        }
        private void llenar_form() { 
        bt_registrar.Text = "Actualizar";
            lb_titulo.Text= "Actualizar registro";
        using( var contexto = new personasEntities() ){
            ta = contexto.persona.Find( this.id );//obtiene el registro de la tabla persona, linq
            ct_nombre.Text = ta.nombre;
            ct_correo.Text = ta.correo;
            dtp_fecha.Value = ta.fecha_nacimiento;
        }

        }

        private async Task<int> salvar( personasEntities contexto ){
            return await contexto.SaveChangesAsync();
        }
    }
}
