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
        private bool nuevo;
        public FrmVeterinario()
        {
            InitializeComponent();
            for (int i = 0; i < tam; i++)
            {
                veterinarios[i] = null;
            }
            nuevo = false;
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FrmVeterinario_Load(object sender, EventArgs e)
        {
            habilitar(false);
            cargarCombo(cboCiudades);
            cargarListaVeterinario();
        }

        //cargar el combo con los registros de la tabla ciudades
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
            
                limpiarCampos();
            if (!nuevo)
                txtMatricula.Clear();

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
                    v.pSueldo = Convert.ToDouble(conn.pDr.GetDecimal(9));
                if (!conn.pDr.IsDBNull(10))
                    v.pFechaIngreso = conn.pDr.GetDateTime(10);
                if (!conn.pDr.IsDBNull(11))
                {
                    v.pFechaEgreso = conn.pDr.GetDateTime(11);
                    v.pEgreso = false;
                }
                    
                
                if (!conn.pDr.IsDBNull(12))
                    v.pCiudad = conn.pDr.GetInt32(12);
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
        //carga todos los campos segun el veterinario seleccionado
        private void cargarControles(int posicion)
        {
            txtMatricula.Text =Convert.ToString(veterinarios[posicion].pMatricula);
            txtNombre.Text = veterinarios[posicion].pNombre;
            txtApellido.Text = veterinarios[posicion].pApellido;
            txtCalle.Text = veterinarios[posicion].pCalle;
            txtNumeroCalle.Text = veterinarios[posicion].pNumCalle.ToString();
            txtEmail.Text = veterinarios[posicion].pEmail;
            txtNumTelefono.Text = veterinarios[posicion].pTelefono.ToString();
            dtpFechaNacimiento.Value = veterinarios[posicion].pFecNacimiento;
            if (veterinarios[posicion].pSexo == 1)
                rbtMasculino.Checked = true;
            else
                rbtFemenino.Checked = true;
            txtSueldo.Text = veterinarios[posicion].pSueldo.ToString();
            dtpIngreso.Value = veterinarios[posicion].pFechaIngreso;
            //comprueba si el veterinario esta en actividad
            if (veterinarios[posicion].pEgreso)
            {
                chbEnActividad.Checked = true;
                dtpEgreso.Value = DateTime.Today;
            }
            else
            {
                chbEnActividad.Checked = false;
                dtpEgreso.Value = veterinarios[posicion].pFechaEgreso;
            }
                
            cboCiudades.SelectedValue = veterinarios[posicion].pCiudad;

        }
        private void btnReporte_Click(object sender, EventArgs e)
        {
            ReporteVeterinarios reporte = new ReporteVeterinarios();
            reporte.ShowDialog();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            nuevo = true;
            limpiarCampos();           
            habilitar(true);
            btnLimpiar.Enabled = true;
            txtMatricula.Focus();
        }

        private void lblCalle_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            convertidor();
        }

        private void lstVeterinarios_SelectedIndexChanged(object sender, EventArgs e)
        {
            cargarControles(lstVeterinarios.SelectedIndex);
        }
        private void limpiarCampos()
        {
            txtApellido.Clear();
            if(txtMatricula.Enabled)
                txtMatricula.Clear();
            txtCalle.Clear();
            txtNombre.Clear();
            txtNumeroCalle.Clear();
            txtEmail.Clear();
            txtSueldo.Clear();
            txtNumTelefono.Clear();
            cboCiudades.SelectedIndex = -1;
            dtpEgreso.Value = DateTime.Today;
            dtpFechaNacimiento.Value = DateTime.Today;
            dtpIngreso.Value = DateTime.Today;
            rbtFemenino.Checked = false;
            rbtMasculino.Checked = false;
            chbEnActividad.Checked = false;
        }
        private void habilitar(bool h)
        {
            txtApellido.Enabled = h;
            txtCalle.Enabled = h;
            txtEmail.Enabled = h;
            txtMatricula.Enabled = h;
            txtNombre.Enabled = h;
            txtNumeroCalle.Enabled = h;
            txtNumTelefono.Enabled = h;
            txtSueldo.Enabled = h;
            cboCiudades.Enabled = h;
            dtpEgreso.Enabled = h;
            dtpFechaNacimiento.Enabled = h;
            dtpIngreso.Enabled = h;
            rbtFemenino.Enabled = h;
            rbtMasculino.Enabled = h;
            chbEnActividad.Enabled = h;
            btnCargar.Enabled = h;

            btnNuevo.Enabled = !h;
            btnModificar.Enabled = !h;
            btnLimpiar.Enabled = !h;
            btnReporte.Enabled = !h;
            btnSalir.Enabled = !h;
            lstVeterinarios.Enabled = !h;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            habilitar(false);
            if (!txtMatricula.Enabled)
                txtMatricula.Clear();
            limpiarCampos();
        }

        private void btnCargar_Click(object sender, EventArgs e)
        {
            Veterinario v = new Veterinario();
            v.pMatricula = Convert.ToInt32(txtMatricula.Text);
            v.pNombre = txtNombre.Text;
            v.pApellido = txtApellido.Text;
            v.pCalle = txtCalle.Text;
            v.pNumCalle = Convert.ToInt32(txtNumeroCalle.Text);
            v.pEmail = txtEmail.Text;
            v.pTelefono = Convert.ToInt32(txtNumTelefono.Text);
            v.pFecNacimiento = dtpFechaNacimiento.Value;
            if (rbtMasculino.Checked)
                v.pSexo = 1;
            else
                v.pSexo = 2;
            v.pSueldo = Convert.ToDouble(txtSueldo.Text);
            v.pFechaIngreso = dtpIngreso.Value;
            v.pFechaEgreso = dtpEgreso.Value;
            v.pCiudad = Convert.ToInt32(cboCiudades.SelectedValue);
            v.pEgreso = chbEnActividad.Checked;

            if (nuevo)//comprueba que sea un nuevo veterinario
            {
                if (!validarPk(Convert.ToInt32(txtMatricula.Text)))//comprueba que el veterinario no exista en la bd 
                {
                    if (v.pEgreso)//si esta en actividad se inserta un null en fechaEgreso
                    {
                        string consultaSql = "insert into veterinarios values ("+v.pMatricula +", '"+
                                                                                 v.pNombre+"','"+
                                                                                 v.pApellido+"','"+
                                                                                 v.pCalle+"',"+
                                                                                 v.pNumCalle+",'"+
                                                                                 v.pEmail+"',"+
                                                                                 v.pTelefono+",'"+
                                                                                 v.pFecNacimiento+"',"+
                                                                                 v.pSexo+","+
                                                                                 Convert.ToDecimal(v.pSueldo)+",'"+
                                                                                 v.pFechaIngreso+"',"+
                                                                                 "null,"+
                                                                                 v.pCiudad+
                                                                                ")";
                        conn.nonQuery(consultaSql);
                        cargarListaVeterinario();
                    }
                    else//si no esta en activadad se ingresa la fecha de baja
                    {
                        string consultaSql = "insert into veterinarios values (" + v.pMatricula + ", '" +
                                                                                 v.pNombre + "','" +
                                                                                 v.pApellido + "','" +
                                                                                 v.pCalle + "'," +
                                                                                 v.pNumCalle + ",'" +
                                                                                 v.pEmail + "'," +
                                                                                 v.pTelefono + ",'" +
                                                                                 v.pFecNacimiento + "'," +
                                                                                 v.pSexo + "," +
                                                                                 v.pSueldo + ",'" +
                                                                                 v.pFechaIngreso + "','" +
                                                                                 v.pFechaEgreso+"'," +
                                                                                 v.pCiudad +
                                                                                 ")";
                        conn.nonQuery(consultaSql);
                        cargarListaVeterinario();
                    }

                }

            }
            else
            {
                if (v.pEgreso)
                {
                    string consultaSql = "update veterinarios " +
                                           "set matricula= " + v.pMatricula + ", " +
                                            "nombre='" + v.pNombre + "'," +
                                            "Apellido='" + v.pApellido + "'," +
                                            "calle='" + v.pCalle + "'," +
                                            "numCalle=" + v.pNumCalle + "," +
                                            "email='" + v.pEmail + "'," +
                                            "telefono=" + v.pTelefono + ",'" +
                                            "fec_nac='" + v.pFecNacimiento + "'," +
                                            "sexo= " + v.pSexo + "," +
                                            "sueldoNeto= " + v.pSueldo + "," +
                                            "fechaIngreso= '" + v.pFechaIngreso + "'," +
                                            "null," +
                                            "idCiudad= " + v.pCiudad +
                                            "where matricula= " + v.pMatricula;
                                           
                                            
                    conn.nonQuery(consultaSql);
                    cargarListaVeterinario();
                }
                else
                {
                    string consultaSql = "update veterinarios " +
                                           "set matricula= " + v.pMatricula + ", " +
                                            "nombre='" + v.pNombre + "'," +
                                            "Apellido='" + v.pApellido + "'," +
                                            "calle='" + v.pCalle + "'," +
                                            "numCalle=" + v.pNumCalle + "," +
                                            "email='" + v.pEmail + "'," +
                                            "telefono=" + v.pTelefono + ",'" +
                                            "fec_nac='" + v.pFecNacimiento + "'," +
                                            "sexo= " + v.pSexo + "," +
                                            "sueldoNeto= " + v.pSueldo + "," +
                                            "fechaIngreso= '" + v.pFechaIngreso + "'," +
                                            "fechaEgreso='" +v.pFechaEgreso+"',"+
                                            "idCiudad= " + v.pCiudad +
                                            "where matricula= " + v.pMatricula;
                    conn.nonQuery(consultaSql);
                    cargarListaVeterinario();
                }
                
            }
            

        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            nuevo = true;            
            habilitar(true);
            btnLimpiar.Enabled = true;
            txtMatricula.Enabled = false;
            txtApellido.Focus();
            

        }

        private bool validar()
        {
            if (txtMatricula.Text == "")
            {
                MessageBox.Show("La caja de texto Matricula no puede estar vacía");
                return false;
            }
            int validarstring;

            if(!int.TryParse(txtMatricula.Text, out validarstring))
            {
                MessageBox.Show("La caja de texto Matricula solo puede contener números");
                return false;
            }

            if(Convert.ToInt32(txtMatricula.Text)<0)
            {
                MessageBox.Show("Esta ingresando un numero negativo");
                return false;
            }
                    
            return true;
        }
        public bool validarPk(int pk)
        {
            for (int i = 0; i < c; i++)
            {
                if (veterinarios[i].pMatricula == pk)
                    return true;
            }
            return false;
        }

    }
}
