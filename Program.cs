using System;

namespace Tarea
{
    internal class Program
    {
        private static int pago;
        private static int costo;
        private static int recibo;
        private static int I;
        private static int II;
        private static int V;
        private static int X;
        private static int XX;
        private static int L;
        private static int C;
        private static int D;

        private static void Main(string[] args)
        {
            Random random = new Random();
            pago = random.Next(4000, 5000);
            costo = random.Next(1000, 2000);

            recibo = pago - costo;
            Console.WriteLine("El pago es de " + pago);
            Console.WriteLine("El costo es de " + costo);
            Console.WriteLine("El recibo es de " + recibo);

            D = Recibo(500);
            C = Recibo(100);
            L = Recibo(50);
            XX = Recibo(20);
            X = Recibo(10);
            V = Recibo(5);
            II = Recibo(2);
            I = Recibo(1);

            string text = "El vuelto es:" + Vuelto(I, 1) + Vuelto(II, 2) + Vuelto(V, 5) +
                Vuelto(X, 10) + Vuelto(XX, 20) + Vuelto(L, 50) + Vuelto(C, 100) + Vuelto(D, 500);

            Console.WriteLine(text.TrimEnd(',') + ".");
        }

        public static int Recibo(int ammount)
        {
            int i = 0;

            while (recibo >= ammount)
            {
                recibo -= ammount;
                i++;
            }

            return i;
        }

        public static string Vuelto(int ammount, int number)
        {

            if (ammount > 1)
            {
                return " " + ammount + " monedas de " + number + ",";
            }
            else if (ammount == 1)
            {
                return " " + ammount + " moneda de " + number + ",";
            }

            return "";
        }
    }
}
