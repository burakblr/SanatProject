using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Sanat.MvcWebUI.Entity
{
    public class DataInitializer:DropCreateDatabaseIfModelChanges<DataContext>
    {
        protected override void Seed(DataContext context)
        {
            var kategoriler = new List<Category>()
            {
                new Category(){ Name = "Naturel", Description = "Naturel ürünleri"},
                new Category(){ Name = "Soyut", Description = "Soyut ürünleri"},
                new Category(){ Name = "Figuratif", Description = "Figuratif ürünleri"},
                new Category(){ Name = "Nu", Description = "Nu ürünleri"},
                new Category(){ Name = "Portre", Description = "Portre  ürünleri"}
            };

            foreach (var kategori in kategoriler)
            {
                context.Categories.Add(kategori);
            }
            context.SaveChanges();

            var urunler = new List<Product>()
            {
                new Product(){ Name = "NatrelTablo!",Description = "2004 yılında Bilgi Edinme Kanunu gereği İBB’ye başvuran Avcan, İBB tarafından yayınlanan “İzmir Büyükşehir Belediyesi Resim Koleksiyonu” isimli kitapta resimleri basılı olan 28 yerli ve yabancı ressama ait toplam 33 değerli tablonun başka belediyelere verildiğine dair duyumları olduğunu, belirtilerek bu tabloların şu an itibariyle belediyeye ait demirbaş kayıtlarında ve koruması altında olup olmadığının bildirilmesini ister.", Price =1200 , Stock =500 , IsApproved =true , CategoryId = 1,IsHome = true,Image = "1.jpg"},
                new Product(){ Name = "çiviTablo",Description = "Duvarınıza astığınız bir tablo hem sizin ruhunuzu hem de evinizin ruhunu yansıtır.Size güzel enerji yansıtan bir tabloyu duvarınıza asarak dekorasyonunuzu tamamlayabilir ve evinizin kimliğini ortaya çıkarabilirsiniz.Soyut tablolar kişiye özel bir güzellik ve anlam ifade eder.Siz de beğendiğiniz bir soyut tablo ile odanızın şıklığını destekleyebilirsiniz.Duru Sanat orijinal yağlı boya tablo ile her rengi rahatlıkla kombinleyebilir, harika bir etki yaratabilirsiniz..", Price =1200 , Stock =500 , IsApproved =true , CategoryId = 1,IsHome = true,Image = "2.jpg"},
                new Product(){ Name = "Çığlık",Description = "Munch'un başyapıtı Çığlık ın dört versiyonundan biri olan tablo, mayıs ayında Sotheby's Müzayede Evi'nde yapılan açık artırmada 120 milyon dolara satılmıştı. Dört Çığlık tablosundan biri Norveç'teki Ulusal Müze'de, diğer ikisi ise yine Oslo'da yer alan Munch Müzesi'nde bulunuyor..", Price =1200 , Stock =500 , IsApproved =false , CategoryId = 1,IsHome = true,Image = "3.jpg"},
                new Product(){ Name = "YağlıBoya",Description = "Sipariş vermiş olduğunuz yağlı boya soyut yatay kanvas tablonuz askı aparatlı olup duvara asmaya hazırdır.Yağlı boya soyut yatay kanvas tablomuz tamamen el işciliği olup darbeye dayanıklıdır.", Price =1200 , Stock =500 , IsApproved =true , CategoryId = 1,IsHome = true,Image = "4.jpg"},
                new Product(){ Name = "Jackson",Description = "Arttablo için özel olarak üretilmiş “su bazlı italyan koruyucu yüzey” tablolarınızı hem koruyor hem de şık bir görüntü kazandırıyor. Su bazlı koruyucu ile kaplanan tablolarınızı gönül rahatlığı ile tüm mekanlarınızda, ", Price =1200 , Stock =500 , IsApproved =false , CategoryId = 1,Image = "5.jpg"},

                new Product(){ Name = "Duru El Sanat", Price =1200 , Stock =500 , IsApproved =true , CategoryId = 2},
                new Product(){ Name = "Sanatçı",Description = "Kullanmayı çok seveceğiniz ergonomik tasarım Optik vizör, çekiminizi oluşturmanıza ve tahmin etmenize olanak tanıyarak her zaman anın arkasındaki duyguyu yakalamak için hazır olmanızı sağlar. Sezgisel kullanımlı kullanıcı dostu kontrolleri ve görüntüyü incelemek için 7,5 cm'lik (3 inç) geniş LCD ekranıyla EOS 1200D'yi kullanması çok keyiflidir.", Price =4500 , Stock =1200 , IsApproved =true , CategoryId = 2,IsHome = true,Image = "6.jpg"},
                new Product(){ Name = " Soyut Yağlı Boya Sanat Kanvas Tablo",Description = "Kullanmayı çok seveceğiniz ergonomik tasarım Optik vizör, çekiminizi oluşturmanıza ve tahmin etmenize olanak tanıyarak her zaman anın arkasındaki duyguyu yakalamak için hazır olmanızı sağlar. Sezgisel kullanımlı kullanıcı dostu kontrolleri ve görüntüyü incelemek için 7,5 cm'lik (3 inç) geniş LCD ekranıyla EOS 1200D'yi kullanması çok keyiflidir.", Price =3400 , Stock =0 , IsApproved =false , CategoryId = 2,IsHome = true,Image = "7.jpg"},
                new Product(){ Name = " Akdeniz Manzarası",Description = "Kullanmayı çok seveceğiniz ergonomik tasarım Optik vizör, çekiminizi oluşturmanıza ve tahmin etmenize olanak tanıyarak her zaman anın arkasındaki duyguyu yakalamak için hazır olmanızı sağlar. Sezgisel kullanımlı kullanıcı dostu kontrolleri ve görüntüyü incelemek için 7,5 cm'lik (3 inç) geniş LCD ekranıyla EOS 1200D'yi kullanması çok keyiflidir.", Price =2500 , Stock =600 , IsApproved =true , CategoryId = 2,Image = "8.jpg"},
                new Product(){ Name = "Baykuşlar",Description = "Kullanmayı çok seveceğiniz ergonomik tasarım Optik vizör, çekiminizi oluşturmanıza ve tahmin etmenize olanak tanıyarak her zaman anın arkasındaki duyguyu yakalamak için hazır olmanızı sağlar. Sezgisel kullanımlı kullanıcı dostu kontrolleri ve görüntüyü incelemek için 7,5 cm'lik (3 inç) geniş LCD ekranıyla EOS 1200D'yi kullanması çok keyiflidir.", Price =5200 , Stock =500 , IsApproved =true , CategoryId = 2,Image = "9.jpg"},

                new Product(){ Name = " Çiçekler", Price =1200 , Stock =500 , IsApproved =true , CategoryId = 3,Image = "1.jpg"},
                new Product(){ Name = " Halstatt",Description = "Set içerisinde 3 adet fırça, her numara için belirlenmiş boya seti ve numaralandırılmış 30x40cm boyutlarında kanvas boyama tablosu mevcuttur.", Price =5600 , Stock =1200 , IsApproved =true , CategoryId = 3,Image = "10.jpg"},
                new Product(){ Name = " Karanfiller",Description = "Resim yapmayı seviyorsanız kendi emeğiniz ile bir ustanın elinden çıkmış yağlı boya bir tablo yapmak isterseniz veya sevdikleriniz için unutulmaz bir hediye arıyorsanız bu set tam size göre.", Price =3400 , Stock =0 , IsApproved =false , CategoryId =3,IsHome = true,Image = "11.jpg"},
                new Product(){ Name = "Kiraz Çiçekleri",Description = "Resimlerde göründüğü şekilde numaralandırılmış kanvasda belirtilen numaraları yine aynı numara ile numaralandırılmış boyalar ile boyayarak kendi tablonuzu kendiniz boyayın. ", Price =2500 , Stock =600 , IsApproved =true , CategoryId = 3,IsHome = true,Image = "12.jpg"},
                new Product(){ Name = "Renkli Kedi",Description = "Her boya değişiminde fırçaları su ile temizleyip kullanın.", Price =5200 , Stock =500 , IsApproved =true , CategoryId = 3,Image = "1.jpg"},

               
            };

            foreach (var urun in urunler)
            {
                context.Products.Add(urun);
            }

            context.SaveChanges();

            base.Seed(context);
        }
    }
}