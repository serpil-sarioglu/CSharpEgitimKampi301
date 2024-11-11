using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpEgitimKampi301.EntityLayer.Concrete
{
    public class Category
    {        
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
        public int CategoryStatus { get; set; }
        public List<Product> Products { get; set; }

    }
}
#region Field-Variable-Property Kavramları
//Fields (Alanlar)
//Bir sınıf veya yapı içinde tanımlanan değişkenlerdir. Genellikle bir nesnenin durumunu temsil ederler ve sınıfın parçasıdır.
//Field'lar genellikle private veya protected olarak tanımlanır ve dışarıdan direkt erişimi sınırlamak için kullanılır.


//Properties(Özellikler)
//Bir sınıfın dışından veriye erişimi kontrol etmek için kullanılan bir yapı. Genellikle private bir field ile ilişkilidir ve değer almak (get) ve değer atamak (set) için kullanılan yöntemler içerir.
//Veri doğrulama, izleme veya hesaplama gibi işlemleri gerçekleştirmek için kullanılabilir.


//Variables (Değişkenler)
//Genel bir terimdir ve programın herhangi bir yerinde, herhangi bir veri türünde kullanılabilen, bir değeri saklamak için kullanılan isimlendirilmiş bellek alanını ifade eder.
//Değişkenler, bir fonksiyon içinde, bir döngüde veya bir if bloğu içinde de tanımlanabilir.
//global-yerel değişkenler...
#endregion

/*Sınıflar Arası İlişkiler
 *Kola -> İçecek Kategorisi
 *İçecek Kategorisi -> Kola, Gazoz, Meyve Suyu, ...
*/