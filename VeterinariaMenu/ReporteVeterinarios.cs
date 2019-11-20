using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VeterinariaMenu
{
    public partial class ReporteVeterinarios : Form
    {
        private const string StringConexion = @"Data Source=TOTHEMOON\SQLEXPRESS;Initial Catalog=Veterinaria;Integrated Security=True";
        AccesoDatos conn = new AccesoDatos(StringConexion);
        public ReporteVeterinarios()
        {
            InitializeComponent();
        }

        private void ReporteVeterinarios_Load(object sender, EventArgs e)
        {
            string consultaSql = "select * from veterinarios ";



            
            this.reportViewer1.RefreshReport();

            
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string consultaSql = "select * from veterinarios ";



            veterinariosBindingSource.DataSource = conn.guardarTabla(consultaSql);
            this.reportViewer1.RefreshReport();
        }
    }
}
