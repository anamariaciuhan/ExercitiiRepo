using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercitii
{
    class Program
    {
        static void Main(string[] args)
        {
            // exercitiul 1 C# Sharp Basic Declarations
            Console.WriteLine("    ");
            Console.WriteLine("--------------Exercitiul 1----------");
            Console.WriteLine("Hello: ");
            Console.WriteLine("Ana-Maria Ciuhan");

            //exercitiul 2  C# Sharp Basic Declarations
            Console.WriteLine("    ");
            Console.WriteLine("----------Exercitiul 2--------------");
            int a = 2;
            int b = 5;
            int suma = 0;
            suma = a + b;
            Console.WriteLine("Suma numerelor este: " + suma);

            //exercitiul 3  C# Sharp Basic Declarations
            Console.WriteLine("    ");
            Console.WriteLine("----------Exercitiul 3--------------");

            int c = 8;
            int d = 4;
            int impartire = 0;
            Console.WriteLine("Rezultatul impartirii este: " + impartire);


            //exercitiul 4  C# Sharp Basic Declarations
            Console.WriteLine("    ");
            Console.WriteLine("----------Exercitiul 4--------------");

            Console.WriteLine(-1 + 4 * 6);
            Console.WriteLine((35 + 5) % 7);
            Console.WriteLine(14 + ((-4 * 6 )/ 11));
            Console.WriteLine(2 + ((15 / 6) * 1) - 7 % 2);


            //exercitiul 5  c# sharp basic declarations
            Console.WriteLine("    ");
            Console.WriteLine("----------exercitiul 5--------------");
            int numarul1, numarul2, temp;
            temp = 0;
            Console.WriteLine("introduceti primul numar:    ");
            numarul1 = int.Parse(Console.ReadLine());
            Console.WriteLine("introduceti al doilea numar:    ");
            numarul2 = int.Parse(Console.ReadLine());

            temp = numarul1;
            numarul1 = numarul2;
            numarul2 = temp;

            Console.WriteLine("Dupa schimbare numarele sunt: ");
            Console.WriteLine("Primul numar: " + numarul1);
            Console.WriteLine("Dupa schimbare numarele sunt: " + numarul2);


            //exercitiul 6  C# Sharp Basic Declarations
            Console.WriteLine("    ");
            Console.WriteLine("----------Exercitiul 6--------------");

            int nr1, nr2, nr3, inmultire = 0;
            Console.WriteLine("Introduceti primul nr: ");
            nr1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Introduceti al doilea nr: ");
            nr2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Introduceti al treilea nr: ");
            nr3 = int.Parse(Console.ReadLine());

            inmultire = nr1 * nr2 * nr3;
            Console.WriteLine("Rezultatul inmultirii este: " + inmultire);

            //exercitiul 7  C# Sharp Basic Declarations
            Console.WriteLine("    ");
            Console.WriteLine("----------Exercitiul 7--------------");

            int no1, no2, adunare, scadere, inmultire1, impartire1, mod;
            Console.WriteLine("Introduceti primul nr: ");
            no1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Introduceti al doilea nr: ");
            no2 = int.Parse(Console.ReadLine());
            adunare = no1 + no2;
            scadere = no1 - no2;
            inmultire1 = no1 * no2;
            impartire1 = no1 / no2;
            mod = no1 % no2;

            Console.WriteLine("Rezultatul adunarii este: " + adunare);
            Console.WriteLine("Rezultatul scaderii este: " + scadere);
            Console.WriteLine("Rezultatul inmultirii este: " + inmultire1);
            Console.WriteLine("Rezultatul impartiriii este: " + impartire1);
            Console.WriteLine(mod);

            //exercitiul 8  C# Sharp Basic Declarations
            Console.WriteLine("    ");
            Console.WriteLine("----------Exercitiul 8--------------");

            int n;
            Console.WriteLine("Introduceti un numar: ");
            n = int.Parse(Console.ReadLine());
            for (int i = 0; i <= 10; i++)
            {
                int tablain = 0;
                tablain = i * n;
                Console.WriteLine(tablain);
            }

           // exercitiul 9  C# Sharp Basic Declarations
            Console.WriteLine("    ");
            Console.WriteLine("----------Exercitiul 9--------------");

            double number1, number2, number3, number4, media = 0;
            Console.WriteLine("Introduceti primul nr: ");
            number1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Introduceti al doilea nr: ");
            number2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Introduceti al treilea nr: ");
            number3 = int.Parse(Console.ReadLine());
            Console.WriteLine("Introduceti al patrulea nr: ");
            number4 = int.Parse(Console.ReadLine());
            media = (number1 + number2 + number3 + number4) / 4;

            Console.WriteLine("Media numerelor este: " + media);

            //exercitiul 10  C# Sharp Basic Declarations
            Console.WriteLine("    ");
            Console.WriteLine("----------Exercitiul 10--------------");

            int x, y, z;
            Console.WriteLine("Introduceti primul nr: ");
            x = int.Parse(Console.ReadLine());
            Console.WriteLine("Introduceti al doilea nr: ");
            y = int.Parse(Console.ReadLine());
            Console.WriteLine("Introduceti al treilea nr: ");
            z = int.Parse(Console.ReadLine());
            Console.WriteLine((x + y) * z);
            Console.WriteLine((x * y) + (y * z));


            // exercitiul 11  C# Sharp Basic Declarations
            Console.WriteLine("    ");
            Console.WriteLine("----------Exercitiul 11--------------");

            int v;
            Console.WriteLine("Please type your age: ");
            v = int.Parse(Console.ReadLine());
            Console.WriteLine("You look older tahn: " + v);


            // exercitiul 12  C# Sharp Basic Declarations
            Console.WriteLine("    ");
            Console.WriteLine("----------Exercitiul 12--------------");

            int m = 0;
            Console.WriteLine("Introduceti  nr: ");
            m = int.Parse(Console.ReadLine());
            Console.WriteLine(m + " " + m + " " + m + " " + m);
            Console.WriteLine(m + "" + m + "" + m + "" + m);

            Console.WriteLine("{0} {0} {0} {0}", m);
            Console.WriteLine("{0}{0}{0}{0}", m);

            // exercitiul 13  C# Sharp Basic Declarations
            Console.WriteLine("    ");
            Console.WriteLine("----------Exercitiul 13--------------");

            int k = 0;
            Console.WriteLine("Introduceti  nr: ");
            k = int.Parse(Console.ReadLine());

            Console.WriteLine("{0}{0}{0}", k);
            for (int i = 1; i <= 3; i++)
            {
                Console.WriteLine(k + " " + k);
            }
            Console.WriteLine("{0}{0}{0}", k);

            // exercitiul 14  C# Sharp Basic Declarations
            Console.WriteLine("    ");
            Console.WriteLine("----------Exercitiul 14--------------");
            int celsius = 0, kelvin, fahrenheit;
            Console.WriteLine("Introduceti gradele C: ");
            celsius = int.Parse(Console.ReadLine());
            kelvin = celsius + 273;
            fahrenheit = celsius * 18 / 10 + 32;
            Console.WriteLine("Kelvin= " + kelvin);
            Console.WriteLine("Farenheit=: " + fahrenheit);


            // exercitiul 1 C# Sharp Data Types

            Console.WriteLine("    ");
            Console.WriteLine("----------Exercitiul 1 C# Sharp Data Types--------------");
            int a1, b1, c1;
            Console.WriteLine("Introduceti a: ");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("Introduceti b: ");
            b = int.Parse(Console.ReadLine());
            Console.WriteLine("Introduceti c: ");
            c = int.Parse(Console.ReadLine());

            Console.WriteLine("{0} {1} {2}", c, b, a);


            //exercitiul 2 C# Sharp Data Types

            //Console.WriteLine("    ");
            //Console.WriteLine("----------Exercitiul 2 C# Sharp Data Types--------------");
            //int nr_, latime;
            //Console.WriteLine("Introduceti un numar: ");
            //nr_= int.Parse(Console.ReadLine());
            //Console.WriteLine("Introduceti latimea: ");
            //latime = int.Parse(Console.ReadLine());
            //int inaltime = latime;
            //for(int i=0;i<inaltime;i++)
            //{
            //    for(int j=0;j<=latime;j++){

            //        Console.WriteLine(nr_);
            //    }
            //    Console.WriteLine();
            //    latime--;
            //}


            Console.ReadKey();
        }
    }
}
