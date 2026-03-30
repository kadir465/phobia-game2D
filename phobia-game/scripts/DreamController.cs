using System.Collections; // IEnumerator için gerekli
using UnityEngine;
using UnityEngine.UI; // UI bileşenlerini kontrol etmek için gerekli
using TMPro;
using UnityEngine.SceneManagement;

public class DreamController : MonoBehaviour
{
    public static int ruyaNumarasi = 0;
    public AudioSource nefesSesi;  // Karakter nefes sesi
    public TMP_Text yazilar; // UI Text bileşeni
    public Image ruyabalonu;

    void Start()
    {
        // Olayları sırayla başlat
        StartCoroutine(OlaySirasi());
    }

    IEnumerator OlaySirasi()
    {
        // 1. Nefes sesi çal
        nefesSesi.Play();
        yield return new WaitForSeconds(2f); // Nefes sesi bittikten sonra 2 saniye bekle

        switch (ruyaNumarasi)
        {
            case 0:
                ruyabalonu.gameObject.SetActive(true);
                yazilar.text = "Çok korkuyorum !!!";
                yield return new WaitForSeconds(5f); // 5 saniye bekle

                // 4. Yazıyı değiştir
                yazilar.text = "Burası neresi?";
                yield return new WaitForSeconds(5f);

                ruyabalonu.gameObject.SetActive(false);
                yazilar.text = "";
                SceneManager.LoadScene("Labirent");
                ruyaNumarasi++;
                break;
            case 1:
                ruyabalonu.gameObject.SetActive(true);
                yazilar.text = "....";
                yield return new WaitForSeconds(5f); // 5 saniye bekle

                // 4. Yazıyı değiştir
                yazilar.text = "Burası çok yüksek!";
                yield return new WaitForSeconds(5f);

                yazilar.text = "Ben yüksekten çok korkarım!";
                yield return new WaitForSeconds(5f);

                ruyabalonu.gameObject.SetActive(false);
                yazilar.text = "";
                SceneManager.LoadScene("Gokdelen");
                ruyaNumarasi++;
                break;
            case 2:
                ruyabalonu.gameObject.SetActive(true);
                yazilar.text = "....";
                yield return new WaitForSeconds(5f); // 5 saniye bekle

                // 4. Yazıyı değiştir
                yazilar.text = "Burası çok derin!";
                yield return new WaitForSeconds(5f);

                yazilar.text = "Okyanus çok korkutucu!";
                yield return new WaitForSeconds(5f);
                
                yazilar.text = "Buradaki canavarlar...!";
                yield return new WaitForSeconds(5f);

                ruyabalonu.gameObject.SetActive(false);
                yazilar.text = "";
                SceneManager.LoadScene("Okyanus");
                ruyaNumarasi++;
                break;
        }
        

    }
}
