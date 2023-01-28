namespace Practice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numarIntreg = 12;
            short numarIntregScurt = 2;
            long numarLung = 214;

            float numar = 12.5f;
            double numar2 = 1234.5d;
            decimal numar3 = 514325.6m;

            bool isTrue = true;

            char caracter = 'a';

            string propozitie = "12gadfhgadfhadfhadfghjgfsnfdgsndfgnjkljkln;vbgfsh j;kbfbhtkslhiudfsf";

            numarIntreg = 12 + 3;

            const float pi = 3.14f;

            numarIntreg = 3;
            var x = (numarIntreg == 2 && numar <= 1) || isTrue == false ? 12 : 4;

            int.TryParse(propozitie, out int returnValue);

            var e = propozitie.Length;
            
            var f = propozitie.IndexOf("fsn");
            var ss = propozitie.Substring(f, 5);

            var unu = "4gfadsg";
            var doi = "bfdabf \" \n \t \\  ";

            var trei = $"{unu} gadfsagbdf {doi}";

            Console.WriteLine(trei);

            var input = Console.ReadLine();

            if (true)
            {
                
            }
            else if (false)
            {

            }
            else
            {

            }

            switch(propozitie)
            {
                case "gaa":
                    break;

                default:
                    break;
            }

            while(numarIntreg<100)
            {
                Console.WriteLine("aa");
                numarIntreg++;
            }

            do
            {
                Console.WriteLine(numarIntreg);
            } while (numarIntreg < 1);

            for(var i = 0; i < 100; i++)
            {
                Console.WriteLine("i is now " + i);
                if (i < 60 && i > 40)
                {
                    continue;
                }
                Console.WriteLine(i);
            }

            string[] animale = { "cal", "caine", "papagal" };

            foreach(var animal in animale)
            {
                Console.WriteLine(animal);
            }
        }
    }
}