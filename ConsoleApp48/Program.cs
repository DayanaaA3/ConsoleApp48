using System;
//Crea un juego en el que la computadora genere un número aleatorio entre 1 y 99 y el usuario tenga que adivinarlo. Proporciona pistas como "más alto" o "más bajo" después de cada intento. Máximo se permiten 5 intentos.
//ELABORADO POR DAYANA INTRIAGO
class Program
{
    static void Main()
    {
        Random random = new Random();
        int numeroAleatorio = random.Next(1, 100);
        int intentosMaximos = 5;
        Console.WriteLine("Bienvenido al juego de adivinanza.");
        Console.WriteLine($"Intenta adivinar el número entre 1 y 99. Tienes { intentosMaximos} intentos.");
    for (int intento = 1; intento <= intentosMaximos; intento++)
        {
            Console.Write($"Intento {intento}: Ingrese su adivinanza: ");
            if (int.TryParse(Console.ReadLine(), out int intentoUsuario))
            {
                if (intentoUsuario == numeroAleatorio)
                {
                    Console.WriteLine("¡Felicidades! ¡Has adivinado el número!");
                break;
                }
                else
                {
                    if (intentoUsuario < numeroAleatorio)
                    {
                        Console.WriteLine("Más alto. Intenta de nuevo.");
                    }
                    else
                    {
                        Console.WriteLine("Más bajo. Intenta de nuevo.");
                    }
                }
            }
            else
            {
                Console.WriteLine("Entrada no válida. Por favor, ingrese un número entero.");
                intento--;
            }
            if (intento == intentosMaximos)
            {
                Console.WriteLine($"Lo siento, has alcanzado el máximo de { intentosMaximos} intentos.El número correcto era { numeroAleatorio}.");
            }
        }
    }
}