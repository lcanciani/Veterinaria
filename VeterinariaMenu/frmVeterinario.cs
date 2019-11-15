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
    public partial class FrmVeterinario : Form
    {
        AccesoDatos conn = new AccesoDatos(@"Data Source=TOTHEMOON\SQLEXPRESS;Initial Catalog=Veterinaria;Integrated Security=True");
        private string[] autoCompletar = new string[20];
        DataTable dt = new DataTable();
        public FrmVeterinario()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FrmVeterinario_Load(object sender, EventArgs e)
        {
            cargarCombo(cboCiudades);
            autoCompletarCombo();
        }
        private void cargarCombo(ComboBox combo)
        {
            
            string consultaSql = "select * from ciudades";
            dt=conn.guardarTabla(consultaSql);
            combo.DataSource = dt;
            combo.DisplayMember = dt.Columns[1].ColumnName;
            combo.ValueMember = dt.Columns[0].ColumnName;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            
        }
       

       
        private void autoCompletarCombo()
        {
            for (int i = 0; i < cboCiudades.Items.Count; i++)
            {
                autoCompletar[i] = cboCiudades.Items.ToString();
            }
        }
    }
}
