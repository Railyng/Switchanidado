using System;

namespace Switchanidado
{
    class program
    {
        static void Main(string[] args)

        {
            bool continuar = true;

            do
            {
                
                Console.WriteLine("\n MENU PRINCIPAL: \n");
                Console.WriteLine("\n INGRESE \n(1) si quiere capturar un nombre \n(2) si quiere sumar dos numeros  \n(3) si quiere cerrar el programa\n \n");
                int seleccion = int.Parse(Console.ReadLine());

                    switch (seleccion)
                    {
                        case 1:
                            int opcion1;
                            Console.WriteLine("\nSeguro que desea capturar un nombre (marca (1) si o marca (2) si quiere volver atras)");
                            opcion1 = int.Parse(Console.ReadLine());
                            

                            switch (opcion1)
                            {
                                case 1:
                                    Console.WriteLine("\nBIENVENIDO AL PROGRAMA CAPTURA DE NOMBRE\n");
                                    Console.WriteLine("\nIngrese su nombre\n");
                                    string nombre = Console.ReadLine();
                                    Console.WriteLine($"Hola " + nombre + "");
                                    break;
                                case 2:
                                    Console.WriteLine("\nVolviendo al menú principal...");
                                    
                                    
                                    break;
                                default:
                                    Console.WriteLine("\nOBCION INVALIDA");
                                    break;
                            }

                            break;
                        case 2:
                            int opcion2;
                            Console.WriteLine("\nSeguro que desea sumar dos numeros (marca (1) si o marca (2) si quiere volver atras)");
                            opcion2 = int.Parse(Console.ReadLine());

                            switch (opcion2)
                            {
                                case 1:
                                    int numero1, numero2;
                                    Console.WriteLine("\nBIENVENIDO AL PROGRAMA QUE SUMA DOS NUMEROS\n");
                                    Console.WriteLine("\nIngrese el primer numero\n");
                                    numero1 = int.Parse(Console.ReadLine());
                                    Console.WriteLine("\nIngrese el segundo numero\n");
                                    numero2 = int.Parse(Console.ReadLine());

                                    int resultado = numero1 + numero2;
                                    Console.WriteLine($" El resultado es: " + numero1 + " + " + numero2 + " = " + resultado + "");
                                    break;
                                case 2:
                                    Console.WriteLine("\nVolviendo al menú principal...");
                                   
                                    break;
                                default:
                                    Console.WriteLine("\nOBCION INVALIDA");
                                    break;
                            }
                            break;
                        case 3:
                            int opcion3;
                            Console.WriteLine("\nSeguro que desea cerrar el programa (marca (1) si o marca (2) si quiere volver atras)");
                            opcion3 = int.Parse(Console.ReadLine());
                            switch (opcion3)
                            {
                                case 1:
                                    Console.WriteLine("\n prsione cualquier tecla para cerrar el programa");
                                    Console.ReadKey(true);
                                    continuar = false;
                                    break;
                                case 2:
                                    Console.WriteLine("\nVolviendo al menú principal...");
                                    
                                    break;
                                default:
                                    Console.WriteLine("\nOBCION INVALIDA");
                                    break;
                            }
                            break;
                    }
                    
                
            } while (continuar);
        }
    }
}
