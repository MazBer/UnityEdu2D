# Ders 2 — Hareket (İvme ve Maksimum Hız) Ödevi

## Amaç
Bu ödevde, bir karakterin (örneğin bir kare objenin) hareketine **ivme (acceleration)** ve **maksimum hız (max speed)** ekleyeceksiniz. Böylece karakter aniden hızlanıp durmak yerine, **yavaşça hızlanacak** ve **yavaşça duracak**.

---

## Açıklama
Önceki derste, ok tuşlarıyla hareket eden bir kare yapmıştık. O kare, tuşa bastığımız anda tam hızla hareket ediyor ve tuşu bıraktığımızda aniden duruyordu.  
Bu ödevde ise, hareketi **daha gerçekçi** hale getireceğiz:

- Kare ok tuşuna bastığınızda **yavaşça hızlansın (ivmelensin)**
- Maksimum bir hız değerini **geçmesin**
- Tuşu bıraktığınızda **yavaşça dursun (yavaşlama)**

---

## İpucu
- `float speed` değişkenine ek olarak bir `float acceleration` ve `float maxSpeed` değişkeni ekleyin.  
- `if` yapısı kullanarak tuşa basılı olup olmadığını kontrol edin.  
- Tuşa basılıysa hızı **yavaş yavaş artırın**, değilse **yavaş yavaş azaltın**.  
- Hız değeri `maxSpeed`’i geçmemeli.  
- `deltaTime` kullanmayı unutmayın!

---

## Ekstra (isteğe bağlı)
- Hareket yönüne göre kareyi döndürebilirsiniz.  
- Farklı renk efektleri veya görsel geri bildirim ekleyebilirsiniz.

---

## Teslim
- Script dosyanızın adı: **SmoothMovement.cs**  
- Unity projesinde kare hareket ederken hızlanma ve yavaşlama net şekilde gözlemlenmelidir.
