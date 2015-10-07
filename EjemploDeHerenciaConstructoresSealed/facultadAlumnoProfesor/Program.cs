using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;  //AGREGADO!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!

namespace facultadAlumnoProfesor
{
    class Program
    {
        static void Main(string[] args)
        {

            int edad = 66;
            Persona objetoPersona = new Persona("Persona", edad);
            int legajo = 333;
            //Alumno objetoAlumo = new Alumno(objetoPersona, legajo);
            Alumno objetoAlumo = new Alumno(new Persona("alumno",77), legajo);
            DateTime fechaEgreso = DateTime.Now;
            //AlumnoEgresado objetoAlumnoEgresado = new AlumnoEgresado(objetoAlumo, fechaEgreso);
            AlumnoEgresado objetoAlumnoEgresado = new AlumnoEgresado(new Alumno(22,8888," alumnoEgresado"),DateTime.Now);
            Profesor objetoProfesor = new Profesor(new Persona("profesor",55), 999);
            Persona[] conjuntoDePersonas= new Persona[4];
            conjuntoDePersonas[0] = objetoPersona;
            conjuntoDePersonas[1] = objetoAlumo;
            conjuntoDePersonas[2] = objetoAlumnoEgresado;
            conjuntoDePersonas[3] = objetoProfesor;

            foreach (Persona item in conjuntoDePersonas)
            {
                Console.WriteLine(item.ToString());
            }

            //---------------------------------------------------------------------------------------------------
            // COLECCIONES NO GENERICAS (no tiene genero; no tiene un tipo de dato) 
            System.Collections.ArrayList MiColeccion = new ArrayList(5);
            MiColeccion.Add("ola");
            MiColeccion.Add(objetoAlumo);
            int Cantidad = MiColeccion.Count;
            int capasidad = MiColeccion.Capacity;


            // PILAS
            Stack PilaDeDatos = new Stack();
            PilaDeDatos.Push(1);            //Agrega a la parte superior de la pila
            PilaDeDatos.Push("ola");

            Object Algo = PilaDeDatos.Peek();         //toma el objeto superior SIN borrarlo
            Algo = PilaDeDatos.Pop();                 //toma el objeto superior borrandolo  


            // COLAS
            Queue ColaDeDatos = new Queue();
            ColaDeDatos.Enqueue(1); 
            ColaDeDatos.Enqueue("ola");

            Object Algo2 = ColaDeDatos.Peek();             //toma el objeto inferior SIN borrarlo
            Algo2 = ColaDeDatos.Dequeue();                 //toma el objeto inferior borrandolo 

            // TABLA DE ARRAY
            Hashtable TablaClaveValor = new Hashtable();
            TablaClaveValor.Add(1, "Hola");
            TablaClaveValor.Add(2, "Mundo");
            TablaClaveValor.Add(3, objetoPersona);
            object Dato = TablaClaveValor[3];
            //-------------------------------------------------------------------------------------------------

            // COLECCIONES GENERICAS (poseen un genero; un tipo de dato; elementos fuertemente tipados)

            // LISTA
            List<Profesor> ListaProfesor = new List<Profesor>();
            ListaProfesor.Add(objetoProfesor);            

            List<Persona> ListaPersonas = new List<Persona>();  //Puede agregar por la herencia
            ListaPersonas.Add(objetoProfesor);
            ListaPersonas.Add(objetoAlumo);
            ListaPersonas.Add(objetoPersona);

            // PILA
            Stack<Persona> PilaPersonas = new Stack<Persona>();
            PilaPersonas.Push(objetoAlumo);
            PilaPersonas.Push(objetoProfesor);

            Algo = PilaPersonas.Peek();
            Algo = PilaPersonas.Pop();

            // COLA
            Queue<Persona> ColaPersonas = new Queue<Persona>();
            ColaPersonas.Enqueue(objetoProfesor);
            ColaPersonas.Enqueue(objetoAlumo);

            Algo = ColaPersonas.Peek();
            Algo = ColaPersonas.Dequeue();

        }
    }
}
