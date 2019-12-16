using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace ConsoleApplication3
{
    class Program
    {
        static string Dizel(double a) //deklaracija povratne metode tipa string koja ima jedan ulazni parametar "a" to je parametar koji ti unosis sa tastature
        {
            double cena = 150; //deklarisanje cene tipa double i njena vrednost je 150(int su ti samo celi brojevi,a double mogu biti i decimalni to uvek skoro pita)
            double racun = 0; // pocetna vrednost racuna je 0
            racun = cena * a; // formula za izracunavanje racuna preuzece cenu iz "double cena *a(kolicina tj litraza)
            string poruka = "Ukupna cena goriva je " + racun; // poruka koja ce se ispisati, ovo +racun je bitno da bi program znao koju vrednost da ispise u poruci
            return poruka; // vracanje vrednosti metode u program
        }
        static string Plin(double a)  ////deklaracija povratne metode tipa string koja ima jedan ulazni parametar isto kao gore napisano
        {
            double cena = 75; // opet sve isto 
            double racun = 0;//
            racun = cena * a;//
            string poruka = "Ukupna cena vaseg plina je " + racun;//
            return poruka;//
        }
        static void Main(string[] args)
        {
            int niz = 0;//pocetna vrednost tipa int postavljena na nulu
            string gorivo = ""; // ocekuje sta ces upisati u program dal DIZEL ILI PLIN
            double litar = 0; // pocetna vrednost kolicine postavljena na 0
            Console.WriteLine("Benzinska stanica Grkovic Petrol");// ovu poruku ce ispisati program
            Console.WriteLine("Ukoliko zelite da izracunate cenu Dizela unesite DIZEL,a ako zelite Plin unesite PLIN");// ovo takodje
            gorivo = (Console.ReadLine());//program ucitava potrebne komponente tj izbor koji ti je dole opisan u if-u

            if (gorivo == "DIZEL")// ako je izbor DIZEL ovo se izvrsava
            {
                Console.WriteLine("Unesite koliko litara Dizela je izdato");// ispis poruke,na koje korisnik unosi podatak
                litar = Convert.ToDouble(Console.ReadLine());//konvertuje se u double ako slucajno bude decimalan broj jer bi int ispisao samo ceo zaokruzen
                Console.WriteLine("Na koliko racuna zelite da vam se ispise poruka");// izbor koliko puta hoces da ti ispise racun
                for (int y = 0; y < 1; y++)//for petlja koja se izvrsava sve dok uslov y<1 ne bude ispunjen
                {
                    try// provera unosa da li ces uneti slovo,ako da ispisuje gresku,ako ne tj broj nastavlja se izvrsavanje programa normalno
                    {
                        niz = Convert.ToInt32(Console.ReadLine());
                    }
                    catch
                    {
                        Console.WriteLine("Greska!Uneto je slovo,a ne broj");
                        y--;//brojac oduzima 1 pokusaj tj ispisuje ti ovu gore poruku ako nakon toga uneses broj nastavlja normalno,a ako ne opet ispisuje poruku i tako u krug sve dok ne uneses broj
                    }
                }
                int[] x = new int[niz];//kreiranje niza x 
                for (int i = 0; i < niz; i++)//for petlja sve dok se ne ispuni i<niz
                {
                    Console.WriteLine(Dizel(litar));//poziv,tj ucitavanje podataka potrebnih za proracun

                }
                Console.ReadLine();//ucitava podatke
            }
            else if (gorivo == "PLIN")//Ako izaberes PLIN izvrsava se sledece
            {
                Console.WriteLine("Unesite izdatu kolicinu Plina");//ispis poruke
                litar = Convert.ToDouble(Console.ReadLine());//opet konverzija u double zbog decimalnih br
                Console.WriteLine("Na koliko racuna zelite da vam se ispise poruka?");//ispis poruke
                niz = Convert.ToInt32(Console.ReadLine());//niz u int konvertovanje 
                int[] x = new int[niz];//kreiranje niza x
                for (int i = 0; i < niz; i++)// for sve dok se ne izvrsi i<niz
                {
                    Console.WriteLine(Plin(litar));//isto sve kao gore...
                    Console.ReadLine();
                }
            }
        }
    }
}
