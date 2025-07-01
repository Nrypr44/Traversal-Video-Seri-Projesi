#  TraversalMini - Tur Rezervasyon Web Uygulaması

Bu proje, [Murat Yücedağ](https://www.youtube.com/playlist?list=PLKnjBHu2xXNMK5MBogdXmsXVi3K_eEZT5)'ın TraversalMini/Core video serisi temel alınarak geliştirilmiştir. .NET 8, Entity Framework Core ve MSSQL kullanılarak **katmanlı mimari** yapısıyla oluşturulmuştur. Uygulama, kullanıcıların tur rezervasyonu yapabildiği, admin paneli üzerinden içeriklerin yönetilebildiği bir sistem sunar.

---

## Özellikler

- Turların listelenmesi, eklenmesi, silinmesi ve güncellenmesi
-  Kullanıcı kayıt ve giriş sistemi
-  Tur rezervasyonu oluşturma
-  Rol bazlı yetkilendirme (Admin / Kullanıcı)
-  İletişim formu
-  Admin panelinde istatistik gösterimi
-  AutoMapper ve FluentValidation ile yapılandırılmış kod
-  Katmanlı mimari (Core, DataAccess, Entity, TraversalCoreProje)
-  Bootstrap ile responsive kullanıcı arayüzü
-  SignalR ile şehir bazlı son 10 gün kullanıcı sayısı grafiği oluşturma
---

##  Proje Mimarisi

Proje katmanlı mimari prensiplerine uygun olarak aşağıdaki yapıda organize edilmiştir:
TraversalMini/
├── BusinessLayer/ --> Servisler ve iş mantığı
├── DataAccessLayer/ --> Repository ve Entity Framework işlemleri
├── EntityLayer/ --> Entity sınıfları
├── TraversalProjeCore/ --> ASP.NET Core MVC kullanıcı arayüzü
├── DTOLayer/ --> Veri transfer nesneleri
└── SignalRApi --> Yapay, şehir bazlı kullanıcı sayısı oluşturan sunucu
└── SignalRApi --> İstemci

##  Kullanılan Teknolojiler

.NET 8 & ASP.NET Core MVC: Modern ve performanslı web uygulamaları geliştirmek için kullanıldı. Katmanlı mimariyi destekleyerek sürdürülebilir kod yazımı sağladı.

Entity Framework Core: MSSQL veritabanı ile etkileşim için ORM (Object-Relational Mapping) aracı olarak kullanıldı; Code-First yaklaşımı ile veritabanı yönetimi sağlandı.

MSSQL: Güvenilir ve güçlü bir ilişkisel veritabanı olarak veri saklama işlemlerinde tercih edildi.

AutoMapper: Farklı katmanlar arasında veri transferi sırasında dönüşümleri kolaylaştırmak ve kod tekrarını önlemek için kullanıldı.

FluentValidation: Formlar ve modeller için kapsamlı ve esnek doğrulama kuralları tanımlamayı sağladı, böylece veri tutarlılığı artırıldı.

Bootstrap: Kullanıcı arayüzünü responsive ve mobil uyumlu yapmak için tercih edildi, modern ve estetik tasarım sağladı.

SignalR: Şehir bazlı site ziyaretlerini son 10 gün için anlık grafiğe dökmek için kullanıldı.
