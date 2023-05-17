using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace scheduling_algorithms
{
    class Program
    {
        static void Main(string[] args)
        {
            int m, n, i, j;
            int[] zamanvorod = new int[10];
            int[] zamanservice = new int[10];
            int[] zamankhorojcpu = new int[10];
            int[] zamanvorodcpu = new int[10];
            int[] wt = new int[10];
            int[] at = new int[10];
            float awt = 0, aat = 0;
            Console.Write("lotfan tedade farayand ha ra vared konid= ");
            n = int.Parse(Console.ReadLine());
            for (i = 1; i <= n; i++)
            {
                Console.Write("\n lotfan zamane vorod farayand {0} ra vared konid= ", i);
                zamanvorod[i] = int.Parse(Console.ReadLine());
                Console.Write("\n lotfan zamane service farayand {0} ra vared konid= ",i);
                zamanservice[i] = int.Parse(Console.ReadLine());
            }
            Console.Write("\n algoritm ha :\n\n 1 ra vared konid ta fcfs namayesh dade shavad \n 2 ra vared konid ta sjf namayesh dade shavad \n 3 ra vared konid ta srt namayesh dade shavad \n 4 ra vared konid ta RR namayesh dade shavad \n 5 ra vared konid ta MLQ namayesh dade shavad \n");
            Console.Write("\n");
            m = int.Parse(Console.ReadLine());
            if (m == 1)
            {
                int temp, a = 0;
                for (i = 1; i <= n - 1; i++)
                    for (j = i + 1; j <= n; j++)
                        if (zamanvorod[i] > zamanvorod[j])
                        {
                            temp = zamanvorod[i];
                            zamanvorod[i] = zamanvorod[j];
                            zamanvorod[j] = temp;
                            temp = zamanservice[i];
                            zamanservice[i] = zamanservice[j];
                            zamanservice[j] = temp;
                        }
                a = zamanvorod[1];
                for (i = 1; i <= n; i++)
                {
                    zamanvorodcpu[i] = a;
                    zamankhorojcpu[i] = zamanvorodcpu[i] + zamanservice[i];
                    a = zamankhorojcpu[i];
                    wt[i] = zamanvorodcpu[i] - zamanvorod[i];
                    at[i] = zamankhorojcpu[i] - zamanvorod[i];
                    aat += at[i];
                    awt += wt[i];
                }
                aat = aat / n;
                awt = awt / n;
                string s = "";
                Console.WriteLine("\tzamane vorod---zamane service---zamane entezar---zamane bazgasht\n");
                for (i = 1; i <= n; i++)
                    s += "\t\t" +zamanvorod[i].ToString() + "\t\t" + zamanservice[i].ToString() + "\t\t" + wt[i].ToString() + "\t\t" + at[i].ToString() + "\n";
                Console.WriteLine(s);
                Console.WriteLine("miangine zamane entezar hast= {0}\nmiangine zamane bazgasht hast= {1}", awt, aat);
                Console.Read();

            }
        }

    }
}
