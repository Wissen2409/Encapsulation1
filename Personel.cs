using System.Security.Cryptography;

public class Personel
{
    //bir nesne içerisindeki üyelerin, dış dünya ile direk bağlantılı olması OOP'ye ters bir durumdur
    // bu durumda, söz konsuu üyere, hem erişmek, hemde değiştirmek anlamında önlerine bazı engeller koymak gerekmektedir.

    // Private  erişim belirleyici : Üyelerin dışarıdan erişimini engeller, ancak aynı sınıf içerisinde erişimi kısıtlamaz
    public int id;
    public string name;

    public string age;

     //Getter metotlar : görevleri sadece nesne içerisindeki üyenin değerini nesne kullanıcısına vermektir
     // hiç bir şekilde nesne içerisindeki değişkeni değiştirme görevi yoktur.
      public int Get_Id(){
        return this.id;
    }
    public string Get_Name(){
        return this.name;
    }
    // aşağıdaki metotlar veriyi değiştirmesi için

    // Setter metotlar :Görevleri sadece, nesne içerisindeki değişkenleri, nesne kullanıcısı tarafından gönderilen
    // parametre ile değiştirmektir. Yani değer atamaktır.
    // setter metotlarıi geriye değer döndürmezler, sadece parametre alırlar ve aldıkları parametreyi nesne değişkenine atarlar

    public void Set_Id(int id){
        this.id = id;
    }
    public void Set_Name(string name){
        this.name = name;
    }
    // yukarıda anlatıtğımız gibi, nesne içerisindeki değişkenleri kapsüllemek OOP'nin önemli bir kuralıdır

    // kapsüllemek iki aşamadan oluşur, 1. üyeyi dış dünyadan erişimini kapatmak
    // bu durumda ya dış dünyadan veri almak zorunda kalırsa ? 
    // bu durum içinde bir çözüm var.
    // aracılar kullanmak !!!

    // Sonuç : değişkeni dış dünyaya kapattık private ile
    // dış dünya ile haberleşmesini bir metot üzerinden yapsk ? ve bu metot içerisinde dış dünyadan gelen verileri
    // kontrol etsek ? 

    // hem erişmesi
    // hemde değiştirmesi gerekiyor

    // aşağıdaki metotlar erişmesi ve okuması için
  


}