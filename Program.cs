
// OOP'nin ilk konusu olan encapsulation(kapsüllemek) direk olarak nesneler ve bu nesnelerin içerisindeki
// değişkenler ile ilgili bir konudur.

// Temel olarak nesneler içerisindeki değişkenlerin, kontrolsüz bir şekilde dış dünyaya açılmasını 
// engellemek amacıyla düşünülmüştür.

Personel p = new Personel();

// Encapsulation ile nesne üretelim 
// nesne içerisindeki değişkenlere direk erişim 
/*
p.id=1;
p.name="Ahmet"
*/

// nesne içerisindeki değişkenlere kapsüllenmiş erişim
p.Set_Id(1);
p.Set_Name("Ahmet");


// Nesne içerisndeki değerleri ekrana yazdıralım

Console.WriteLine("Id : {0}",p.Get_Id());
Console.WriteLine("Ad : {0}",p.Get_Name());


Personel p2 = new Personel();
p2.id=2;
p2.name="Kerem";
p2.age=

// 
