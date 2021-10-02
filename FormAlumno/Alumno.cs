using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormAlumno
{
    class Alumno
    {
        private string nom { get; set; }
        private string ap { get; set; }
        private string carr { get; set; }
        private int dni { get; set; }
        private int leg { get; set; }
        private int insc { get; set; }

        public string Nom
        {
            get { return this.nom; }
            set { this.nom = value; }
        }
        public string Ap
        {
            get { return this.ap; }
            set { this.ap = value; }
        }
        public string Carr
        {
            get { return this.carr; }
            set { this.carr = value; }
        }
        public int Dni
        {
            get { return this.dni; }
            set { this.dni = value; }
        }

        public int Leg
        {
            get { return this.leg; }
            set { this.leg = value; }
        }
        public int Insc
        {
            get { return this.insc; }
            set { this.insc = value; }

        }

        public Alumno(string Nombre, string Apellido, string Carrera, int Documento, int Legajo, int Inscripcion)
        {
            nom = Nombre;
            ap = Apellido;
            carr = Carrera;
            dni = Documento;
            leg = Legajo;
            insc = Inscripcion;

        }

    }
}

