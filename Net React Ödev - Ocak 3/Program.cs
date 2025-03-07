
// --------------  Kullanıcıdan bir sayı alıp tek mi çift mi olduğunu bulan bir C# programı yazın

Console.Write("Lütfen bir sayi giriniz : ");
int sayi = Convert.ToInt32(Console.ReadLine());

if (sayi % 2 == 0)
{
    Console.WriteLine("Girmiş olduğunuz sayı ÇİFT bir sayıdır");
}
else
    Console.WriteLine("Girmiş olduğunuz sayı TEK bir sayıdır");






// --------------------------- Girilen bir sayının pozitif, negatif veya sıfır olup olmadığını belirleyen bir program yazın. 

/*Console.Write("Lütfen bir sayı giriniz :");
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
} */