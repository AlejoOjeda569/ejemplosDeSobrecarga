using Classhoras.entidades;

namespace ejercicioSobreCarga00
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {

                var horas = new Hora(15,00,00);
                Console.WriteLine(horas.ToString());
                int segundos = horas;
                Console.WriteLine($"La hora anterior equivale a {segundos} segungos");
            }
            catch ( Exception ex)
            {

                Console.WriteLine(ex.Message);
            }
        }

       
    }
}
