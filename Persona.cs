using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    public class Persona
    {
        public string Apellidos { get; set; }
        public string Nombres { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public double Estatura { get; set; }
        public string NroCedula { get; set; }

        public void Despertar()
        {
            
        }

        public void Caminar(string direccion, double distancia, double velocidad)
        { 
        }

        public string Datos()
        {
            var s = $"{NroCedula} - {Apellidos} {Nombres}, nacido el {FechaNacimiento.ToString("dd-MMM-yyyy")}, su estatura es: {Estatura}";
            return s;
        }
    }
}
