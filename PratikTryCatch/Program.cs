

internal class Program
{
	private static void Main(string[] args)

	{
		//Sonsuz döngü başlat
		while (true)
		{
			//Hata vermesini beklediğin kodu yaz
			try
			{
				Console.Write("Bir değer giriniz: ");
				string deger = Console.ReadLine();
				int sayi = Convert.ToInt32(deger);
				Console.WriteLine("Giridiğiniz Sayının Karesi: " + (sayi * sayi));
				//Hatasız şekilde çalışdığı zaman break kodu çalışacak ve while döngüsünden çıkmış olduk 
				break;
			}
			//Hataları Yakala ve Mesaj ver
			catch (FormatException )
			{

				Console.WriteLine("Lütfen sadece sayi giriniz");
			}
			catch (OverflowException )
			{
				Console.WriteLine("Çok büyük veya çok küçük sayı girişinde bulundunuz: ");
			}




		}
		
	}
}