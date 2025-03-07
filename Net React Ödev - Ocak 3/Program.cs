Console.Write("Lütfen bir sayı giriniz :");
int sayi1 = Convert.ToInt32(Console.ReadLine());
if (sayi1 < 0)
{
    Console.WriteLine("Girdiğiniz sayı NEGATİFTİR ");

}
else if (sayi1 == 0){
    Console.WriteLine("Girdiğiniz sayı SIFIRDIR ");
}
else if (sayi1 > 0)
{
    Console.WriteLine("Girdiğiniz sayı POZİTİFTİR ");
}