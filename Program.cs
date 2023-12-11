using System.ComponentModel.Design;

namespace Arrays
{
    class Program 
    { 
        static void Main(string[] args)
        {
            object[] elemetoVajilla = new object[5];
            elemetoVajilla[0] = 0;
            elemetoVajilla[1] = 'a';
            elemetoVajilla[2] = 'a';
            elemetoVajilla[3] = 'a';
            elemetoVajilla[4] = 0;
            int mostrarMenu()
            {
                Console.WriteLine("0. cerrar menu");
                Console.WriteLine("1. añadir id");
                Console.WriteLine("2. añadir codigo");
                Console.WriteLine("3. añadir nombre");
                Console.WriteLine("4. añadir descripcion");
                Console.WriteLine("5. añadir cantidad");
                int eleecion = Convert.ToInt32(Console.ReadLine());
                return eleecion;
            }

            int eleccion;
            bool abrir = false;
            while (!abrir)
            {
                eleccion = mostrarMenu();
                switch (eleccion)
                {
                    case 0:
                        Console.WriteLine("cerrado");
                        abrir = true;
                        break;
                    case 1:
                        Console.WriteLine("escribe el id ");
                        int id = Convert.ToInt32(Console.ReadLine());
                        elemetoVajilla[0] = id;
                        Console.WriteLine(elemetoVajilla[0]);
                        break;
                    case 2:
                        Console.WriteLine("escribe el codigo ");
                        string codigo = Console.ReadLine();
                        elemetoVajilla[1] = codigo;
                        Console.WriteLine(elemetoVajilla[1]);
                        Console.WriteLine("escribe el id ");
                        break;
                    case 3:
                        Console.WriteLine("escribe el nombre ");
                        string nombre = Console.ReadLine();
                        elemetoVajilla[2] = nombre;
                        Console.WriteLine(elemetoVajilla[2]);
                        break;
                    case 4:
                        Console.WriteLine("escribe el descripcion ");
                        string descripcion = Console.ReadLine();
                        elemetoVajilla[3] = descripcion;
                        Console.WriteLine(elemetoVajilla[3]);
                        break; 
                    case 5:
                        Console.WriteLine("escribe el canridad ");
                        int cantidad = Convert.ToInt32(Console.ReadLine());
                        elemetoVajilla[4] = cantidad;
                        Console.WriteLine(elemetoVajilla[4]);
                        break;

                    default:
                        Console.WriteLine("eleccion no correcta");
                        break;

                }

            }


        }
    }
}