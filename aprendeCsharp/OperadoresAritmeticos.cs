using System;

namespace aprendeCsharp
{
    class OperadoresAritmeticos
    {
        
        /* static void Main(string[] args)
        {
            int damage, botiquinS, botiquinM;
            int maxVida=100;
            int saludActual=100 , botiquinF = maxVida;
            Console.WriteLine("Salud: {0} LP ",saludActual);

            //Vida Maxima
            //  _ _ _ _ _ _ _ _ _ _
            // |_|_|_|_|_|_|_|_|_|_|

            botiquinS = maxVida / 5; //Restaura una 5ta parte de vida según el sea el maximo.
            //Celdas de recuperacion Botiquín Pequeño
            //  _ _ 
            // |_|_|

            botiquinM = maxVida / 2; //Restaura la mitad de puntos de vida según el sea el maximo.
            //Celdas de recuperacion Botiquín Mediano
            //  _ _ _ _ _ 
            // |_|_|_|_|_|

            //Enemigo golpea (sin arma) al personaje dañando 60 puntos de vida
            damage = 60;
            saludActual = saludActual - damage; // = 40 
            Console.WriteLine("Salud: -{1} LP \n  {0} LP ",saludActual,damage);

            //Personaje utiliza un botiquín PEQUEÑO para recuperar salud
            saludActual = saludActual + botiquinS; // = 60
            Console.WriteLine("Salud: +{1} LP\n  {0} LP ",saludActual,botiquinS);

            //Enemigo se hace daño y pierde 30 puntos de vida
            saludActual = saludActual - 30; // = 30
            Console.WriteLine("Salud: -30 LP\n  {0} LP ",saludActual);

            //Personaje utiliza un botiquín MEDIANO para recuperar salud
            saludActual = saludActual + botiquinM; // = 80
            Console.WriteLine("Salud: +{1} LP\n  {0} LP ",saludActual,botiquinM);

            //Enemigo golpea esta vez (CON arma) y pontencializa su daño un 20% más,
            //el personaje pierde 72 puntos de vida.
            damage = damage + Convert.ToInt32(damage * 0.2f); //10% = 0.1 / 50% = 0.5   etc.
            saludActual = saludActual - damage; // = 8
            Console.WriteLine(" Salud: -{1} LP\n  {0} LP ",saludActual,damage);
            
            //Personaje casi agonizante utiliza botiquín GRANDE para recuperar salud total
            saludActual = saludActual + botiquinF; // = 108

            //Celdas de recuperacion Botiquín Grande
            //  _ _ _ _ _ _ _ _ _ _
            // |_|_|_|_|_|_|_|_|_|_|
            
            Console.WriteLine("Salud: +{1} LP\n  {0} LP ", saludActual, botiquinF);
        } */
        
    }
}
