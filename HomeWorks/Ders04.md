# Ders 4 — Transform, Vektör Matematiği ve Dönüşler Ödevi

## Amaç
Bu ödevde öğrenciler, Unity’nin temel hareket ve dönüş sistemlerini daha gelişmiş vektör matematiğiyle birleştirerek **hedefi takip eden**, **dönüş limitleri olan** ve **hedefi kaybedince “araştırma” davranışına geçen** bir nesne (kule) oluşturacaklar.

---

## Ödev Açıklaması

Bir kule düşünün:  
- Hedefini gördüğünde ona doğru yavaşça dönecek  
- Hedef belirli bir açı aralığı dışına çıkarsa kule artık dönmeyecek  
- Hedef tamamen kaybolursa kule çevreyi tarayan bir “scan/araştırma” döngüsüne girecek  
- Geri geldiğinde tekrar hedefe dönecek

Bu ödev, **Transform**, **Vector3**, **Quaternion**, **Dot/Cross ürünleri** ve **Lerp/Slerp** kullanımını pekiştirmek içindir.

---

## Beklenen Kazanımlar

Öğrenciler bu ödevle:

- `transform.Translate`, `transform.Rotate`, `transform.LookAt` mantığını anlamalı  
- `Vector2/Vector3` ile yön-vetörü üretme  
- `Dot` ve `Cross` ile açı ilişkilerini hesaplama  
- `normalize`, `clamp` kullanma  
- **Euler açıları** ve **Quaternion** arasındaki farkları kavrama  
- **Lerp/Slerp** ile yumuşak dönüş uygulama

---

## Görevler

### 1. Hedefi Takip Etme  
Kule hedef GameObject’in yönünü bulmalı:  
- Hedef yönü = `target.position - transform.position`  
- Bu yön vektörünü normalize et  
- Kule bu yöne doğru **Slerp** ile yumuşak bir dönüş yapmalı

### 2. Dönüş Limitleri Ekle  
Kule, yalnızca belirlediğin bir açı aralığında hedefi takip edebilmeli.  

Örnek:  
- Maksimum takip açısı = 60 derece  
- Eğer hedef bu açının dışındaysa kule artık dönmeyecek  

Bunun için:  
- `dot = Vector3.Dot(forward, targetDir)` kullan  
- Açı hesapla → `angle = Mathf.Acos(dot) * Mathf.Rad2Deg`

### 3. Hedef Kaybolunca “Araştırma” Modu  
Hedef uzaklaşırsa veya açı dışına çıkarsa:

- Kule yavaşça bir sağa bir sola tarama hareketi yapmalı  
- Bu tarama **sabit hızla** dönen bir hareket olabilir  
- Tekrar hedef görünür konuma girince kule taramayı bırakıp hedefi takip etmeye geri döner

### 4. Hedef Eşik Mesafesi  
İsteğe bağlı geliştirme (önerilir):

- Hedef belli bir mesafeden uzaklaşırsa takip tamamen dursun  
- Mesafe = `Vector3.Distance(transform.position, target.position)`

---

## Teslim Kriterleri

- Script adı: **TurretController.cs**
- Sahnedeki kule hedefi düzgün şekilde takip etmeli  
- Dönüşler **yumuşak**, **ani olmayan** şekilde yapılmalı  
- Açısal takip limiti doğru çalışmalı  
- Hedef kaybolduğunda araştırma/tarama animasyonu başlamalı  
- Kodun içinde yorum satırları ile mantık açıklanmalı

---

## İpucu

- Araştırma animasyonu için:  
  ```csharp
  float scanAngle = Mathf.Sin(Time.time * scanSpeed) * maxScanRange;
