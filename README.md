# Konsoldan Sayı Girişi ve Hata Yönetimi

Bu uygulama, kullanıcının konsoldan bir sayı girmesini ve girilen sayının karesini hesaplamasını sağlar. Kullanıcıdan alınan girişin sayısal bir değer olup olmadığını kontrol etmek için `try-catch` yapısı kullanılmıştır. 

## Özellikler

- **Sonsuz Döngü**: Kullanıcıdan sürekli veri alınmasını sağlar, doğru bir giriş yapılana kadar döngü devam eder.
- **Hata Yönetimi**:
  - `FormatException`: Kullanıcıdan alınan giriş sayısal değilse, hata yakalanır ve kullanıcıya uygun bir uyarı mesajı gösterilir.
  - `OverflowException`: Kullanıcı çok büyük veya çok küçük bir sayı girerse, bu hata yakalanır ve kullanıcı uyarılır.

## Kullanım

1. Konsoldan bir değer girin.
2. Eğer girdiğiniz değer bir sayı değilse veya çok büyük/küçük bir sayıysa, hata mesajı alırsınız.
3. Geçerli bir sayı girdiğinizde, program bu sayının karesini hesaplar ve sonucu ekrana yazdırır.

## Kod Yapısı

```csharp
{
    // Sonsuz döngü başlat
    while (true)
    {
        try
        {
            Console.Write("Bir değer giriniz: ");
            string deger = Console.ReadLine();
            int sayi = Convert.ToInt32(deger);
            Console.WriteLine("Girdiğiniz Sayının Karesi: " + (sayi * sayi));
            break; // Doğru giriş yapılırsa döngüden çık
        }
        catch (FormatException)
        {
            Console.WriteLine("Lütfen sadece sayı giriniz");
        }
        catch (OverflowException)
        {
            Console.WriteLine("Çok büyük veya çok küçük sayı girişinde bulundunuz.");
        }
    }
}
