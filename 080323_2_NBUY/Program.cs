using System;

namespace _080323_2_NBUY
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ogretmen ogretmen1 = new ogretmen();
            ogretmen1.ogretmenad = "osman";

            ogrenci ogrenci1 = new ogrenci();
            ogrenci1.ad = "ayşe";
            ogrenci1.soyad = "ballı";

            kitap kitap1 = new kitap();
            kitap1.kitapad = "AYŞEM";

            emanet(ogretmen1, ogrenci1, kitap1);

            static void emanet(ogretmen m, ogrenci n, kitap c)
            {

                Console.WriteLine(m.ogretmenad + " öğretmen " + c.kitapad + " adlı kitabı " + n.ad + " " + n.soyad + " adlı öğrenciye verdi...");

            }

        }
    }
}
