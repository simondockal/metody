using System;

namespace MatematikaUtil
{
    public class MatUtil
    {
        static public int Obsahujecifru(string chain, out int pocet)
        {
            char[] znak = new char[chain.Length];
            pocet = 0;
            int soucet = 0;
            for (int i = 0; i < chain.Length; i++)
            {
                znak[i] = chain[i];
                if (znak[i] >= '0' && znak[i] <= '9')
                {
                    pocet++;
                    if (znak[i] % 2 != 0)
                    {
                        soucet += znak[i] - 48;
                    }
                }
            }
            return soucet;
        }
        static public bool Prvocislo(int cislo)
        {
            bool prvcislo = true;
            if (cislo == 1 || cislo > 2 && cislo % 2 == 0) prvcislo = false;
            else
            {
                for (int del = 3; del <= Math.Sqrt(cislo) && prvcislo; del += 2)
                {
                    if (cislo % del == 0) prvcislo = false;
                }
            }
            return prvcislo;
        }
    }
}
