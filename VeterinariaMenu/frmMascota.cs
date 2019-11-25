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
    public partial class FrmMascota : Form
    {
        private bool nuevo;
        private const int tam = 100;
        Mascota[] mascotas = new Mascota[tam];
        private int c;
        AccesoDatos conn = new AccesoDatos(@"Data Source=TOTHEMOON\SQLEXPRESS;Initial Catalog=Veterinaria;Integrated Security=True");
        public FrmMascota()
        {
            InitializeComponent();
            for (int i = 0; i < tam; i++)
            {
                mascotas[i] = null;
            }
            nuevo = false;
        }

        private void Mascota_Load(object sender, EventArgs e)
        {
            habilitar(false);
            cargarLista();
            cargarCombo(cboTipo,"tipoMascota");
            cargarCombo(cboRaza,"razas");
            cargarCombo(cboPropietario, "propietarios");
            
        }
        private void cargarCombo(ComboBox combo, string nombreTabla)
        {
            DataTable dt = new DataTable();
            string consultaSql = "select * from " + nombreTabla;
            dt = conn.guardarTabla(consultaSql);
            if (nombreTabla == "propietarios")
            {
                combo.DataSource = dt;
                combo.ValueMember = dt.Columns[0].ColumnName;

                combo.DisplayMember = dt.Columns[1].ColumnName;
            }

                combo.DataSource = dt;
            combo.ValueMember = dt.Columns[0].ColumnName;
            combo.DisplayMember = dt.Columns[1].ColumnName;
        }    
        private void convertidor()
        {
            c = 0;
            string consultaSql = "select * from mascotas ";
            conn.leerTabla(consultaSql);//carga de tabla veterinarios en un dataReader
            while (conn.pDr.Read())//carga de la clase con los datos del dataReader
            {
                Mascota m = new Mascota();
                if (!conn.pDr.IsDBNull(0))
                    m.pIdMascota = conn.pDr.GetInt32(0);
                if (!conn.pDr.IsDBNull(2))
                    m.pNombre = conn.pDr.GetString(2);
                if (!conn.pDr.IsDBNull(4))
                    m.pPeso = Convert.ToDouble(conn.pDr.GetDecimal(4));
                if (!conn.pDr.IsDBNull(3))
                    m.pRaza = conn.pDr.GetInt32(3);
                if (!conn.pDr.IsDBNull(5))
                    m.pFecNac = conn.pDr.GetDateTime(5);
                if (!conn.pDr.IsDBNull(1))
                    m.pPropietario = conn.pDr.GetInt32(1);
                if (!conn.pDr.IsDBNull(6))
                    m.pTipoMascota = conn.pDr.GetInt32(6);
                mascotas[c] = m;
                c++;
            }
            conn.pDr.Close();
            conn.desconectar();
        }
        private void cargarLista()
        {
            convertidor();
            
                for (int i = 0; i < c; i++)
                {
                    lstMascotas.Items.Add(mascotas[i].ToString());
                }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            int indice=lstMascotas.FindString(txtBuscar.Text);
            if (indice != -1)
                lstMascotas.SetSelected(indice, true);
            else
                MessageBox.Show("No se encuentra");
            txtBuscar.Clear();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            
        }
        
        private void btnCargar_Click(object sender, EventArgs e)
        {
            if (validarCampos())
            {


                if (validar())
                {


                    Mascota v = new Mascota();
                    v.pIdMascota = Convert.ToInt32(txtIdMascota.Text);
                    v.pNombre = txtNombreMascota.Text;
                    v.pPeso = Convert.ToDouble(txtPeso.Text);
                    v.pFecNac = dtpFechaNacimiento.Value;

                    v.pRaza = Convert.ToInt32(cboRaza.SelectedValue);
                    v.pTipoMascota = Convert.ToInt32(cboTipo.SelectedValue);
                    v.pPropietario = Convert.ToInt32(cboPropietario.SelectedValue);


                    if (nuevo)//comprueba que sea un nuevo veterinario
                    {
                        if (!validarPk(Convert.ToInt32(txtIdMascota.Text)))//comprueba que el veterinario no exista en la bd 
                        {

                            string consultaSql = "insert into mascotas values (" + v.pIdMascota + ", " +
                                                                                     v.pPropietario + ",'" +
                                                                                     v.pNombre + "'," +
                                                                                     v.pRaza + "," +
                                                                                     v.pPeso + ",'" +
                                                                                     v.pFecNac.ToString("yyyy-MM-dd HH:mm:ss.fff") + "'," +
                                                                                     v.pTipoMascota +
                                                                                     ")";
                            conn.nonQuery(consultaSql);
                            lstMascotas.Items.Clear();
                            cargarLista();
                        }
                        else
                            MessageBox.Show("La Mascota que intenta ingresar ya se encuentra  registrada", "CUIDADO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {

                        string consultaSql = "update mascotas " +
                                               "set idMascota= " + v.pIdMascota + ", " +
                                                "nombre='" + v.pNombre + "'," +
                                                "peso=" + v.pPeso + "," +
                                                "fecNac='" + v.pFecNac.ToString("yyyy-MM-dd HH:mm:ss.fff") + "'," +
                                                "idRaza=" + v.pRaza + "," +
                                                "idTipo=" + v.pIdMascota + "," +
                                                "idPropietario=" + v.pPropietario +
                                                "where idMascota= " + v.pIdMascota;
                        conn.nonQuery(consultaSql);
                        lstMascotas.Items.Clear();
                        cargarLista();

                    }

                }
            }
        }
        private bool validar()
        {
            return true;
        }    
        private bool validarPk(int pk)
        {
            for (int i = 0; i < c; i++)
            {
                if (mascotas[i].pIdMascota == pk)
                    return true;
            }
            return false;
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            nuevo = true;
            habilitar(true);
            btnCancelar.Enabled = true;
            txtIdMascota.Focus();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            nuevo = false;
            if (lstMascotas.SelectedIndex == -1)
                MessageBox.Show("Seleccione una mascota");
            else
            {
                habilitar(true);
                txtIdMascota.Enabled = false;
                btnCancelar.Enabled = true;
                txtNombreMascota.Focus();
            }
                
        }
        private void habilitar(bool h)
        {
            txtIdMascota.Enabled = h;
            txtNombreMascota.Enabled = h;
            txtPeso.Enabled = h;
            cboRaza.Enabled = h;
            cboTipo.Enabled = h;
            cboPropietario.Enabled = h;
            btnCargar.Enabled = h;
            dtpFechaNacimiento.Enabled = h;

            btnNuevo.Enabled = !h;
            btnModificar.Enabled = !h;
            btnCancelar.Enabled = !h;
            btnEliminar.Enabled = !h;
            btnReporte.Enabled = !h;
            lstMascotas.Enabled = !h;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Seguro que quiere eliminar?", "ELIMINANDO", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                string consultaSql = "delete mascotas where idMascota=" + mascotas[lstMascotas.SelectedIndex].pIdMascota;
                conn.nonQuery(consultaSql);
                lstMascotas.Items.Clear();
                cargarLista();
            }
        } 
        private void cargarControles(int i)
        {
            txtIdMascota.Text = Convert.ToString(mascotas[i].pIdMascota);
            txtNombreMascota.Text = mascotas[i].pNombre;
            txtPeso.Text = mascotas[i].pPeso.ToString();
            dtpFechaNacimiento.Value = mascotas[i].pFecNac;
            cboRaza.SelectedValue = mascotas[i].pRaza;
            cboTipo.SelectedValue = mascotas[i].pTipoMascota;
            cboPropietario.SelectedValue = mascotas[i].pPropietario;
        }

        private void lstMascotas_SelectedIndexChanged(object sender, EventArgs e)
        {
            cargarControles(lstMascotas.SelectedIndex);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            habilitar(false);
        }
        private bool validarCampos()
        {
            if (txtIdMascota.Text == "")
            {
                MessageBox.Show("Debe ingresar un ID");
                return false;
            }
            int validarInt;
            if(!int.TryParse(txtIdMascota.Text,out validarInt))
            {
                MessageBox.Show("Debe ingresar un identificador valido");
                return false;
            }

            //Nombre mascota
            if (txtNombreMascota.Text == "")
            {
                MessageBox.Show("Debe ingresar un Nombre");
                return false;
            }
            //Peso
            if (txtPeso.Text == "")
            {
                MessageBox.Show("Debe ingresar un Peso");
                return false;
            }
            double validarDouble;
            if (!double.TryParse(txtPeso.Text, out validarDouble))
            {
                MessageBox.Show("Ingrese un peso valido");
                return false;
            }
            //raza
            if (cboRaza.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione una raza");
                return false;
            }
            //Tipo
            if (cboTipo.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione una Tipo");
                return false;
            }
            //propietario
            if (cboPropietario.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione una Propietario");
                return false;
            }
            return true;
        }

        private void btnReporte_Click(object sender, EventArgs e)
        {
            FormReporteMascotas reporteMascotas = new FormReporteMascotas();
            reporteMascotas.ShowDialog();
        }

        private void FrmMascota_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("¿Seguro quiere salir?", "SALIENDO", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                e.Cancel = true;
        }

        private void FrmMascota_FormClosed(object sender, FormClosedEventArgs e)
        {
            
        }
    }
}
