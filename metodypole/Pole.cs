using System;
using System.Windows.Forms;

namespace poleUtil
{
    public class Pole
    {

        /// <summary>
        /// generuje nahodne cisla
        /// </summary>
        /// <param name="n">delka pole</param>
        /// <param name="from">od jakeho cisla zacina generovani</param>
        /// <param name="to">u jakeho cisla konci generovani</param>
        /// <returns>vraci pole nahodnych prvku int</returns>
        static public int[] generate(int n, int from = 1, int to = 100)
        {

            int[] pole = new int[n];
            Random rr = new Random();
            for (int i = 0; i < n; i++)
            {
                pole[i] = rr.Next(from, to);
            }
            return pole;
        }
        /// <summary>
        /// metoda na zobrazeni prvku do listboxu
        /// </summary>
        /// <param name="list">listbox do ktereho se ukladaji prvky</param>
        /// <param name="pole">pole prvku</param>
        static public void zobrazeni(ListBox list, int[] pole)
        {
            list.Items.Clear();
            for (int i = 0; i < pole.Length; i++)
            {
                list.Items.Add(pole[i]);
            }
        }

        /// <summary>
        /// pocet sudych cisel a soucet lichych cisel
        /// </summary>
        /// <param name="pole">pole prvku</param>
        /// <param name="n">delka pole</param>
        /// <param name="lich">vraci soucet lichych cisel</param>
        /// <returns>vraci soucet lichych cisel</returns>
        static public int pocets(int[] pole, out int lich)
        {
            int pocet = 0;
            lich = 0;
            for (int i = 0; i < pole.Length; i++)
            {
                if (pole[i] % 2 == 0)
                {
                    pocet += pole[i];
                }
                else
                {
                    lich++;
                }
            }
            return pocet;
        }

        /// <summary>
        /// zjistuje jestli je pole roustouci
        /// </summary>
        /// <param name="pole">pole prvku</param>
        /// <returns>vraci jestli je pole rostouci nebo ne</returns>
        static public bool rostouci(int[] pole)
        {

            for (int i = 0; i < pole.Length - 1; i++)
            {
                if (pole[i] > pole[i + 1])
                {
                    return false;
                }
            }
            return true;
        }

        /// <summary>
        /// vynenuje nejvetsi prvek s poslednim
        /// </summary>
        /// <param name="pole">pole prvku</param>
        static public void vymena(int[] pole)
        {
            int max = int.MinValue;
            int pozice = 0;
            for (int i = 0; i < pole.Length; i++)
            {
                if (pole[i] > max)
                {
                    max = pole[i];
                    pozice = i;
                }
            }
            pole[pozice] = pole[pole.Length - 1];
            pole[pole.Length - 1] = max;
        }

        static public int[] nulovani(int[] pole,int x)
        {
            int umocneno = 1;
            for(int i=0;i<pole.Length;i++)
            {
                if(pole[i]<0)
                {
                    pole[i] = 0;
                }
                else
                {
                    for (int y = 0; y < x; y++)
                    {
                        umocneno *=pole[i];
                    }
                    pole[i] = umocneno;
                }
            }
            return pole;
        }
    }
}
