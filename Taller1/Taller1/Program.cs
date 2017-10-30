using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taller1
{
    class Program
    {
        static void Main(string[] args)
        {
            absolu ab = new absolu();//instancia del primer punto
            capicua cap = new capicua();//instancia del segundo punto
            ParImpar ParEImpar = new ParImpar();//instancia del tercer punto
            OrdenarNumeros ordenar = new OrdenarNumeros();//instancia del Cuarto punto 
            dolares dol = new dolares();//instancia del quinto punto
            promedio pro = new promedio();//instancia del sexto punto
            triangulo tri = new triangulo();//instancia del septimo punto
            finanza fza = new finanza();//instancia del octavo punto
            Invertir4Numeros inver = new Invertir4Numeros();//instancia del noveno punto
            Capicua2 c = new Capicua2();//instancia del decimo punto





        }
        //ejercicio 1 del taller valor absoluto
        class absolu
        {
            public absolu()
            {
                Console.Write("________________________________________________________\n");
                Console.Write("Primer punto Valor Absoluto\n");
                Console.Write("Digite un numero para determinar su valor absoluto\n");
                int numero = Convert.ToInt32(Console.ReadLine());
                int absoluto = Math.Abs(numero);
                Console.Write("El valor absoluto de " + numero + " es " + absoluto+"\n");
                
            }

        }

        //ejercicio 2 del taller valor absoluto
        class capicua
        {
            string l;
            public capicua()
            {
                Console.Write("_____________________________________________________________\n");
                Console.Write("Determinar si un numero invertido es capicua \n");
                List<string> numero = new List<string>();
                Console.WriteLine("Digite un numero de una cifra");
                String num1 = Console.ReadLine();
                numero.Add(num1);

                Console.WriteLine("Digite un numero de una cifra");
                String num2 = Console.ReadLine();
                numero.Add(num2);

                Console.WriteLine("Digite un numero de una cifra");
                String num3 = Console.ReadLine();
                numero.Add(num3);
                string numerodigitado = num1 + num2 + num3;
                Console.WriteLine("el numero digitado es: "+ (Convert.ToInt32(numerodigitado)) + "\n");
                Console.WriteLine("el numero invertido es:\n");
                
                foreach (string l in numero.Reverse<string>())
                {
                    
                    Console.WriteLine(Convert.ToInt32(l));
                }

                if (numerodigitado == l)
                {
                    Console.WriteLine("el numero digitado  es capicua\n");
                }
                else
                {
                    Console.WriteLine("el numero digitado  no es capicua\n");
                }
            }

        }



        //ejercicio 3 del taller valor Numero par o impar
        class ParImpar
        {
            public ParImpar()
            {
                Console.Write("_____________________________________________________________\n");
                Console.Write("Tercer Punto Numero par E impar\n");
                Console.Write("Digite un numero para validar si es par o impar\n");
                int num = Convert.ToInt32(Console.ReadLine());
                if (num % 2 == 0)
                {
                    Console.Write("El numero digitado es par\n");
                }
                else
                {

                    Console.Write("El numero digitado es impar\n");
                }
                
            }

        }


        //ejercicio 4 del taller organizar tres numero
        class OrdenarNumeros
        {
            public OrdenarNumeros()
            {
                Console.Write("_____________________________________________________________\n");
                Console.Write("Cuarto Oragnizar tres numero\n");
                List<string> numero = new List<string>();
                Console.WriteLine("Digite un numero de una cifra");
                String num1 = Console.ReadLine();
                numero.Add(num1);

                Console.WriteLine("Digite un numero de una cifra");
                String num2 = Console.ReadLine();
                numero.Add(num2);

                Console.WriteLine("Digite un numero de una cifra");
                String num3 = Console.ReadLine();
                numero.Add(num3);

                Console.WriteLine(num1+num2+num3+"\n");

                var lis = from u in numero orderby u descending select u;
                Console.WriteLine(lis);
            }

        }


        //ejercicio 5 del taller Dolares
        class dolares
        {
            public dolares()
            {
                Console.Write("_____________________________________________________________\n");
                Console.Write("Quinto Punto Convertir pesos a dolares\n");
                Console.Write("Digite un valor en pesos para convertirlos en dolares $\n");
                Double pesos = Convert.ToDouble(Console.ReadLine());
                Double dolar = (pesos / 2936.66);
                Console.Write("El valor en dolares es: us$" + dolar+"\n");


                
            }

        }


        //ejercicio 6 del taller Promedio de tres notas
        class promedio
        {
            public promedio()
            {
                Console.Write("_____________________________________________________________\n");
                Console.Write("Sexto Punto Promedio de de tres notas\n");
                Console.Write("Digite nota 1 :\n");
                int nota1 = Convert.ToInt32(Console.ReadLine());
                Console.Write("Digite nota 2 :\n");
                int nota2 = Convert.ToInt32(Console.ReadLine());
                Console.Write("Digite nota 3 :\n");
                int nota3 = Convert.ToInt32(Console.ReadLine());
                int promedio = ((nota1 + nota2 + nota3) / 3);
                Console.Write("El promedio de las notas es: " + promedio+"\n");
                
            }

        }


        //ejercicio 7 del taller valor triangulo
        class triangulo
        {
            public triangulo()
            {
                
                
            }

        }

        //ejercicio 8 del taller fianza
        class finanza
        {
            public finanza()
            {
                Console.Write("_____________________________________________________________\n");
                Console.Write("octavo Punto fianza \n");
                String consulta;
                do
                {
                    int fianza, cuota;
                    Console.Write("Digite monto de la fianza: $");
                    fianza = int.Parse(Console.ReadLine());
                    if (fianza < 50000)
                    {
                        cuota = fianza * 3 / 10;
                        Console.WriteLine("valor couta a pagar por cliente: " + cuota+"\n");
                        Console.WriteLine("Desea hacer otra consulta?  si/no\n");
                        consulta = Console.ReadLine();
                        Console.WriteLine("**********************************************************\n");


                    }
                    else
                    {
                        cuota = fianza * 2 / 10;
                        Console.WriteLine("valor couta a pagar por cliente: " + cuota+"\n");
                        Console.WriteLine("Desea hacer otra consulta?  si/no\n");
                        consulta = Console.ReadLine();
                        Console.WriteLine("**********************************************************\n");
                    }

                } while (consulta == "si");
            }

        }


        //ejercicio 9 del taller invertir cuatro digitos
        class Invertir4Numeros
        {
            public Invertir4Numeros()
            {
                Console.Write("_____________________________________________________________\n");
                Console.Write("invertir un numero de 4 digitos\n");
                List<string> numero = new List<string>();
                Console.WriteLine("Digite un numero de una cifra");
                String num1 = Console.ReadLine();
                numero.Add(num1);

                Console.WriteLine("Digite un numero de una cifra");
                String num2 = Console.ReadLine();
                numero.Add(num2);

                Console.WriteLine("Digite un numero de una cifra");
                String num3 = Console.ReadLine();
                numero.Add(num3);
                Console.WriteLine("Digite un numero de una cifra\n");
                String num4 = Console.ReadLine();
                numero.Add(num4);
                string numerodigitado = num1 + num2 + num3+num4;
                Console.WriteLine("el numero digitado es: " + (numerodigitado) + "\n");
                Console.WriteLine("el numero invertido es:\n");

                foreach (string l in numero.Reverse<string>())
                {

                    Console.WriteLine(l);
                }

            }

        }


        //ejercicio 10 del taller valor absoluto
        class Capicua2
        {
            String l;
            public Capicua2()
            {
                Console.Write("_____________________________________________________________\n");
                Console.Write("Determinar si un numero invertido es capicua \n");
                List<string> numero = new List<string>();
                Console.WriteLine("Digite un numero de una cifra");
                String num1 = Console.ReadLine();
                numero.Add(num1);

                Console.WriteLine("Digite un numero de una cifra");
                String num2 = Console.ReadLine();
                numero.Add(num2);

                Console.WriteLine("Digite un numero de una cifra");
                String num3 = Console.ReadLine();
                numero.Add(num3);
                string numerodigitado = num1 + num2 + num3;
                Console.WriteLine("el numero digitado es: " + (Convert.ToInt32(numerodigitado)) + "\n");
                Console.WriteLine("el numero invertido es:\n");

                foreach (string l in numero.Reverse<string>())
                {

                    Console.WriteLine(Convert.ToInt32(l));
                }

                if (numerodigitado == l)
                {
                    Console.WriteLine("el numero digitado  es capicua\n");
                }
                else
                {
                    Console.WriteLine("el numero digitado  no es capicua\n");
                }
                Console.ReadKey();
            }

        }




    }
}
