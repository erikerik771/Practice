namespace Practice
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //--------------------
            //Variabile / Constante
            //--------------------

            const int constanta = 12; // Constanta este o valoare care nu se poate schimba este read only

            int variabila = 13; // Variabilele sunt folosite pentru a stoca date. Acestea isi pot schimba valoarea pe parcursul programului.
            var variabila2 = 14; // Se poate folosi keywordul var in loc de tipul de date iar variabila va fi de tipul datei de dupa egal.

            // simbolul de = este folosit pentru a da o valoare unei variabile sau constante

            variabila = 1 + 2; //Variabila se poate schimba pe parcurs.
            //constanta = 1 + 2; //Va genera o eroare.


            //---------------------
            //  Data Types
            //---------------------

            //Numere intregi
            int numarIntreg = 12;   //intre -2,147,483,648  si  2,147,483,647
            short numarIntregScurt = 2; //intre -32,768  si  32,767
            byte numarIntregPe8biti = 255; // intre 0 si 255   este cea mai mica valoare numerica poate fi scris pe un byte
            long numarLung = 214;  // intre -9,223,372,036,854,775,808  si  9,223,372,036,854,775,807

            //Numere fractionale
            float zecimala1 = 12.5f;   // 7 cifre dupa virgula
            double zecimala2 = 1234.5d;  // 15 cifre dupa virgula
            decimal zecimala3 = 514325.6m; //29 cifre dupa virgula

            //boolean
            bool isTrue = true; // adevarat sau fals

            //caracter
            char caracter = 'a'; // un singur caracter!! mai multe caractere formeaza un string. se pune intre '' si nu "".

            //string
            string propozitie = "12gadfhgadfhadfhadfghjgfsnfdgsndfgnjkljkln;vbgfsh j;kbfbhtkslhiudfsf"; // string e un sir de caractere, care se pune intre ""
            string escape = "\" \n \t \\"; //pentru a avea caractere speciale intr-un string se foloseste \ in fata caracterelor. Pentru " , new line, tab si \.
            string interpolare = $"{propozitie} {escape}"; // pentru a folosi variabile in mijlocul stringului se foloseste $ in fata stringului, iar variabilele se pun intre {}.
            string concat = propozitie + escape; // adunarea la stringuri face ca cele doua stringuri sa urmeze unul dupa celalalt. Se concateneaza intr-un singur string.

            //useful functions cu stringuri
            int literaX = propozitie.IndexOf("2"); // functia IndexOf() va returna pozitia stringului introdus ca si parametru. Daca sunt mai multe aparitii va lua doar prima pozitie. 
            char literaDeLaPozitie = propozitie.ElementAt(literaX); // Asemanator cu IndexOf() dar invers. Va returna litera de la pozitia data (int) ca si parametru.
            string substring = propozitie.Substring(literaX, 20);// Substring va crea un string nou care incepe de la pozitia data si cu lungimea data ca si al doilea parametru.
            int lungimeString = propozitie.Length; // Length este o proprietate care aduce numarul de caractere din string.
            bool isEmpty = string.IsNullOrEmpty(propozitie); // IsNullOrEmpty verifica daca stringul este null sau este un string gol
            string propozitieFaraSpatii = propozitie.Trim(); // Trim() va sterge spatiile de la inceputul si sfarsitul stringului si va crea un string nou
            string litereMici = propozitie.ToLower(); // ToLower() va converti toate caracterele din string in litere mici si va crea un string nou
            string litereMari = propozitie.ToUpper(); // ToUpper() va converti toate caracterele din string in litere mari si va crea un string nou
            string propozitiaSchimbata = propozitie.Replace("x", "y"); // Replace va schimba caracterele date ca si primul parametru cu caracterele date ca si al doilea si va crea un string nou
            string[] propozitii = propozitie.Split(' '); // Split() va imparte stringul intr-un array de stringuri, la fiecare aparitie a caracterului dat ca si parametru stringul va fi taiat.

            //-------------
            //Operatori
            //-------------

            // simbolul de = este folosit pentru a da o valoare unei variabile sau constante. = -> Assignment

            //Operatori matematici
            //Se pot folosi atat pentru numere de genul 1 2 3 5.4 cat si pentru variabile/constante care contin acele numere

            var adunare = 1 + 1; // + e folosit pentru adunare
            var scadere = 2 - 1; // - e folosit pentru scadere
            var inmultire = 2 * 2; // * e folosit pentru inmultire
            var impartire = 4 / 2; // / e folosit pentru impartire
            var rest = 4 % 3; // % e folosit pentru a returna restul unei impartiri

            //Pentru a asigna unei variabile aceeas valoare adunata cu inca una se pot folosi operatori de incrementare
            adunare++; // va adauga +1 la variabila adunare
            scadere--; // va scadea -1 din variabila scadere

            adunare = adunare + 3; // adauga + 3 la variabila adunare
            adunare += 3; // va adauga +3 la variabila adunare acelas lucru ca ^ mai sus
            scadere -= 3; // va scadea -3 din variabila scadere
            inmultire *= 2; // va inmulti cu 2 variabila inmultire
            impartire /= 2; // va imparti cu 2 variabila impartire

            //Operatori logici
            //Acesti operatori vor returna tot timpul tipul de date bool ( true/false )

            bool isEqual = 2 == 2; // variabila isEqual va primi valoarea checkului 2 == 2 care se uita daca 2 este egal cu 2. isEqual in cazul asta va fi true
            bool isLower = 2 < 1; // Pentru a compara daca o valoare este mai mica sau mai mare decat cealalta se foloseste > sau <
            bool isHigher = 2 > 1;
            bool isNotEqual = 2 != 2; // opusul lui ==. != verifica daca cele doua valori sunt diferite
            bool isHigherOrEqual = 2 >= 2; // Asemanator cu < si >. Se poate verifica daca o valoare este mai mica sau egala cu cealalta cu <= si >=
            bool isInvers = !isEqual; // operatorul de ! va inversa un boolean din true in fals sau fals in true

            //Aceste checkuri se pot combina cu mai multe folosind && si ||. Si se pot grupa in paranteze () pentru a controla ordinea lor
            bool isEqualAndNotEven = 3 == 3 && 2 % 1 == 0; // va verifica daca 3 este egal cu 3 si daca restul impartirii lui 2 cu 1 este 0. Daca ambele sunt true variabila va fi true
            bool isNotEqualorEven = 3 == 3 || 2 % 1 == 0; // Acelas lucru cu ce e mai sus doar ca va fi true daca una din cele 2 checkuri este true;

            //-------------
            //Conversia tipurilor de date
            //-------------
            string numarCaSiString = "5321";

            int numarConvertit = Convert.ToInt32(numarCaSiString); // va incerca sa converteasca variabila in int. Poate functiona si pe bool sau alte tipuri nu doar string
            numarConvertit = int.Parse(numarCaSiString); // va incerca sa converteasca stringul la un numar. Poate arunca eroare
            int.TryParse(numarCaSiString, out numarConvertit); // va incerca sa converteasca stringul la un numar. In cazul in care e eroare va pune default value

            //se poate converti explicit tipuri de date mai mari la tipuri mai mici
            double numarCuVirgula = 3.14;
            int numarCuVirgulaConvertit = (int)numarCuVirgula; // Va incerca sa converteasca double la int. Cifrele de dupa virgula se vor pierde

            //-------------
            //Citirea de la consola
            //-------------

            Console.WriteLine("Hello World!!!"); // Va scrie in consola stringul dat ca si parametru. Va pune pe randuri separat
            Console.Write("Hello 2");//Va scrie in consola dar nu le va pune pe randuri separat.
            var input = Console.ReadLine(); // Va astepta ca utilizatorul sa introduca ceva. Asteapta pana apare new line (enter). Tot timpul va returna un string

            //-------------
            //Control flow
            //-------------

            //If else
            if (2 == 3)
            {
                //Va executa codul daca conditia este corecta
            }
            else if (5 == 1)
            {
                //Va executa codul daca prima conditie este falsa si aceasta este adevarata
            }
            else
            {
                //va executa codul daca niciuna din cele de sus nu sunt adevarate
            }

            //Switch

            var zi = 4;
            switch (zi)  //expresia pe care o verifica
            {
                case 1:
                    // va executa codul de aici daca zi este egal cu 1
                    break;
                case 2:
                    // va executa codul de aici daca zi este egal cu 2
                    break;
                case 4:
                    // va executa codul de aici daca zi este egal cu 4
                    break;
                default:
                    // va executa codul de aici daca zi nu este egal cu niciunul din cazuri
                    break;
            }

            //shorthand if
            // shorthand if este un if scris pe o singura linie care va verifica checkul de dinaintea lui ?.
            // Va asigna valoarea de dupa ? daca este true sau va pune valoarea de dupa : daca este fals.
            string ziCaString = zi == 5 ? "vineri" : "alta zi";

            //-------------
            //Array
            //-------------

            string[] masini = { "Honda", "Mazda", "Mitsubishi", "Toyota", "Nissan" }; // un array este o colectie de mai multe valori de acelas tip. In cazul asta este un array de stringuri

            int[] numere = { 1, 2, 3, 4, 5 }; // array de numere

            var arrayDeBool = new bool[] { false, true, true, 2 == 1 }; // initializarea unui array cu var keyword. Array de boolean

            bool isToyota = masini[3] == "Toyota"; // pentru a accesa elementele unui array se pune numarul de la elementul dorit intre []. Indexarea se face de la 0. [3] va fi al 4 lea element

            numere[3] = 12; // pentru schimbarea unei valori din array se acceseaza elementul si pur si simplu i se assigneaza valoarea.

            var nrElemente = numere.Length;// asemanator cu string.Length. Va returna numarul de elemente din array

            //multidimensional array
            int[,] matrice = { { 1, 3 }, { 3, 4 } }; //va crea un array de 2 dimensiuni

            //asemanator se pot crea matrici pe mai multe dimensiuni adaugand cate o virgula de ex string[,,] va crea un array 3D de stringuri

            matrice[1, 0] = 1; // va schimba cifra 3 (primul element din al doilea grup) si ii va da valoarea 1;


            //-------------
            //Loop
            //-------------

            //bucla while va executa un cod pana cand conditia este adevarata
            while (ziCaString == "vineri")
            {
                //do something
            }

            //bucla do while este asemanator cu while, diferenta este ca va executa codul cel putin odata. va executa prima data si dupa face checkul.
            do
            {
                //do something
            } while (ziCaString == "joi");


            //for se foloseste atunci cand stim exact de cate ori vrem sa iteram printr-o bucata de cod.
            //are 3 statementuri. primul se executa odata la inceput, al doilea este conditia, al treilea se executa la fiecare iteratie

            for (int i = 0; i < 100; i++)
            {
                //statement 1 va crea o variabila si ii da valoarea 0, al doilea verifica daca i < 100, al treilea il incrementeaza dupa fiecare loop cu 1.

                if(i == 30)
                {
                    break; //break se foloseste pentru a iesi din bucla. In acest caz for loopul se va executa de 30 ori pentru ca celelalte 70 nu apuca inainte de break.
                }

                //do something 100 times;
            }

            //foreach este folosit pentru a itera prin elementele unui array.

            foreach(int numar in numere)
            {
                //Note numere este array ce am definit mai sus la capitolul cu array.

                if(numar == 0)
                {
                    continue; // continue se foloseste pentru a trece la urmatoarea iteratie fara a mai continua restul codului ce urmeaza din acest punct.
                }

                //do something with that number
            }

            //------------------------------------------------------------------------- Did not teach--------------------------------------------------------------------------
            //-----------
            //Metode
            //-----------

            int maxNumar = GetMaximum(2, 5); //maxNumar va primi valoarea returnata de metoda. apelarea metodei se face numele metodei urmat de valori care se trimit ca parametru

            LogToConsole("heeei");//metoda se poate apela la fel ca celalalt singura diferenta e ca nu se face intr-un assignment pentru ca nu e un tip de data.

            int maxNumarDin3Valori = GetMaximum(2, 3, 5); //va apela a doua versiune a metodei cu valorile 2, 3, 5 si default value 0.
        }

        //declara o metoda care are return type int si ia doi parametrii number 1 si number 2
        private static int GetMaximum(int number1, int number2)
        {
            return number1 > number2 ? number1 : number2; // return va iesi din metoda si va da valoarea returnata.
        }

        //Overload al aceleias metode asta ia 3 sau 4 parametri, number4 este optional daca nu are valoare default va fi 0.
        private static int GetMaximum(int number1, int number2, int number3, int number4 = 0)
        {
            if (number1 > number2 && number1 > number3)
            {
                return number1;
            }
            else if (number2 > number1 && number2 > number3)
            {
                return number2;
            }
            else if (number3 > number1 && number3 > number1)
            {
                return number3;
            }
            else
            {
                return number4;
            }
        }

        //Aceasta metoda nu are niciun tip de return. Este de tipul void ceea ce inseamna ca executa un cod fara a aduce inapoi o valoare.
        private static void LogToConsole(string Message)
        {
            Console.WriteLine(Message); // Aceasta metoda va loga in consola mesajul primit ca si parametru si nu va aduce inapoi nici o valoare dupa.
        }
    }
}