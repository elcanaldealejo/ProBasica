using System;

namespace aprendeCsharp
{
    class Condicional_IF
    {
        
        /* static void Main(string[] args)
        {
            int Num1 = 1;
            int Num2 = 2;
            var Num3 = 0;

            //OPCIÓN 1:
            // Forma básica solo para realizar código específico cuando se cumple la condición

                if(Num1 < Num2)// Si llega a ser verdadera esa condición, se ingresa a imprimir resultado.
                    Console.WriteLine("EJEMPLO 1: El numero 1 es menor que el numero 2.");
            //////
                if(Num2 > Num1){//Si llega a ser verdadera esa condición, se ingresa.
                    Console.WriteLine("EJEMPLO 2: El numero 2 es mayor que el numero 1.");
                    Num1 = Num2;                     
                }

             //OPCIÓN 2:
             // Condicional IF con estructura ELSE, ejecutar código según sea la condición
                if(Num1 == Num2)
                    Num3 = Num2+1; // se otorga el valor de Num2 incrementando un entero más (es igual que: Num3 = Num2 + 1;)
                else
                    Num3 = 0;
                Console.WriteLine("EJEMPLO 3: El numero 1 es igual que numero 2. Y numero 3 es  = "+Num3);
            //////
                if(Num3 <= Num2){                    
                    Num1 = Num2-1; // se otorga el valor de Num2 incrementando un entero más (es igual que: Num3 = Num2 - 1;)                    
                    Console.WriteLine("EJEMPLO 4: El numero 3 es menor o igual que numero 2. Y numero 1 es  = "+Num1);
                }else{
                    Num1 = 0;      
                    Console.WriteLine("EJEMPLO 4: El numero 3 es mayor que numero 2. Y numero 1 es  = "+Num1);              
                }

             //OPCIÓN 3:
             //Estructura rápida de la condición IF en una línea
             
             Num1 = (Num1 < Num3) ? Num2-1 : Num3 ;  // valor = condicion ? si es verdadera : si es falsa;
              /* es igual que decir:
                                    if(Num1 < Num3){
                                        Num1 = Num2-1;
                                    }else{
                                        Num1 = Num3;
                                    }
               */
               /*
             Console.WriteLine("EJEMPLO 5: El numero 1 es = "+Num1);   

       } */
        
    }
}
