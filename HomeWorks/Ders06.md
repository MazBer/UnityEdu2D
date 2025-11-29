# Ders 6 — Prefabs, Varyantlar ve Sahne Yönetimi  

## Amaç
Bu ödevde, farklı sahneler arasında **Prefab tabanlı** bir sistem kullanarak **UI olmadan**, tamamen oyun içi etkileşimle **level seçimi ve sahne geçişi** yapacaksınız.

---

## Açıklama  
Oyunlarda sahne geçişleri her zaman menü butonlarıyla yapılmaz.  
Bazen oyuncu bir kapıya yaklaşır, bir portala girer, bir objeye çarpar veya belirli bir bölgeye adım attığında sonraki level otomatik yüklenir.

Bu ödevde amacınız:

- Seviyelerinizi sahne olarak ayırmak  
- Bir **“Level Gateway”** (kapı/portal/trigger) prefab’ı oluşturmak  
- Oyuncu bu kapı ile etkileşime geçtiğinde sahnenin yüklenmesini sağlamak  
- `SceneManager.LoadScene` kullanmak  
- Gerekirse **DontDestroyOnLoad** ile bazı objeleri sahneler arasında taşımak  

---

## Gereksinimler

### 1. **En az 3 sahne hazırlayın**
Örneğin:

- `Level1.unity`
- `Level2.unity`
- `Level3.unity`

İçerikler basit olabilir (zemin + oyuncu + bir kapı).

---

### 2. **Bir “Level Gateway” Prefab’ı oluşturun**
Bu prefab:

- Bir **Collider (IsTrigger)** içermeli  
- Üzerinde “Bu kapı hangi sahneye götürüyor?” bilgisini tutacak bir **int** değişkeni olmalı  
- Oyuncu triggere girdiğinde sahneyi değiştirmeli

---

### 3. **Sahne Geçiş Script’i**
Örneğin:

- `LevelGateway.cs`  
- İçinde şu olmalı:
  - `public int sceneToLoad;`
  - `OnTriggerEnter()` içinde:
    - Oyuncu algılanmalı  
    - `SceneManager.LoadScene(sceneToLoad)` çağırılmalı  

---

### 4. **Prefab Varyantları**
En az **iki farklı kapı varyantı** yapın:

- Normal kapı → Level2'ye götürüyor  
- Altın kapı → Level3'e götürüyor  

`sceneToLoad` değeri varyant üzerinde ayarlanabilir olmalı.

---

### 5. **DontDestroyOnLoad (İsteğe Bağlı)**
Sahneler değiştiğinde oyuncuyu yok etmemek isterseniz:

- Oyuncuya `DontDestroyOnLoad` uygulayabilirsiniz  
- Ya da tam tersi: her sahnede sıfırdan respawn olmasını sağlayabilirsiniz  

Bu size kalmış.

---

## İpuçları

- SceneManager kullanımı:  
  - `SceneManager.LoadScene("Level2");` 
- Trigger çalışmıyorsa:
  - Birinde Rigidbody yoksa ekleyin  
  - En az biri "IsTrigger" olmalı  
- Variants oluşturmak için:
  - Prefab'e sağ tık → **Create Variant**

---

## Ekstra (İsteğe bağlı)

- Kapıdan geçince küçük bir ışık efekti ekleyin  
- Sahne yüklenince oyuncuyu özel bir spawn noktasına teleport edin  
