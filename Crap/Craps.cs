namespace CasoJuegosCraps;

public class Craps
{
    // Crear el generador de números aleatorios
    private Random numerosAleatorios = new Random();

    private enum NombreDados
    {
        DOS_UNO = 2,
        TRES = 3,
        SIETE = 7,
        ONCE = 11,
        DOCE = 12
    }

    private enum Estado
    {
        CONTINUA,
        GANA,
        PIERDE
    }

    public void jugar()
    {
        Estado estadojuego = Estado.CONTINUA;
        int miPunto = 0;
        int sumadeDados = lanzarDados();

        switch ((NombreDados)sumadeDados)
        {
            case NombreDados.SIETE:
            case NombreDados.ONCE:
                estadojuego = Estado.GANA;
                break;

            case NombreDados.DOS_UNO:
            case NombreDados.TRES:
            case NombreDados.DOCE:
                estadojuego = Estado.PIERDE;
                break;

            default:
                estadojuego = Estado.CONTINUA;
                miPunto = sumadeDados;
                Console.WriteLine($"El punto es {miPunto}");
                break;
        }

        while (estadojuego == Estado.CONTINUA)
        {
            sumadeDados = lanzarDados();

            if (sumadeDados == miPunto)
            {
                estadojuego = Estado.GANA;
            }
            else if (sumadeDados == (int)NombreDados.SIETE)
            {
                estadojuego = Estado.PIERDE;
            }
        }

        if (estadojuego == Estado.GANA)
        {
            Console.WriteLine("El jugador gana");
        }
        else
        {
            Console.WriteLine("El jugador pierde");
        }
    }

    public int lanzarDados()
    {
        int dado1 = numerosAleatorios.Next(1, 7);
        int dado2 = numerosAleatorios.Next(1, 7);
        int suma = dado1 + dado2;

        Console.WriteLine($"El jugador lanzó {dado1} + {dado2} = {suma}");

        return suma;
    }
}