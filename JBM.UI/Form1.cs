using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using JBM.BL;

using JBM.DAL;


namespace JBM.UI
{
    public partial class lbl_id : Form
    {
        public lbl_id()
        {
            InitializeComponent();
        }

        Data d = new Data();
        Address ad = new Address();

        public static string idPersona;


        private void Btn_Agregar_Click(object sender, EventArgs e)
        {
            using (QuizEntities context = new QuizEntities())
            {
                var v1 = new Datos();
                v1.nombre = txt_nombre.Text;
                v1.apellido = txt_apellido.Text;
                v1.telefono = txt_telefono.Text;
                d.Add(v1);

            }
        }

        private void Btn_agregaDirec_Click(object sender, EventArgs e)
        {
            using (QuizEntities context = new QuizEntities())
            {
                var v1 = new Datos();
                v1.nombre = txt_nombre.Text;
                v1.apellido = txt_apellido.Text;
                v1.telefono = txt_telefono.Text;
                d.Add(v1);

            }

        }

        private void DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {

                idPersona = dataGridPrincipal.Rows[e.RowIndex].Cells["IDpersona"].Value.ToString();
                txt_idpersona.Text = idPersona;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }
}


