namespace tombokszamokkal
{
    internal class Program
    {
        static int[] tomb = new int[15];
        static Random r = new Random();

        static void Feltolt()
        {
            for (int i = 0; i < tomb.Length; i++)
            {
                tomb[i] = r.Next(-20,21);
            }
            foreach (int item in tomb)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }

        static void Osszegzes()
        {
            int osszeg = 0;
            foreach (int item in tomb)
            {
                osszeg += item;
            }
            Console.WriteLine($"A számok összege: {osszeg}");
        }

        static void Megszamlalas()
        {
            int db = 0;
            foreach (int item in tomb)
            {
                if (item < 0)
                {
                    db++;
                }
            }
            Console.WriteLine($"A negatív számok száma: {db} ");
        }
        static void Eldontes()
        {
            int i = 0;
            while (i < tomb.Length && tomb[i] != 0)
            {
                i++;
            }
            if (i < tomb.Length)
            {
                Console.WriteLine("Van 0 a tombben.");
            }
            else
            {
                Console.WriteLine("Nincs 0 a tombben");
            }
        }
        static void Kereses()
        {
            int keresett = 0;
            int i = 0;
            while (i < tomb.Length && tomb[i] != keresett)
            {
                i++;
            }
            if (i < tomb.Length)
            {
                Console.WriteLine($"A keresett szám a {i}. indexen található.");

            }
            else
            {
                Console.WriteLine("A keresett szám nem található a tömbben.");
            }
        }

        static void Kivalasztas()
        {
            tomb[8] = 10;
            int i =0;
            while (tomb[i] !=10)
            {
                i++;
            }
            Console.WriteLine($"A keresett szám az {i+1}. helyen található. ");
        }
        static void Main(string[] args)
        {
            Feltolt();
            Osszegzes();
            Megszamlalas();
            Eldontes();
        }
    }
}
