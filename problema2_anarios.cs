internal class Program
{
    private static void Main(string[] args)
    {
        string[,] productos = new string[10, 3];
        int opcion;

        do
        {
            Console.Clear();
            Console.WriteLine("===== MENU =====");
            Console.WriteLine("1. Registrar producto");
            Console.WriteLine("2. Mostrar productos");
            Console.WriteLine("3. Actualizar producto");
            Console.WriteLine("4. Eliminar producto");
            Console.WriteLine("5. Salir");
            Console.Write("Seleccione una opción: ");
            opcion = int.Parse(Console.ReadLine());

            switch (opcion)
            {
                case 1:
                    bool registrado = false;

                    for (int i = 0; i < 10; i++)
                    {
                        if (string.IsNullOrEmpty(productos[i, 0]))
                        {
                            Console.Write("Código: ");
                            productos[i, 0] = Console.ReadLine();

                            Console.Write("Nombre: ");
                            productos[i, 1] = Console.ReadLine();

                            Console.Write("Cantidad: ");
                            productos[i, 2] = Console.ReadLine();

                            Console.WriteLine("Producto registrado correctamente.");
                            registrado = true;
                            break;
                        }
                    }

                    if (!registrado)
                        Console.WriteLine("No hay espacio disponible.");

                    Console.ReadKey();
                    break;

                case 2:

                    Console.WriteLine("\nLISTA DE PRODUCTOS");

                    for (int i = 0; i < 10; i++)
                    {
                        if (!string.IsNullOrEmpty(productos[i, 0]))
                        {
                            Console.WriteLine("----------------------------");
                            Console.WriteLine("Código: " + productos[i, 0]);
                            Console.WriteLine("Nombre: " + productos[i, 1]);
                            Console.WriteLine("Cantidad: " + productos[i, 2]);
                        }
                    }

                    Console.ReadKey();
                    break;

                case 3:

                    Console.Write("Ingrese el código del producto: ");
                    string codigo = Console.ReadLine();
                    bool encontrado = false;

                    for (int i = 0; i < 10; i++)
                    {
                        if (productos[i, 0] == codigo)
                        {
                            Console.Write("Nuevo nombre: ");
                            productos[i, 1] = Console.ReadLine();

                            Console.Write("Nueva cantidad: ");
                            productos[i, 2] = Console.ReadLine();

                            Console.WriteLine("Producto actualizado.");
                            encontrado = true;
                            break;
                        }
                    }

                    if (!encontrado)
                        Console.WriteLine("Producto no encontrado.");

                    Console.ReadKey();
                    break;

                case 4:

                    Console.Write("Ingrese el código del producto: ");
                    codigo = Console.ReadLine();

                    encontrado = false;

                    for (int i = 0; i < 10; i++)
                    {
                        if (productos[i, 0] == codigo)
                        {
                            productos[i, 0] = "";
                            productos[i, 1] = "";
                            productos[i, 2] = "";

                            Console.WriteLine("Producto eliminado.");
                            encontrado = true;
                            break;
                        }
                    }

                    if (!encontrado)
                        Console.WriteLine("Producto no encontrado.");

                    Console.ReadKey();
                    break;

                case 5:
                    Console.WriteLine("Programa finalizado.");
                    break;

                default:
                    Console.WriteLine("Opción inválida.");
                    Console.ReadKey();
                    break;
            }

        } while (opcion != 5);
    }
}
    