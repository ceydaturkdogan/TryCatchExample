

try
{
    Console.WriteLine("Lütfen karesini almak istediğiniz sayıyı giriniz");

    int number = Convert.ToInt32(Console.ReadLine());

    double square=Math.Pow(2, number);

    Console.WriteLine($"Sonuç: {square}");
}

catch
{
    throw new Exception("Geçersiz giriş! Lütfen bir sayı giriniz.");
}