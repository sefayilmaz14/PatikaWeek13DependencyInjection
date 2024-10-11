# PatikaWeek13DependencyInjection

Bu proje, **Patika.dev** platformundaki 13. hafta ödevi olarak geliştirilen **Bağımlılık Enjeksiyonu (Dependency Injection)** konusunu ele almaktadır. Projede, sınıflar arası bağımlılıkların daha sürdürülebilir ve kolay yönetilebilir olması için dependency injection (DI) mimarisi kullanılmıştır.

## 📋 İçindekiler

- [Kurulum](#kurulum)
- [Kullanım](#kullanım)
- [Proje Yapısı](#proje-yapısı)
- [Kullanılan Teknolojiler](#kullanılan-teknolojiler)


## 🚀 Kurulum

Projeyi kendi bilgisayarınıza kurmak için şu adımları izleyin:

1. Repozitory'yi klonlayın:
      git clone https://github.com/sefayilmaz14/PatikaWeek13DependencyInjection.git

2. Projeyi Visual Studio ile açın:
PatikaWeek13DependencyInjection.sln dosyasını açın.

3. Gerekli NuGet paketlerini yükleyin:
Visual Studio'da çözüm üzerine sağ tıklayıp NuGet Paketlerini Geri Yükle seçeneğine tıklayın.

4. Uygulamayı başlatın:
Visual Studio üzerinde F5 tuşuna basarak projeyi çalıştırabilirsiniz.

## 💻 Kullanım
Bu projede Bağımlılık Enjeksiyonu (Dependency Injection) kullanılarak sınıflar arasındaki bağımlılıklar daha temiz bir şekilde yönetilmiştir. Uygulamada bir öğretmen yönetim sistemi bulunmaktadır. Aşağıdaki yöntemle öğretmen bilgilerini alabilirsiniz:

## 🗂️ Proje Yapısı
Proje yapısı şu şekildedir:

Controllers: API isteklerini yöneten sınıflar.
Services: DI ile kullanmak üzere hizmet sınıfları.
Models: Veritabanı tablolarını temsil eden sınıflar.
Program.cs: Proje giriş noktası ve DI yapılandırması.

## 🛠️ Kullanılan Teknolojiler
.NET Core
Dependency Injection (DI)
C#
Visual Studio
