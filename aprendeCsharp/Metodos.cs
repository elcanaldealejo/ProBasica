using System;

namespace aprendeCsharp
{
    class Metodos
    {
        
       /*  static void Main()
        {

            var objeto_clase = new Metodos();
            //El objetivo de utilizar métodos o funciones está en crear operaciones o tareas dentro de ellos que puedan llamarse cuanto se necesiten
            //También disminuye el código repetitivo.
            Metodo1();//Metodo estático
            var texto = objeto_clase.Metodo2();
            Console.WriteLine("Valor Retornado 1 : {0}",texto);
            var suma = objeto_clase.Metodo3(1,2);
            Console.WriteLine("Valor Retornado 2 : {0}",suma);
        } */

        //Los Métodos Privados solo podrán llamarse para ejecución dentro de su Clase.
        //Los métodos estáticos podrán ser ejecutados solo dentro de métodos igualmente estáticos.
        //Los métodos con la propiedad void ejecutaran su código interno, pero no retornaran ningún valor.
        //Los métodos que no poseen parámetros se llamaran solo por su nombre y los paréntesis sin contenido ()
        private static void Metodo1(){
            Console.WriteLine("Soy el Metodo 1: privado - estatico - no retorno - sin parametros");
        }

        //Los métodos públicos pueden ser invocados dentro de su misma clase y desde otras también
        //Para ejecutar un método no estático dentro de uno estático es requerido hacerlo por medio de un objeto de la clase
        //Los métodos pueden retornar valores, esto se define desde el inicio, según sea el tipo de dato, es obligación retornar algo del mismo tipo de dato
        public string Metodo2(){
            Console.WriteLine("Soy el Metodo 2: publico - si retorno - sin parametros");
            return "Hola Mundo!";
        }

        //Los métodos con parámetros necesitaran recibir el tipo de dato expresado en su estructura
        //al llamar métodos con parámetros se enviaran valores dentro de los paréntesis (dato1,dato2,datoN).
        //Pueden existir varios Return dentro del método, pero cuando se llegue a uno de ellos se terminara de ejecutar y retornara el valor.
        private int Metodo3(int a, int b){
            Console.WriteLine("Soy el Metodo 3: privado - si retorno - con parametros");
            return (a+b);
        }
        
    }
}
