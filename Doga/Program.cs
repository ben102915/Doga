using System.Data;

namespace Doga
{
    internal class Program
    {
        static Random random = new Random();
        static string[] huto_elemek = new string[10];
        static int[] szamok = new int[10];



        static void FeltoltEgyediekkel(int min, int max)
        {



            for (int i = 0; i < szamok.Length; i++)
            {
                szamok[i] = random.Next(min, max);


            }

            foreach (var item in szamok)
            {
                Console.WriteLine(item + " ");
            }


        }


        static void HutoElemekFeltoltese()
        {
            huto_elemek[0] = "tej";
            huto_elemek[1] = "sajt";
            huto_elemek[2] = "vaj";
            huto_elemek[3] = "joghurt";
            huto_elemek[4] = "";
            huto_elemek[5] = "kolbász";
            huto_elemek[6] = "tojás";
            huto_elemek[7] = "zöldség";
            huto_elemek[8] = "alma";
            huto_elemek[9] = "";
        }

        static int Takarit()
        {

            int seged = 0;
            for (int i = 0; i < huto_elemek.Length; i++)
            {
                if (huto_elemek[i] != "")
                {
                    huto_elemek[seged] = huto_elemek[i];
                    seged++;
                }
                //if (huto_elemek[i] == "")
                //{
                //    huto_elemek[i] = "";
                //}



            }
            for (int i = seged; i < huto_elemek.Length; i++)
            {
                huto_elemek[i] = "";
            }
            foreach (var elem in huto_elemek)
            {
                Console.WriteLine(elem + " ");


            }
            return seged;







            //foreach (var item in huto_elemek)
            //{
            //    if (item == "")
            //    {
            //        huto_elemek.
            //    }
            //}

        }

        static int KeresEtel(string etelNeve)
        {




            foreach (var item in huto_elemek)
            {
                int index = Array.IndexOf(huto_elemek, item);
                if (item == etelNeve)
                {
                    Console.WriteLine($"Van {etelNeve} a hutoben");
                    return index + 1;
                }

            }
            return 0;
        }

        static void Maganhangzo()
        {
            string maganhangzok = "aáeéiíoóöőuúüű";

            for (int i = 0; i < huto_elemek.Length; i++)
            {
                if (huto_elemek[i] != "")
                {


                    if (maganhangzok.Contains(huto_elemek[i][0]))
                    {
                        Console.WriteLine($"A {huto_elemek[i]} magánhangzoval kezdodik");

                    }

                }
            }
        }
        static void Main(string[] args)
        {

            HutoElemekFeltoltese();
            int darab = Takarit();
            //FeltoltEgyediekkel(1,10);
            Console.WriteLine($" A hutoben {darab} elem van");

            int index = KeresEtel("tej");
            if (index != 0)
            {
                Console.WriteLine($"A keresett etel a(z) {index} elso elem");

            }
            else
            {
                Console.WriteLine("A keresett etel nincs a hutoben");
            }
            Maganhangzo();





        }
    }
}
