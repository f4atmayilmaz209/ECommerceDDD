# 📘 Domain-Driven Design (DDD)

Bu proje, yazılım geliştirme sürecinde **Domain-Driven Design (DDD)** yaklaşımını temel alır.

DDD, Eric Evans tarafından ortaya konmuş ve *Domain-Driven Design: Tackling Complexity in the Heart of Software* kitabı ile literatüre kazandırılmıştır.

---

## 🎯 Amaç

Bu projenin amacı:

- İş kurallarını merkeze almak
- Domain modelini zenginleştirmek
- Katmanlı ve sürdürülebilir bir mimari oluşturmak
- Büyük ve karmaşık sistemleri yönetilebilir hale getirmek

---

## 🧠 Domain-Driven Design Nedir?

Domain-Driven Design:

- İş alanını (Domain) merkeze koyar
- Davranış odaklı modelleme yapar
- İş kurallarını domain içinde korur
- Tutarlılık sınırları (Aggregate) tanımlar
- Teknik detayları domain’den izole eder

DDD bir framework değil, bir tasarım yaklaşımıdır.

---

## 🏗 Proje Mimarisi
src/
├── Project.Domain
├── Project.Application
├── Project.Infrastructure
└── Project.API

Bağımlılık yönü:
API → Application → Domain
Infrastructure → Domain

> Domain katmanı diğer katmanlara bağımlı değildir.


## 📦 Katmanlar

### 🧩 Domain

- Entity
- Value Object
- Aggregate
- Domain Event
- Repository arayüzleri

İş kuralları burada yer alır.

---

### 🧠 Application

- Use case’ler
- Command / Query handler’lar
- DTO’lar

Domain’i orkestre eder. İş kuralı içermez.

---

### 🗄 Infrastructure

- Veritabanı implementasyonları
- ORM (EF Core vb.)
- Dış servis entegrasyonları
- Messaging

Domain katmanına bağımlıdır.

---

### 🌐 API

- Controller
- Middleware
- Authentication
- Request/Response modelleri

İş mantığı içermez.

---

## 🏛 Temel Kavramlar

### Entity
Kimliği olan ve zaman içinde değişebilen nesne.

### Value Object
Kimliği olmayan, değeri ile tanımlanan immutable nesne.

### Aggregate
Tutarlılık sınırı. Dış dünya sadece Aggregate Root ile iletişim kurar.

### Repository
Aggregate’leri saklamak için kullanılan soyutlama.

### Bounded Context
Büyük sistemlerin ayrı domain modellerine bölünmesi.

---

## ⚖ DDD vs Geleneksel CRUD

| Geleneksel | DDD |
|------------|------|
| Veri odaklı | Davranış odaklı |
| Service merkezli | Domain merkezli |
| Public setter | Encapsulation |
| Tablo bazlı | İş bazlı |

---

## 🎯 Ne Zaman Kullanılır?

✔ Karmaşık iş kuralları varsa  
✔ Uzun ömürlü sistemlerde  
✔ Kurumsal projelerde  
✔ Büyük ekip çalışmalarında  

---

## 🚫 Ne Zaman Kullanılmaz?

❌ Basit CRUD uygulamalarda  
❌ Küçük admin panellerde  
❌ Hızlı MVP projelerde  

---

## 🧠 Temel İlke

> Veriyi değil, davranışı modelle.  
> Tabloları değil, iş kurallarını tasarla.  
> Domain’i merkeze koy.

---

## 📌 Sonuç

Bu proje:

- Domain odaklıdır
- Encapsulation uygular
- Katmanlar arası bağımlılığı kontrol eder
- İş mantığını güvenli şekilde korur


