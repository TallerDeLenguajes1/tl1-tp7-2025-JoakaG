using EspacioCalculadora;

Calculadora calculadora = new Calculadora();
string ingresado = "1";
double num;
do
{
    Console.WriteLine("Ingresar operacion ('sumar', 'restar', 'multiplicar', 'dividir', 'limpiar') o 'salir' para terminar");
    ingresado = Console.ReadLine().ToLower().Trim();
    if (ingresado != "salir")
    {
        if (ingresado == "limpiar")
        {
            calculadora.Limpiar();
            Console.WriteLine("Limpiado con éxito");
        }
        else
        {
            Console.WriteLine($"Ingrese número a {ingresado}");
            Console.Write($"A {calculadora.Resultado} {ingresado} ");
            if (double.TryParse(Console.ReadLine(), out num))
            {

                switch (ingresado)
                {
                    case "sumar":
                        calculadora.Sumar(num);
                        break;
                    case "restar":
                        calculadora.Restar(num);
                        break;
                    case "multiplicar":
                        calculadora.Multiplicar(num);
                        break;
                    case "dividir":
                        calculadora.Dividir(num);
                        break;
                    default:
                        Console.WriteLine($"Operacion '{ingresado}' inexistente, vuelva a intentarlo");
                        continue;
                }
                Console.WriteLine($"Resultado: {calculadora.Resultado}");
            }
            else
            {
                Console.WriteLine("Numero ingresado incompatible");
            }
        }
    }

} while (ingresado != "salir");
Console.Write("Finalizando programa...");
