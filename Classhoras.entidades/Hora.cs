namespace Classhoras.entidades
{
    public class Hora
    {
        private int horas;
        private int minutos;
        private int segundos;

        public Hora(int horas, int minutos, int segundos)
        {
            if (!Validar(horas,minutos,segundos))
            {
                throw new ArgumentException("Ingresa bien la hora pelotudo");
            }
                this.horas = horas;
                this.minutos = minutos;
                this.segundos = segundos;
        }

        public Hora(int horas, int minutos):this(horas, minutos , 0)
        { 
        }

        public Hora(int horas):this(horas,0)
        { 
            
        }

        public override string ToString()
        {
            return $"{horas.ToString().PadLeft(2,'0')}:" +
                $"{minutos.ToString().PadLeft(2, '0')}:" +
                $"{segundos.ToString().PadLeft(2, '0')}";
        }

        private bool Validar(int horas, int minutos , int segundos) 
        {
            return (horas >= 0 && horas <= 23) &&
                (minutos >= 0 && minutos <= 59) &&
                (segundos >= 0 && segundos <= 59);
        }

        public static implicit operator int (Hora horas) 
        {
            return horas.segundos + (horas.minutos) * 60 + 
                (horas.horas * 60) * 60;
        }
    }
}
