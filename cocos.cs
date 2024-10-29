//using system;
//using system.linq;

//class program
//{
//    static void main(string[] args)
//    {
//        // citirea primei valori întregi
//        console.writeline("introduceti prima valoare (numar intreg):");
//        int primavaloare;
//        while (!int.tryparse(console.readline(), out primavaloare))
//        {
//            console.writeline("valoare invalida! introduceti un numar intreg valid:");
//        }

//        // citirea șirului de caractere și extragerea numerelor întregi
//        console.writeline("introduceti un sir de numere separate prin spatii:");
//        string sirdecaractere = console.readline();

//        // separați și convertiți șirul de numere într-un array de întregi
//        int[] numere = sirdecaractere.split(' ') // separăm șirul în funcție de spații
//                                     .where(x => int.tryparse(x, out _)) // filtrăm doar valorile care pot fi convertite la int
//                                     .select(int.parse) // convertim șirul de caractere în întregi
//                                     .toarray();

//        if (numere.length == 0)
//        {
//            console.writeline("nu ati introdus niciun numar intreg valid!");
//            return;
//        }

//        // calcularea mediei folosind prima valoare și media numerelor din șir
//        var media = (primavaloare + numere.average());

//        // afișarea rezultatului
//        console.writeline($"media aritmetica a valorilor {primavaloare} si a numerelor din sir este: {media}");

//        // așteaptă o acțiune a utilizatorului înainte de a închide programul
//        console.writeline("apasati orice tasta pentru a inchide programul...");
//        console.readkey();  // așteaptă să se apese o tastă
//    }
//}




//using System;
//using System.Collections.Generic;
//using System.IO;

//class Program
//{
//    static void Main(string[] args)
//    {
//        // Listă pentru a stoca numerele prime
//        List<int> numerePrime = new List<int>();

//        // Citirea numerelor de la tastatură
//        CitireValori(numerePrime);

//        // Dacă nu s-a introdus niciun număr prim, afișăm un mesaj și încheiem programul
//        if (numerePrime.Count == 0)
//        {
//            Console.WriteLine("Nu s-au introdus numere prime.");
//        }
//        else
//        {
//            // Traseu absolut către desktop (modifică traseul dacă este nevoie)
//            string filePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "numere_prime.txt");

//            // Scrierea numerelor prime într-un fișier
//            ScriereInFisier(numerePrime, filePath);

//            // Scrierea numerelor prime într-un array și afișarea acestora
//            int[] arrayNumerePrime = numerePrime.ToArray();
//            AfisareArray(arrayNumerePrime);
//        }

//        // Așteaptă o acțiune a utilizatorului înainte de a închide programul
//        Console.WriteLine("Apăsați orice tastă pentru a închide programul...");
//        Console.ReadKey();  // Așteaptă să se apese o tastă
//    }

//    // Funcție care citește valori de la tastatură până la întâlnirea lui 0
//    static void CitireValori(List<int> numerePrime)
//    {
//        int valoare;

//        do
//        {
//            Console.Write("Introduceți un număr întreg pozitiv (0 pentru a încheia): ");
//            while (!int.TryParse(Console.ReadLine(), out valoare) || valoare < 0)
//            {
//                Console.WriteLine("Valoare invalidă! Introduceți un număr întreg pozitiv.");
//            }

//            // Verificăm dacă valoarea este primă
//            if (valoare != 0 && EstePrim(valoare))
//            {
//                numerePrime.Add(valoare); // Adăugăm numărul prim la listă
//            }

//        } while (valoare != 0);
//    }

//    // Funcție care verifică dacă un număr este prim
//    static bool EstePrim(int numar)
//    {
//        if (numar < 2)
//        {
//            return false;
//        }

//        for (int i = 2; i <= Math.Sqrt(numar); i++)
//        {
//            if (numar % i == 0)
//            {
//                return false;
//            }
//        }

//        return true;
//    }

//    // Funcție care scrie numerele prime într-un fișier
//    static void ScriereInFisier(List<int> numerePrime, string numeFisier)
//    {
//        using (StreamWriter writer = new StreamWriter(numeFisier))
//        {
//            foreach (int numar in numerePrime)
//            {
//                writer.WriteLine(numar);
//            }
//        }

//        Console.WriteLine($"Numerele prime au fost scrise în fișierul {numeFisier}.");
//    }

//    // Funcție care afișează conținutul array-ului
//    static void AfisareArray(int[] arrayNumerePrime)
//    {
//        Console.WriteLine("Numerele prime din array sunt:");
//        foreach (int numar in arrayNumerePrime)
//        {
//            Console.WriteLine(numar);
//        }
//    }
//}

static int CmmdcIterativ(int a, int b)
{
    while (b != 0)
    {
        int rest = a % b;
        a = b;
        b = rest;
    }
    return a;
}
