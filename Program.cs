string playAgain = "E";

while (playAgain == "E") { 

Console.WriteLine("1. Sayıyı Giriniz: ");
int sayi1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("2. Sayıyı Giriniz: ");
int sayi2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("1) Topla ");
Console.WriteLine("2) Çıkar ");
Console.WriteLine("3) Çarp ");
Console.WriteLine("4) Böl ");
Console.WriteLine("5) Çıkış ");


string choice = Console.ReadLine();

switch(choice){

    case "1":
        Console.WriteLine("Toplam = " + (sayi1 + sayi2));
        break;

    case "2":
        Console.WriteLine("Fark = " + (sayi1 - sayi2));
        break;

    case "3":
        Console.WriteLine("Çarpım = "+ (sayi1 * sayi2));
        break;

    case "4":
        if(sayi2==0){
            Console.WriteLine("Sıfıra Bölünemez");
        }
        else
        Console.WriteLine("Bölüm = " + (sayi1 / sayi2));
        break;

    case "5":
            playAgain = "H";
            Console.WriteLine("Programdan Çıkılıyor.");
        break;

    default:
        Console.WriteLine("Geçersiz seçim.");
        break;
}

    if (choice != "5")
    {
        Console.Write("Tekrar oynamak için E, çıkmak için H: ");
        playAgain = Console.ReadLine();
    }

}

Console.WriteLine("Program bitti.");