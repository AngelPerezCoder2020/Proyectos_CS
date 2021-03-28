using System;

namespace Clasess
{
    class Program
    {
        static void Main(string[] args)
        {
            String nombre;
            String nombre2;
            String carnet;
            int edad;
            int P1;
            int P2;
            int F;
            Boolean solve;
            int c = 0;
            Estudiantes[] lista = new Estudiantes[5];
            while(c<5){
                Console.Clear();
                Console.WriteLine("---Registro, Alumno Numero "+(c+1)+"---");
                Console.WriteLine("Ingrese Nombre Del Alumno");
                nombre = Console.ReadLine();
                Console.WriteLine("Ingrese Edad Del Alumno");
                edad = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Ingrese Carnet Del Alumno");
                carnet = Console.ReadLine();
                Console.WriteLine("El estudiante esta solvente?");
                solve = Convert.ToBoolean(Console.ReadLine());
                Console.WriteLine("Cual es el nombre del curso?");
                nombre2 = Console.ReadLine();
                Console.WriteLine("Cual es la nota del Primer Parcial?");
                P1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Cual es la nota del Segundo Parcial?");
                P2 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Cual es la nota final del curso?");
                F = Convert.ToInt32(Console.ReadLine());
                Materia clase = new Materia(nombre2, P1, P2, F);
                Estudiantes estudiante = new Estudiantes(nombre,edad,carnet,solve,clase);
                lista[c]=estudiante;
                c++;
            }
            for(int x=0;x<5;x++){
                Console.WriteLine("--------------------");
                Console.WriteLine("Alumno número: "+(x+1));
                Console.WriteLine("--------------------");
                Console.WriteLine("Nombre: "+lista[x].nombre);
                Console.WriteLine("Edad: "+lista[x].edad);
                Console.WriteLine("Carnet: "+lista[x].carnet);
                Console.WriteLine("Solvencia: "+lista[x].solv);
                Console.WriteLine("Nombre Del Curso: "+lista[x].curso.nombre);
                Console.WriteLine("Nota Primer Parcial: "+lista[x].curso.p1);
                Console.WriteLine("Nota Segundo Parcial: "+lista[x].curso.p2);
                Console.WriteLine("Nota Final del Curso: "+lista[x].curso.f);
                Console.WriteLine("");
            }
            Console.ReadKey();
        }
    }
}