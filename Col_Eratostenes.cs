using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Coladera_de_Eratostenes
{
    class Col_Eratostenes
    {
        private int _Numero; // número máximo hasta el que se quiere calcular
        public Col_Eratostenes(int numero) // numero es el limitepara hacer comparaciones 
        {
            _Numero = numero;
        }
        public string NumPrimos()
        {
            string Resultado=" "; // 
            int n = _Numero;
            bool[] marcados = new bool[n + 1]; // se crea un vector boleano para darnos los numeros marcado que sean muliplos de los primos con falso y verdadero
              for (int i = 2; i <= n; i++) // se inicia el ciclo apartir de 2 ya que es el primer numero primo
               {
                   if (!marcados[i]) // si los numeros marcados son diferentes de i
                       for (int j = i * 2; j <= n; j += i) // este contador nos ayudara para saber los multiplos de los numeros primos para descartarlos
                        marcados[j] = true; // se marcan los que se sabe que NO son primos
               }
                for (int i = 2; i < marcados.Length; i++) //lo utilizamos para checar los numeros que quedaron en el vector
                    if (marcados[i] == false) // se muestran los numeros no marcados y esos son los primos
                    {
                        Resultado += i+Environment.NewLine;  
                    }
            return Resultado; // regresa los numeros primos 2,3,5, etc
        }
        public override string ToString() // nos dara los valores cuando lo invoquemos en el boton
        {
            return NumPrimos()+"";
        }
    }
}
