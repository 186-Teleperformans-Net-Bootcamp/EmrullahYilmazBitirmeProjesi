#Teleperformance .Net Bootcamp Bitirme Proesi

Bu proje Patika.dev & Teleperformance ortaklığıyla düzenlenen bootcamp bitirme projesidir.

### Kullanılan Teknolojiler:
:heavy_check_mark: .Net 6.0 frameworkü ile Asp.Net Core Web API ve ConsoleApp kullanıldı.
:heavy_check_mark: Onion Architecture kullanıldı.
:heavy_check_mark: Postman ile API test edildi.
:heavy_check_mark: API'nin dışardan kullanılabilmesi için token(JWT) bazlı bir yapı geliştirildi.
:heavy_check_mark: Event fırlatma işlemi için RabbitMQ kullanıldı.
:heavy_check_mark: Veritabanı işlemleri için EntityFrameworkCore, MSSQL ve MongoDb kullanıldı.
:heavy_check_mark: Projede Unit ve Entegrasyon testi yazıldı.
:heavy_check_mark: InMemoryCache kullanıldı.

## Proje İçeriği:
- Özetle kullanıcıların almayı planladıkları ürünleri kaydedip takibini yapabilecekleri bir Web API.
- Kullanıcı kaydı, girişi ve doğrulama işlemleri yapılabilmekte.
- Kategori, başlık, ürünler(isim,miktar,tip), oluşturulma tarihi, tamamlanma tarihi ve tamamlanma durumu parametreleri Shopping List'i oluşturuyor.
- Get, Post, Delete, Patch, Put gibi HTTP metodları ile listeler ve ürünler için işlemler yapılabilmekte.

## Proje Kullanımı ve Kurulumu

- Projeyi indirmek için :
```
    git clone https://github.com/186-Teleperformans-Net-Bootcamp/EmrullahYilmazBitirmeProjesi.git
```

- Veritabanı oluşturmak için package manager konsolunda default project kısmında `BitirmeProjesi.Persistence` seçili olmalıdır. Ardından :
```c
    update-database
```

- Appsettings.json içindeki verilerin kendi bilgisayarınıza göre dizayn edilmesi lazım
```c
    {
    "ConnectionStrings": {
        "Default": "SQL Server Connection String;"
    },
    "MongoConnectionStrings": {
        "ConnectionString": "MongoDb Connection String",
        "DatabaseName": "Veritabanı adı",
        "ShoppingListName": "ShoppingLists"
    },
    "Logging": {
        "LogLevel": {
            "Default": "Information",
            "Microsoft.AspNetCore": "Warning"
        }
    },
    "AllowedHosts": "*",
    "JWT": {
        "Audience": "http://google.com",
        "Issuer": "http://google.com",
        "Token": "This is my supper secret key for jwt"
    }
}
```

- Kullanımı için projemizi derledikten sonra çalıştırıyoruz.


	