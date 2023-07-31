while (true)
{
    int dosa = 2;
    int pahala = 40;
    int utangPuasa = 1;

    Console.WriteLine("Jumlah dosa " + dosa);
    Console.WriteLine("Jumlah pahala " + pahala);
    Console.WriteLine("Jumlah utang puasa " + utangPuasa);

    if ((dosa + utangPuasa) > pahala)
    {
        Console.WriteLine("Welcome to Hell");
    }
    else
    {
        Console.WriteLine("Mantap ya akhi");
    }

    await Task.Delay(500);
}

