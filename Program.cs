using System;
using System.Linq;
using System.Collections.Generic;

namespace testRpd_Exer2
{
    public class Program
    {

        public static int[] GetItens(int[] pInt, int PtotCiruclo)
        {
            int[] vReturn = new int[3];
            int i = 0;
            List<int> vList = new List<int>();
            foreach (var lin in pInt)
            {
                vList.Add(lin);
            }
            vList = OrdernarItens(vList, PtotCiruclo);
            foreach (var reg in vList)
            {
                vReturn[i] = reg;
                i += 1;
            }

            return vReturn;
        }

        public static List<int> OrdernarItens(List<int> pList, int pTotCirculo)
        {
            var workd = pList;
            var Return = new List<int>();
            int TotItem = 1;
            while (TotItem <= pTotCirculo)
            {
                int number1 = workd[2];
                int number2 = workd[0];
                int number3 = workd[1];
                workd = new List<int>();
                workd.Add(number1);
                workd.Add(number2);
                workd.Add(number3);
                TotItem += 1;
            }
            Return = workd;

            return Return;
        }
        static void Main(string[] args)
        {
            int[] vNumero = new int[3];
            int vVoltas = 2;
            vNumero[0] = 1;
            vNumero[1] = 2;
            vNumero[2] = 3;

            //vVoltas = Convert.ToInt32(Console.ReadKey(true));
            Console.WriteLine(GetItens(vNumero, vVoltas));
        }

    }
}
