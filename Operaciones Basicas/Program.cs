using System;

namespace Operaciones_Basicas
{
    class Program
    {
        public static void Main(string[] args)
        {
            try{
                string opc;
                int[] numeros = new int[3];
                Funciones funci = new Funciones();
                do{
                    Console.Clear();
                    Console.WriteLine(" \nBienvenido A Mi Programa de Operaciones Basicas!! \n \nIngrese los Numeros que desea Operar... (Las operaciones se realizaran según el orden de ingreso de ambos numeros)");
                    for(int w = 1; w<3;w++){
                        Console.WriteLine(" \nIngrese el Operando Numero: "+w.ToString());
                    numeros[w] = Convert.ToInt32(Console.ReadLine());
                    }
                    do{
                        Console.Clear();
                        Console.WriteLine(" \nQue Operacion deseas Realizar con los Numeros Ingresados? \n \n1. SUMA \n2. RESTA \n3. MULTIPLICACIÓN \n4. DIVISIÓN \n5. MÓDULO \n \n6. INGRESAR NUEVOS NUMEROS \n7. SALIR DEL PROGRAMA");
                        opc = Console.ReadLine();
                        switch(opc){
                            case "1":
                                funci.suma(numeros[1],numeros[2]);
                                break;
                            case "2":
                                funci.resta(numeros[1],numeros[2]);
                                break;
                            case "3":
                                funci.multi(numeros[1],numeros[2]);
                                break;
                            case "4":
                                funci.divi(numeros[1],numeros[2]);
                                break;
                            case "5":
                                funci.modu(numeros[1],numeros[2]);
                                break;
                            case "6":
                                break;
                            case "7":
                                Console.WriteLine(" \nGracias por Utilizar mi Programa! Espero haya sido de tu Agrado!! ;)");
                                Console.ReadKey();
                                break;
                            default:
                                Console.WriteLine(" \nLa opción Ingresada no existe, Ingrese una opcion válida");
                                Console.ReadKey();
                                break;
                        }
                    }while(opc!="6" && opc!="7");
                }while(opc!="7");
            }catch(Exception ex){
                Console.WriteLine(ex.Message);
            }
        }
    }
    public class Funciones{
        public void suma(int x, int y){
            Console.WriteLine($" \nLa Suma entre {x} + {y} es: "+(x+y).ToString());
            Console.ReadKey();
        }
        public void resta(int x, int y){
            Console.WriteLine($" \nLa Resta entre {x} - {y} es: "+(x-y).ToString());
            Console.ReadKey();
        }
        public void multi(int x, int y){
            Console.WriteLine($" \nLa Multiplicación entre {x} * {y} es: "+(x*y).ToString());
            Console.ReadKey();
        }
        public void divi(double x, double y){
            double r = x/y;
            Console.WriteLine($" \nLa División entre {x} / {y} es: "+r);
            Console.ReadKey();
        }
        public void modu(double x, double y){
            double r = x % y;
            Console.WriteLine($" \nEl Módulo entre {x} % {y} es: "+r);
            Console.ReadKey();
        }
    }
}