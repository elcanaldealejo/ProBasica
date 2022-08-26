using System;

namespace aprendeCsharp
{
    class VariablesGlobales
    {
        public int a = 7;
        public int b = 5;

        /* static void Main()
        {   
            var Objeto_clase = new VariablesGlobales();

            Objeto_clase.Suma(Objeto_clase.a,Objeto_clase.b);
            Objeto_clase.Resta();
            Console.WriteLine("Producto = {0}",Objeto_clase.Producto());
            
        }   */

        public void Suma(int a, int b){
            Console.WriteLine("Suma = {0}",a+b);
        }
        public void Resta(){
            int a = this.a;
            int b = this.b;
            this.a = 0;
            this.b = 0;
            Console.WriteLine("Resta = {0}",a-b);
        }
        public int Producto(){

            return (a*b);
        }
        
    }
}
