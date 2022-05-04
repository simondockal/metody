using System;

namespace vypocet_kvadr_ctverec
{
    public class vypocet_kvadr_ctverec
    {
        public double Obj(int a, int b, int c, out double telesnauhlopricka)
        {
            double uhlopricka;
            double objem;
            uhlopricka = Math.Sqrt(a * a + c * c);
            telesnauhlopricka = Math.Sqrt(uhlopricka * uhlopricka + b * b);

            if (a == b && a == c)
            {
                objem = 6 * (a * a);
            }
            else
            {
                objem = 2 * (a * b + a * c + b * c);
            }
            return objem;
        }

        public int Dvj(int a, int b, out double uhlopricka)
        {
            int nadr = a * a;
            int obsah;


            if (a == b)
            {
                obsah = a * a;
                uhlopricka = Math.Sqrt(a * a + a * a);
            }
            else
            {
                obsah = a * b;
                uhlopricka = Math.Sqrt(a * a + b * b);
            }
            return obsah;
        }
    }
}
