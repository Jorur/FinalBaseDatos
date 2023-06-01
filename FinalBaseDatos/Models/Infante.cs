using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace FinalBaseDatos
{
    public class Infante
    {
        public string Nombre;
        public string FechaNacimiento;
        public string FechaAlta;
        public string FechaBaja;
        public float TarifaMes;

        public Infante(string nom, string nac, string fechaA,float tarifa)
        {
            Nombre = nom;
            FechaNacimiento = nac;
            FechaAlta = fechaA;
            TarifaMes = tarifa;
        }
    }
}
