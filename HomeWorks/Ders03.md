# Ders 3 — Dalgalar Halinde Spawn Eden Zorluk Sistemi

## Amaç
Bu ödevde, oyuna **dalgalar (waves)** halinde düşman (veya engel) ekleyen bir **spawn sistemi** yazacaksınız. Her dalgada oyun **biraz daha zorlaşacak**.

---

## Açıklama
Gerçek oyunlarda düşmanlar genellikle rastgele değil, **dalga dalga (wave system)** olarak gelir.  
Bu sayede oyuncuya hem dinamik hem de giderek zorlaşan bir deneyim sunulur.

Bu ödevde amacınız:  
- Belirli aralıklarla düşman (veya obje) oluşturmak  
- Her dalgada spawn sayısını artırmak  
- İsterseniz düşmanların hızını veya spawn süresini azaltarak **zorluk seviyesini** artırmak

---

## İzlenecek Adımlar
1. Bir düşman **prefab** veya **obje** oluşturun (örneğin “Enemy”)  
2. **Spawner** isminde bir boş GameObject oluşturun ve içine bir script ekleyin  
3. Script içinde:
   - `currentWave`, `enemiesPerWave`, `spawnInterval`, `difficultyMultiplier` gibi değişkenler tanımlayın  
   - Her dalga bittiğinde `currentWave` sayısını artırın  
   - Yeni dalgada düşman sayısını veya hızını `difficultyMultiplier` ile çarpın
4. `IEnumerator` ve `WaitForSeconds()` kullanarak spawn işlemlerini zamana yayabilirsiniz  
5. İsterseniz her dalga arası **“Wave X Started!”** gibi bir yazı da gösterebilirsiniz

---

## İpucu
- Yeni dalgaya geçmek için bir zamanlayıcı kurabilirsiniz
- Zorluk artışı için farklı yollar:
  - Daha fazla düşman spawn etme  
  - Spawn aralığını azaltma  
  - Düşman hızını artırma
- `StartCoroutine()` ve `yield return` ifadelerini araştırın

---

## Ekstra (isteğe bağlı)
- Dalga sayısını ekranda gösterin (örneğin “Wave 3”)  
- Her dalgadan sonra kısa bir bekleme süresi (örneğin 3 saniye) ekleyin  

---

## Teslim
- Script dosyası adı: **WaveSpawner.cs**  
- Her yeni dalgada zorluk artmalı  
- Düşmanlar dalga dalga spawn olmalı, aynı anda değil
