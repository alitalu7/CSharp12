

Metodlar metodlar = new Metodlar();
metodlar.Yaz("deneme1");
metodlar.Yaz("deneme1", "deneme2");


class Metodlar
{
    public void Yaz(string c1)
    {
        Console.WriteLine("Tek değişkenli metod çalıştı.." + c1);
    }

    public void Yaz(string c1, string c2)
    {
        Console.WriteLine("İki değişkenli metod çalıştı.." + c1 + " " + c2);
    }
}