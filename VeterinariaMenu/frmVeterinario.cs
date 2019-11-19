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
        private const int tam = 10;
        private Veterinario[] veterinarios = new Veterinario[tam];
        private int c;

        public FrmVeterinario()
        {
            InitializeComponent();
            for (int i = 0; i < tam; i++)
            {
                veterinarios[i] = null;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FrmVeterinario_Load(object sender, EventArgs e)
        {
            cargarCombo(cboCiudades);
            cargarListaVeterinario();
        }
        private void cargarCombo(ComboBox combo)
        {
            DataTable dt = new DataTable();
            string consultaSql = "select * from ciudades";
            dt=conn.guardarTabla(consultaSql);
            combo.DataSource = dt;
            combo.DisplayMember = dt.Columns[1].ColumnName;
            combo.ValueMember = dt.Columns[0].ColumnName;//se graba la pk de la tabla Ciudades
        }

        private void button5_Click(object sender, EventArgs e)
        {
            
        }
        private void convertidor()
        {           
            c = 0;
            string consultaSql = "select * from veterinarios ";
            conn.leerTabla(consultaSql);//carga de tabla veterinarios en un dataReader
            while (conn.pDr.Read())//carga de la clase con los datos del dataReader
            {
                Veterinario v = new Veterinario();
                if (!conn.pDr.IsDBNull(0))
                    v.pMatricula = conn.pDr.GetInt32(0);
                if (!conn.pDr.IsDBNull(1))
                    v.pNombre = conn.pDr.GetString(1);
                if (!conn.pDr.IsDBNull(2))
                    v.pApellido = conn.pDr.GetString(2);
                if (!conn.pDr.IsDBNull(3))
                    v.pCalle = conn.pDr.GetString(3);
                if (!conn.pDr.IsDBNull(4))
                    v.pNumCalle = conn.pDr.GetInt32(4);
                if (!conn.pDr.IsDBNull(5))
                    v.pEmail = conn.pDr.GetString(5);
                if (!conn.pDr.IsDBNull(6))
                    v.pTelefono = conn.pDr.GetInt32(6);
                if (!conn.pDr.IsDBNull(7))
                    v.pFecNacimiento = conn.pDr.GetDateTime(7);
                if (!conn.pDr.IsDBNull(8))
                    v.pSexo = conn.pDr.GetInt32(8);
                if (!conn.pDr.IsDBNull(9))
                    v.pCiudad = conn.pDr.GetInt32(9);
                veterinarios[c] = v;
                c++;
            }
            conn.pDr.Close();
            conn.desconectar();
        }  
        private void cargarListaVeterinario()
        {
            convertidor();
            for (int i = 0; i < c; i++)
            {
                lstVeterinarios.Items.Add(veterinarios[i].ToString());//carga de la lista con los datos de la clase Veterinario
            }
            
        }

        private void btnReporte_Click(object sender, EventArgs e)
        {
            ReporteVeterinarios reporte = new ReporteVeterinarios();
            reporte.ShowDialog();
        }
    }
}
