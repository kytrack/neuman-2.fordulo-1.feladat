namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1. feladat
            //a)
            string szam = "1";
            for (int i = 0; i < 21; i++)
            {
                string szorzat = "";
                foreach (char szamjegy in szam.ToString())
                {
                    int eredmeny = int.Parse(szamjegy.ToString())*2;
                    szorzat += eredmeny;
                }

                Console.WriteLine($"{i + 1}. elem: {szam}");

                szam = szorzat;

            }
            //21. elem:  1681684816816848424848168168481681684842484842421242484842484816816848168168484248481681684816816



            //b)
            int keresettkezodertek = 0;

            for (int i = 10; i < 100; i++)
            {
                string probaszam = i.ToString();
                for (int l = 0; l < 30; l++)
                {
                  
                    if (probaszam.Substring(Math.Max(0, probaszam.Length - 27)) == "216816212162121681684816816")
                    {
                        keresettkezodertek = i;
                        Console.WriteLine("probaszam:" + i);
                    }

                    string szorzat2 = "";
                    foreach (char szamjegy in probaszam.ToString())
                    {
                        int eredmeny2 = int.Parse(szamjegy.ToString()) * 2;
                        szorzat2 += eredmeny2;
                    }

                    probaszam = szorzat2;

                }

            }
            //21 a legkisebb

            //c)

            string kezdoc = "11";
            int ossz = 0;
            for (int i = 0; i < 31; i++)
            {
                foreach (char szamjegy in kezdoc.ToString())
                {
                    ossz += int.Parse(szamjegy.ToString());
                }
                Console.WriteLine(i + 1 + $"elem: {kezdoc}");
                kezdoc +=ossz;
                ossz = 0;
                
            }

            //31. elem: 11248162328384962707791101103107115122127137148161169185199218229242250257271
        }
    }
}