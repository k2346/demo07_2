using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LottoApp
{
    class Lotto

    {
       
        public void Arvo ()
            {
            Random rand = new Random();
            int numero = rand.Next(1, 39 + 1);
            int numero1 = rand.Next(1, 39 + 1);
            int numero2 = rand.Next(1, 39 + 1);
            int numero3 = rand.Next(1, 39 + 1);
            int numero4 = rand.Next(1, 39 + 1);
            int numero5 = rand.Next(1, 39 + 1);
            int numero6 = rand.Next(1, 39 + 1);
            
        }

        public List<int> rivit;


        public Lotto()
        {
            rivit = new List<int>();
        }

        public void Addrivi(int rivi)
        {
            rivit.Add(rivi);
        }

      /*  public void PrintData()
        {
            Console.WriteLine("CD Data: ");
            Console.WriteLine("- Artist: " + Artist);
            Console.WriteLine("- Price: " + Price);
            Console.WriteLine("- Songs: ");


            foreach (int rivi in rivit)
            {
                Console.WriteLine(song.ToString());
            }

        }*/



    }
}
