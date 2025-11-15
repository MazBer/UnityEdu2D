# Ders 5 — Fizik, Çarpışmalar ve Geri Bildirim

## Amaç
Bu ödevde, 3D fizik sistemini kullanarak bir **engel çarpışma sistemi** oluşturacaksınız. Oyuncu veya obje engellere çarptığında **puan kazanacak veya kaybedecek**, aynı zamanda **görsel geri bildirim** alacak.

---

## Açıklama
Gerçek oyunlarda çarpışmalar, sadece objelerin birbirine temas etmesiyle sınırlı değildir. Oyuncuya geri bildirim vererek oyun deneyimini zenginleştirebiliriz.  

Bu ödevde amacınız:

- Engel ile çarpışma veya tetikleme (trigger) durumlarını tespit etmek  
- Çarpışmalarda **puan veya ceza** uygulamak  
- Çarpışma anında **görsel geri bildirim** (renk değişimi, efekt, animasyon) göstermek

---

## Gereksinimler

1. **Objeler ve Physics:**
   - Oyuncu ve engel objelere **Rigidbody** ve uygun **Collider** ekleyin  
   - Çarpışmalar için `OnCollisionEnter` veya `OnTriggerEnter` kullanın  
   - Layer tabanlı çarpışma ayarlarını yaparak sadece gerekli nesnelerin etkileşmesini sağlayın

2. **Puan Sistemi:**
   - Engel çarpışmasında puan ekleme veya azaltma mekanizması oluşturun  
   - Puan değerleri farklı engeller için değişebilir  

3. **Görsel Geri Bildirim:**
   - Çarpışma anında obje rengini kısa süreli değiştirin veya bir efekt oynatın  
   - İsteğe bağlı: Küçük bir parçacık sistemi veya animasyon ekleyebilirsiniz

4. **Yer Kontrolü:**
   - Objelerin sahneden düşmemesi için yer veya zemin ile temas kontrolü yapın  
   - `Raycast` veya `Linecast` kullanarak düşme durumlarını kontrol edebilirsiniz

---

## İpuçları

- Rigidbody ayarlarında **Kinematic**, **Use Gravity**, **Drag** ve **Angular Drag** parametrelerini anlamaya çalışın  
- Physics Material kullanarak **sürtünme ve esneklik** değerlerini deneyin  
- Geri bildirimler için **Coroutine** kullanarak kısa süreli renk değişimi veya efekt oynatma işlevi ekleyebilirsiniz

---

## Teslim

- Script dosyası adı: **CollisionManager.cs** (veya uygun bir ad)  
- Ödev tamamlandığında, engel çarpışmaları puan/ceza ve görsel geri bildirim ile gözlemlenebilir olmalı
