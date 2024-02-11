using System;

class Program
{
    static void Main(string[] args)
    {
        bool salir = false;

        do
        {
            Console.WriteLine("\nMenú:");
            Console.WriteLine("1. Muestre su nombre completo por pantalla");
            Console.WriteLine("2. Muestre por pantalla de manera separadas sus nombres y apellidos");
            Console.WriteLine("3. Pregunte y capture su nombre y muestre por pantalla un saludo personalizado");
            Console.WriteLine("4. Capture dos números y muestre por pantalla la multiplicación dichos números");
            Console.WriteLine("5. Pida 3 números y muestre por pantalla el resultado de la suma del primero y el tercero dividido entre el segundo");
            Console.WriteLine("6. Pida 5 números y muestre por pantalla la sumatoria y el promedio");
            Console.WriteLine("7. Muestre por pantalla la tabla del 12 del 1 al 12");
            Console.WriteLine("8. Salir");

            Console.Write("Seleccione una opción: ");
            string opcion = Console.ReadLine();

            switch (opcion)
            {

                //Muestre su nombre completo por pantalla
                case "1":
                    Console.WriteLine("1. Kyle Andre Delgado Castillo");
                    break;

                //Muestre por pantalla de manera separadas su nombre y apellidos
                case "2":
                    string nombres = "Kyle Andre";
                    string apellidos = "Delgado Castillo";
                    Console.WriteLine(nombres);
                    Console.WriteLine(apellidos);
            
                    break;

                //Pregunte y capture su nombre y muestre por pantalla un saludo personalizado
                case "3":
                    Console.Write("3. Por favor, ingrese su nombre: ");
                    string nombreUsuario = Console.ReadLine();
                    Console.WriteLine("   Hola, " + nombreUsuario + ", ¿Cómo estás?.");
                    break;

                //Captura 2 numeros y muestra por pantalla
                case "4":
                    Console.Write("4. Por favor, ingrese el primer número: ");
                    double numero1 = Convert.ToDouble(Console.ReadLine());
                    Console.Write("   Por favor, ingrese el segundo número: ");
                    double numero2 = Convert.ToDouble(Console.ReadLine());
                    double resultadoMultiplicacion = numero1 * numero2;
                    Console.WriteLine("   El resultado de la multiplicación es: " + resultadoMultiplicacion);
                    break;

                //Pida 3 números y muestre por pantalla el resultado de la suma del primero y el tercero dividido entre el segundo
                case "5":
                    Console.Write("5. Por favor, ingrese el primer número: ");
                    double num1 = Convert.ToDouble(Console.ReadLine());
                    Console.Write("   Por favor, ingrese el segundo número: ");
                    double num2 = Convert.ToDouble(Console.ReadLine());
                    Console.Write("   Por favor, ingrese el tercer número: ");
                    double num3 = Convert.ToDouble(Console.ReadLine());
                    double resultadoDivision = (num1 + num3) / num2;
                    Console.WriteLine("   El resultado es: " + resultadoDivision);
                    break;

                //Pida 5 números y muestre por pantalla la sumatoria y el promedio
                case "6":
                    Console.Write("6. Por favor, ingrese el primer número: ");
                    double numeroA = Convert.ToDouble(Console.ReadLine());
                    Console.Write("   Ahora ingrese el segundo número: ");
                    double numeroB = Convert.ToDouble(Console.ReadLine());
                    Console.Write("   Ahora ingrese el tercer número: ");
                    double numeroC = Convert.ToDouble(Console.ReadLine());
                    Console.Write("   Ahora ingrese el cuarto número: ");
                    double numeroD = Convert.ToDouble(Console.ReadLine());
                    Console.Write("   Finalmente ingrese el quinto número: ");
                    double numeroE = Convert.ToDouble(Console.ReadLine());
                    double sumatoria = numeroA + numeroB + numeroC + numeroD + numeroE;
                    double promedio = sumatoria / 5;
                    Console.WriteLine("   La sumatoria de los números es: " + sumatoria);
                    Console.WriteLine("   El promedio de los números es: " + promedio);
                    break;

                //Muestre por pantalla la tabla del 12 del 1 al 12
                case "7":
                    Console.WriteLine("7. Tabla del 12:");
                    for (int i = 1; i <= 12; i++)
                    {
                        Console.WriteLine("   12 * " + i + " = " + (12 * i));
                    }
                    break;

                //Cerrar la consola
                case "8":
                    Console.WriteLine("¡Hasta luego!");
                    salir = true;
                    break;
                default:
                    Console.WriteLine("Opción inválida. Por favor, seleccione una opción válida.");
                    break;
            }

            if (!salir)
            {
                Console.Write("\n¿Quieres cerrar la consola? (s/n): ");
                string cerrarConsola = Console.ReadLine();
                if (cerrarConsola.ToLower() == "s")
                {
                    Console.WriteLine("¡Hasta luego!");
                    break;
                }
            }
        } while (!salir);
    }
}
