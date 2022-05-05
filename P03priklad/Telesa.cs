using System;

namespace P03priklad
{
    public class Telesa
    {
        static public int Objem(int a, int b, int c, out double telesnauhlopricka)
        {

            telesnauhlopricka = Math.Sqrt(a * a + c * c + b * b);

            int objem = a * b * c;
            return objem;
        }

        static public int Objem(int a, out double telesnauhlopricka)
        {   
             telesnauhlopricka =a* Math.Sqrt(3);
          
            int objem = a * a * a;
            return objem;
        }

        static public int Obsah(int a, int b, out double uhlopricka)
        {
            int obsah;
            obsah = a * b;
            uhlopricka = Math.Sqrt(a * a + b * b);
            return obsah;
        }

        static public int Obsah(int a, out double uhlopricka)
        {
            int obsah;
            obsah = a * a;
            uhlopricka = a*Math.Sqrt(2);
            return obsah;
        }
    }
}
