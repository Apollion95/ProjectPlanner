using System;

namespace ProjectPlanner
{
    class Projekt
    {
        public string Nazwa { get; set; }
        public DateOnly ObecnyStart { get; set; }
        public DateOnly ObecnyKoniec { get; set; }
        internal class Program
        {
            static void Main(string[] args)
            {
               // int zgoda = 0; 
                List<Projekt> obecne = new List<Projekt>();
                obecne.Add(new Projekt { Nazwa = "Testowy1", ObecnyStart = new DateOnly(2020, 01, 02), ObecnyKoniec = new DateOnly(2020, 01, 06) });
              //  obecne.Add(new Projekt { Nazwa = "Testowy2", ObecnyStart = new DateOnly(2020, 05, 10), ObecnyKoniec = new DateOnly(2020, 05, 15) });
                DateOnly projektStart = new DateOnly(2020, 04, 8);
                DateOnly projektKoniec = new DateOnly(2020, 04, 9);
                int dlugosc = obecne.Count;
                for (int i = 0; i < dlugosc; i++)
                {
                    if (obecne[i].ObecnyStart < projektStart && obecne[i].ObecnyKoniec > projektKoniec) { Console.WriteLine("Poczatek i koniec nachodzi na obecny projekt " + obecne[i].Nazwa); }
                    if (obecne[i].ObecnyStart > projektStart && obecne[i].ObecnyKoniec < projektKoniec) { Console.WriteLine("projekt nachodzi na obecny " + obecne[i].Nazwa); }
                    if(obecne[i].ObecnyStart > projektStart && obecne[i].ObecnyKoniec > projektKoniec) { Console.WriteLine("Poczatek ok, koniec nachodzi na obecny projekt " + obecne[i].Nazwa); }
                    if (obecne[i].ObecnyStart < projektStart && obecne[i].ObecnyKoniec < projektKoniec) { Console.WriteLine("Poczatek nachodzi na obecny projekt, koniec ok " + obecne[i].Nazwa); }
                    if (obecne[i].ObecnyStart < projektKoniec || obecne[i].ObecnyKoniec < projektStart) { Console.WriteLine("zgoda  " + obecne[i].Nazwa); }
                }
                
            }
        }
    }
}