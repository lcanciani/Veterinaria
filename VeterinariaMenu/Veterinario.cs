using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VeterinariaMenu
{
    class Veterinario
    {
        private int matricula;
        private string nombre;
        private string apellido;
        private string calle;
        private int numCalle;
        private string email;
        private int telefono;
        private DateTime fecNacimiento;
        private int sexo;
        private int ciudad;

        public int pMatricula
        {
            set { matricula=value; }
            get { return matricula; }
        }
        public string pNombre
        {
            set { nombre = value; }
            get { return nombre; }
        }
        public string pApellido
        {
            set { apellido = value; }
            get { return apellido; }
        }
        public string pCalle
        {
            set { calle = value; }
            get { return calle; }
        }
        public int pNumCalle
        {
            set { numCalle = value; }
            get { return numCalle; }
        }
        public string pEmail
        {
            set { email = value; }
            get { return email; }
        }
        public int pTelefono
        {
            set { telefono = value; }
            get { return telefono; }
        }
        public DateTime pFecNacimiento
        {
            set { fecNacimiento = value; }
            get { return fecNacimiento; }
        }
        public int pSexo
        {
            set { sexo = value; }
            get { return sexo; }
        }
        public int pCiudad
        {
            set { ciudad = value; }
            get { return ciudad; }
        }
        public override string ToString()
        {
            return nombre + " " + apellido;
        }
    }
}
