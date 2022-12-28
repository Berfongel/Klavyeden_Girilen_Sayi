// See https://aka.ms/new-console-template for more information
int sayi1;
Console.WriteLine("Bir sayı giriniz : ");
sayi1 = Convert.ToInt32(Console.ReadLine());

if (0 < sayi1 && sayi1 < 100)
{
    Console.WriteLine("Geçerli sayı ");
}
else
{
    Console.WriteLine("Geçerli sayı değil ");
}
