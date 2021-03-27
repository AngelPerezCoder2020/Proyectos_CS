using System;

namespace Clasess{
    public class Estudiantes{
        public string nombre;
        public int edad;
        public string carnet;
        public Boolean solv;
        public Materia curso;
        public Estudiantes(string nombre, int edad, string carnet, Boolean solv, Materia curso){
            this.nombre=nombre;
            this.edad=edad;
            this.carnet=carnet;
            this.solv=solv;
            this.curso=curso;
        }
    }
}