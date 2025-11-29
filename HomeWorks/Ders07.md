# Ders 9 — 2D Animasyon: Animator ve State Machine

## Amaç

Bu ödevde, bir 2D karakter için **Animator State Machine** yapısı kuracak, hareket durumlarını yöneten **state/transition sistemini**, **parametreleri**, **animation event’leri** kullanacak ve karakterin **hasar alma – ölüm – respawn** akışını animasyonlarla birlikte çalışır hâle getireceksiniz.

---

## Açıklama

2D oyunlarda karakter animasyonları sadece "Idle → Run" geçişlerinden ibaret değildir.
Çoğu oyunda karakter:

* Yürür
* Zıplar
* Hasar alır
* Ölür
* Daha sonra yeniden doğar (respawn)

Bu ödevde hedefiniz, karakterinizin animasyonlarını **gerçek bir oyun akışına uygun şekilde** düzenlemek ve Animator üzerindeki durum geçişlerini **parametreler ve transition kurallarıyla** kontrol etmektir.

Ayrıca Animation Events kullanarak animasyon sırasında belirli anlarda kod çalıştırmayı öğreneceksiniz.

---

## Gereksinimler

### 1. **Animator State Machine oluşturun**

Animator içinde en az şu durumlar olmalı:

* `Idle`
* `Run`
* `Jump`
* `Hurt` (hasar alma)
* `Death` (ölüm)
* `Respawn` (isteğe bağlı özel bir animasyon olabilir)

Bu state’ler arasında doğru geçişler kurulmalı.

---

### 2. **Animator Parametreleri ekleyin**

En az şu parametreler olmalı:

* `float speed` → Idle/Run geçişi için
* `bool isJumping` → Jump animasyonu için
* `trigger hurtTrigger` → hasar alma tetikleyicisi
* `trigger deathTrigger` → ölüm tetikleyicisi

Geçişler bu parametrelerle kontrol edilmeli.

---

### 3. **Transition kuralları ayarlayın**

Örneğin:

* `speed > 0.1` → Idle → Run
* `isJumping == true` → Run → Jump
* `hurtTrigger` tetiklenince Hurt animasyonu oynasın
* `deathTrigger` tetiklenince Death animasyonu oynasın

**Hurt ve Death animasyonlarından çıkış “Has Exit Time” ile kontrol edilmeli.**

---

### 4. **Animation Events kullanın**

Aşağıdakilerden en az birini yapmalısınız:

* Hurt animasyonunun sonuna **“OnHurtEnd()”** adlı bir event ekleyin → karakter yeniden kontrol edilebilir hâle gelsin
* Death animasyonunun sonuna event ekleyin → respawn süreci başlasın
* Spawn animasyonunun sonunda karakteri yeniden hareket ettirin

Animation Event en az bir sahnede **kod tetiklemeli**.

---

### 5. **Hasar Alma – Ölüm – Respawn Akışı Kurun**

Bu ödevin ana kısmı burasıdır. Şu akış sağlanmalı:

1. Karakter bir engele/yaratığa çarpar → canı azalır
2. Can > 0 ise → *Hurt animasyonu* oynar
3. Can ≤ 0 olursa → *Death animasyonu* oynar
4. Death animasyonu bittiğinde → karakter **respawn noktası**na ışınlanır
5. Gerekirse respawn animasyonu oynatılır
6. Karakter oyuna devam eder

Respawn otomatik veya bir Animation Event aracılığıyla gerçekleştirilebilir.

---

## İpuçları

* **Hurt animasyonu hareketi durdurmalı**, bunu `PlayerController` içinde input’u kilitleyerek yapabilirsiniz.
* Animation Event eklemek için:

  * Animasyonu seç → **Inspector** → **Events** sekmesi → artı butonu → fonksiyon adı yaz
* Eğer Jump animasyonu gecikiyorsa **transition duration** değerini 0 yapın.
* Parallax arka plan için:

  * Arka planı kameranın x-pozisyonuna göre hafifça kaydırın (`background.position.x = cam.position.x * parallaxSpeed`).
* State Machine’i çok karışık yapmayın; Hurt ve Death genelde “Any State”ten çağrılabilir.

---

## Ekstra (İsteğe bağlı)

* Ölüm animasyonu sırasında ekranı hafifçe karartma (fade) efekti ekleyin
* Respawn noktasına giderken kısa bir “blink” veya “particle” efekti oynatın
* Can azaldığında HUD üzerinde kırmızı ekran yanıp sönmesi efekti ekleyin
