// See https://aka.ms/new-console-template for more information
using System.Collections.Generic;
Console.WriteLine("Hello, World!");

//List<T> class



List<int> sayilar = new List<int>();

sayilar.Add(23);
sayilar.Add(10);
sayilar.Add(4);
sayilar.Add(5);
sayilar.Add(92);
sayilar.Add(34);

List<string> renkler = new List<string>();

renkler.Add("Kırmızı");
renkler.Add("Mavi");
renkler.Add("Turuncu");
renkler.Add("Sarı");
renkler.Add("Yeşil");


Console.WriteLine(renkler.Count);
Console.WriteLine(sayilar.Count);


foreach (var sayi in sayilar)
{
    Console.WriteLine(sayi);
}

foreach (var renk in renkler)
{
    Console.WriteLine(renk);
}

sayilar.ForEach(sayi => Console.WriteLine(sayi));
renkler.ForEach(renk => Console.WriteLine(renk));


sayilar.Remove(4);
renkler.Remove("Yeşil");


sayilar.ForEach(sayi => Console.WriteLine(sayi));
renkler.ForEach(renk => Console.WriteLine(renk));

sayilar.RemoveAt(0);
renkler.RemoveAt(1);

sayilar.ForEach(sayi => Console.WriteLine(sayi));
renkler.ForEach(renk => Console.WriteLine(renk));

if (sayilar.Contains(10))
{
    Console.WriteLine("10 listede bulundu.");
}

Console.WriteLine(renkler.BinarySearch("Kırmızı"));

string[] hayvanlar = { "Kedi", "Köpek", "Kuş" };

List<string> hayvanList = new List<string>(hayvanlar);

hayvanList.Clear();

List<Kullanıcılar> kullanıcıList = new List<Kullanıcılar>();
Kullanıcılar kullanıcı1 = new Kullanıcılar();
kullanıcı1.Isim = "kullanıcı";
kullanıcı1.Soyisim = "soyadı";
kullanıcı1.Yas = 26;

Kullanıcılar kullanıcı2 = new Kullanıcılar();
kullanıcı2.Isim = "kullanıcı2";
kullanıcı2.Soyisim = "soyadı2";
kullanıcı2.Yas = 36;

kullanıcıList.Add(kullanıcı1);
kullanıcıList.Add(kullanıcı2);

List<Kullanıcılar> yeniListe = new List<Kullanıcılar>();

yeniListe.Add(new Kullanıcılar()
{
    Isim = "isim",
    Soyisim = "soyisim",
    Yas = 30
});

foreach (var kullanıcı in kullanıcıList)
{
    Console.WriteLine("Kullanıcı Adı: " + kullanıcı.Isim);
    Console.WriteLine("Kullanıcı Soyadı: " + kullanıcı.Soyisim);
    Console.WriteLine("Kullanıcı Yas: " + kullanıcı.Yas);
}

yeniListe.Clear();


//Console.ReadLine();


public class Kullanıcılar
{
    private string isim;
    private string soyisim;
    private int yas;

    public string Isim
    {
        get => isim; set => isim = value;
        }
    public string Soyisim
    {
        get => soyisim; set => soyisim = value;

}
    public int Yas
    {
        get => yas; set => yas = value;

        }
}
