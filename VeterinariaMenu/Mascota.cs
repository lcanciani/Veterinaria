using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VeterinariaMenu
{
    class Mascota
    {
        private int idMascota;
        private string nombre;
        private double peso;
        private DateTime fechaNacimiento;
        private int raza;
        private int tipoMascota;
        private int propietario;

        public int pIdMascota
        {
            set { idMascota = value; }
            get { return idMascota; }
        }
        public string pNombre
        {
            set { nombre = value; }
            get { return nombre; }
        }
        public double pPeso
        {
            set { peso = value; }
            get { return peso; }
        }
        public DateTime pFecNac
        {
            set { fechaNacimiento = value; }
            get { return fechaNacimiento; }
        }
        public int pRaza
        {
            set { raza = value; }
            get { return raza; }
        }
        public int pTipoMascota
        {
            set { tipoMascota = value; }
            get { return tipoMascota; }
        }
        public int pPropietario
        {
            set { propietario = value; }
            get { return propietario; }
        }
        public override string ToString()
        {
            return idMascota + "-" + nombre;
        }
    }
}
