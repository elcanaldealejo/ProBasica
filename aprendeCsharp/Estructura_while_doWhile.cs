using System;

namespace aprendeCsharp
{
    class Estructua_while_doWhile
    {
        
        static void Main(string[] args)
        {
            
            //Ejercicio 1: Sí hoy es Miercoles 17 de Agosto... que día será el 30 de Agosto?
            string[] dias_semana = {"Lunes","Martes","Miercoles","Jueves","Viernes","Sabado","Domingo"};
            //                          0       1       2           3          4        5          6      
            int hoy = 2;
            int empezar=18;

            while(empezar<=30){
                hoy++; // esto es igual a : hoy = hoy + 1;                
                if(hoy == 7)
                    hoy = 0;
                empezar++;                
            }
            Console.WriteLine("El 30 de Agosto es : "+dias_semana[hoy]);

            //Ejercicio 2: Imprima los dias de la semana presentes en el arreglo con do While
            Console.WriteLine("//Ejercicio 2: ");
            int i = 0;
            do {
               Console.Write(dias_semana[i]+" ");
               i++; 
            }while(i<dias_semana.Length);  

            Console.WriteLine("");
            
        }
        
    }
}
