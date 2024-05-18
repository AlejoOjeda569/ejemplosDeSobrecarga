namespace ClassSumador.Entidades
{
    public class Sumador
    {
        private int cantidadSumas;
        public int Getcantidad() => cantidadSumas;

        public Sumador(int cantidad)
        {
            cantidadSumas = cantidad;
        }

        public Sumador():this(0)
        { 

        }

        public int Sumar(int n1, int n2) 
        {
            cantidadSumas++;
            return n1 + n2;
        }

        public string Sumar(string s1 , string s2) 
        {
            cantidadSumas++;
            return s1+ s2;
        }

        public static bool operator==(Sumador a , Sumador b)
        { 
            return a.Getcantidad() == b.Getcantidad();
        }
        public static bool operator !=(Sumador a, Sumador b)
        {
            return !(a == b);
        }

        public override bool Equals(object? obj)
        {
            if(!(obj is Sumador) || (obj is null))
            {
                return false;
            }
            return this.cantidadSumas==((Sumador)obj).cantidadSumas;
        }

        public override int GetHashCode()
        {
            unchecked
            {
                int hast = 17;
                hast += 23 * this.cantidadSumas.GetHashCode();
                return hast;
            }
        }

        public static explicit operator int (Sumador sumador) 
        {
            return sumador.cantidadSumas;
        }
    }
}
