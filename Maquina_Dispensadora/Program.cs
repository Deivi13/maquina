using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maquina_Dispensadora
{
    class Program
    {

        static void Venta(int money, string nombre, int precio, int existencia)
        {
            Producto producto = new Producto();

            if (existencia != 0)
            {
                if (money >= precio)
                {
                    money = money - precio;
                    existencia = existencia - 1;
                    Console.Clear();
                    Console.WriteLine("Dinero restante: " + money);
                    Console.WriteLine("Usted acaba de comprar: " + nombre);
                    Console.WriteLine("Aun quedan {0} de nuestro producto '{1}' ", existencia, nombre);



                }
                else
                {
                    Console.WriteLine("Usted no tiene mas dinero");
                }
            }
            else
            {
                Console.WriteLine("Este Producto esta agotado");
            }
        }


        static void Main(string[] args)
        {
            var producto = new Producto[10];
            producto[0] = new Producto { Nombre = "Doritos", Precio = 25, Existencia = 10};
            producto[1] = new Producto { Nombre = "Lays", Precio = 25, Existencia = 10 };
            producto[2] = new Producto { Nombre = "Milky Ways", Precio = 20, Existencia = 10 };
            producto[3] = new Producto { Nombre = "Kola Real", Precio = 15, Existencia = 10 };
            producto[4] = new Producto { Nombre = "Princesa", Precio = 10, Existencia = 10 };
            producto[5] = new Producto { Nombre = "Oreo", Precio = 15, Existencia = 10 };
            producto[6] = new Producto { Nombre = "Yogurt", Precio = 30, Existencia = 10 };
            producto[7] = new Producto { Nombre = "Tridents", Precio = 40, Existencia = 10 };
            producto[8] = new Producto { Nombre = "Malta Morena", Precio = 25, Existencia = 10 };
            producto[9] = new Producto { Nombre = "Agua Dasani", Precio = 134000000, Existencia = 10 };


            Console.WriteLine("Maquina Dispensadora de alimentos");
            Console.WriteLine("Introduzca su dinero \nNota: Solo se admiten Monedas de 5, 10 y 25, Billetes de 50, 100, 200");
            int Dinero = int.Parse(Console.ReadLine());

            if (Dinero == 5 || Dinero == 10 || Dinero == 25 || Dinero == 50 || Dinero == 100 || Dinero == 200) 
            {
                Console.Clear();
                Console.WriteLine("Usted acaba de introducir: " + Dinero);
            }
            else
            {
                do
                {
                    Console.Clear();
                    Console.WriteLine(" ERROR Usted acaba de introducir: {0} \n Solo se admiten Monedas de 5, 10 y 25, Billetes de 50, 100, 200 \n Intruzca dinero nuevamente ", Dinero);
                    Dinero = int.Parse(Console.ReadLine());

                } while (Dinero == 5 || Dinero == 10 || Dinero == 25 || Dinero == 50 || Dinero == 100 || Dinero == 200);
            }

            Console.WriteLine("Nuestros Productos son: \n1) Doritos. \n2) Lays. \n3) Milky Ways. \n4) Kola Real. \n5) Princesa. \n6) Oreo. \n7) Yogurt. \n8) Tridents. \n9) Malta Morena. \n10) Agua Dasani.");
            int Product = int.Parse(Console.ReadLine());
                   

                switch (Product)
                    {
                        case 1:
                            Venta(Dinero, producto[0].Nombre, producto[0].Precio, producto[0].Existencia);
                            break;
                        case 2:
                            Venta(Dinero, producto[1].Nombre, producto[1].Precio, producto[1].Existencia);
                            break;
                        case 3:
                            Venta(Dinero, producto[2].Nombre, producto[2].Precio, producto[2].Existencia);
                            break;
                        case 4:
                            Venta(Dinero, producto[3].Nombre, producto[3].Precio, producto[3].Existencia);
                            break;
                        case 5:
                            Venta(Dinero, producto[4].Nombre, producto[4].Precio, producto[4].Existencia);
                            break;
                        case 6:
                            Venta(Dinero, producto[5].Nombre, producto[5].Precio, producto[5].Existencia);
                            break;
                        case 7:
                            Venta(Dinero, producto[6].Nombre, producto[6].Precio, producto[6].Existencia);
                            break;
                        case 8:
                            Venta(Dinero, producto[7].Nombre, producto[7].Precio, producto[7].Existencia);
                            break;
                        case 9:
                            Venta(Dinero, producto[8].Nombre, producto[8].Precio, producto[8].Existencia);
                            break;
                        case 10:
                            Venta(Dinero, producto[9].Nombre, producto[9].Precio, producto[9].Existencia);
                            break;
                default:
                    Console.Clear();
                    Console.WriteLine("ERROR Elija productos del 1 al 10, por favor!");
                    break;

            }
                                                                                 
           
            Console.ReadKey();

        }
    }

    class Producto
    {


        public string Nombre { get; set; }

        public int Precio { get; set; }

        public int Existencia { get; set; }

        

    }
}
