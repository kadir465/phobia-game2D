using System.Collections; // IEnumerator için gerekli
using UnityEngine;
using UnityEngine.UI; // UI bileşenlerini kontrol etmek için gerekli
using TMPro;
using UnityEngine.SceneManagement;
public class ColorPuzzle : MonoBehaviour
{   public static int sira =0;
    public static int renkNumarasi = 0;
    public Vector3 from = Vector3.one; // Başlangıç boyutu (ör. 1,1,1)
    public Vector3 to = new Vector3(2f, 2f, 2f); // Hedef boyutu (ör. 2,2,2)
    public float speed = 0.5f; // Animasyon hızı
    public GameObject red;
    public GameObject green;
    public GameObject blue;
    private float transitionPercentage = 0.0f; // Geçiş yüzdesi
    private int direction = 1; // Yön (1: büyüt, -1: küçült)

    public TMP_Text yazigok;
    public GameObject balongok;
    
    void Start()
    {
        balongok.gameObject.SetActive(true);
        yazigok.text = "Çok yüksek... bulutların üzerinde olmak çok korkutucu";
        StartCoroutine(Wait(4, () => {
            yazigok.text = "Üstteki ve alltaki ışıklar arasında bir ilişki olmalı.";
            StartCoroutine(Wait(5, () => {
                yazigok.text = "Ama Ne?";
                StartCoroutine(Wait(3, () => {
                    sira++;
                    balongok.gameObject.SetActive(false);
                }));
            }));
        }));
    }

    // Update is called once per frame
    void Update()
    {
        switch (renkNumarasi)
        {
            case 0:
                blue.transform.localScale = from;
                red.transform.localScale = from;
                green.transform.localScale = from;
                // Geçiş hesaplama
                transitionPercentage += direction * speed * Time.deltaTime;

                // Geçiş yüzdesini sınırla
                transitionPercentage = Mathf.Clamp01(transitionPercentage);

                // Boyutu ayarla
                red.transform.localScale = Vector3.Lerp(from, to, transitionPercentage);
                blue.transform.localScale = Vector3.Lerp(from, to, transitionPercentage);

                // Yön değişimi
                if (transitionPercentage >= 1.0f || transitionPercentage <= 0.0f)
                {
                    direction *= -1;
                }
                break;
            case 1:
                blue.transform.localScale = from;
                red.transform.localScale = from;
                green.transform.localScale = from;
                // Geçiş hesaplama
                transitionPercentage += direction * speed * Time.deltaTime;

                // Geçiş yüzdesini sınırla
                transitionPercentage = Mathf.Clamp01(transitionPercentage);

                // Boyutu ayarla
                red.transform.localScale = Vector3.Lerp(from, to, transitionPercentage);
                green.transform.localScale = Vector3.Lerp(from, to, transitionPercentage);

                // Yön değişimi
                if (transitionPercentage >= 1.0f || transitionPercentage <= 0.0f)
                {
                    direction *= -1;
                }
                break;
            case 2:
                blue.transform.localScale = from;
                red.transform.localScale = from;
                green.transform.localScale = from;
                break;
            case 3:
                blue.transform.localScale = from;
                red.transform.localScale = from;
                green.transform.localScale = from;
                // Geçiş hesaplama
                transitionPercentage += direction * speed * Time.deltaTime;

                // Geçiş yüzdesini sınırla
                transitionPercentage = Mathf.Clamp01(transitionPercentage);

                // Boyutu ayarla
                blue.transform.localScale = Vector3.Lerp(from, to, transitionPercentage);
                green.transform.localScale = Vector3.Lerp(from, to, transitionPercentage);

                // Yön değişimi
                if (transitionPercentage >= 1.0f || transitionPercentage <= 0.0f)
                {
                    direction *= -1;
                }
                break;
            case 4:
                // Geçiş hesaplama
                transitionPercentage += direction * speed * Time.deltaTime;

                // Geçiş yüzdesini sınırla
                transitionPercentage = Mathf.Clamp01(transitionPercentage);

                // Boyutu ayarla
                red.transform.localScale = Vector3.Lerp(from, to, transitionPercentage);
                green.transform.localScale = Vector3.Lerp(from, to, transitionPercentage);
                blue.transform.localScale = Vector3.Lerp(from, to, transitionPercentage);

                // Yön değişimi
                if (transitionPercentage >= 1.0f || transitionPercentage <= 0.0f)
                {
                    direction *= -1;
                }
                break;
        }
    }

    IEnumerator Wait(float seconds, System.Action action)
    {
        yield return new WaitForSeconds(seconds);
        action?.Invoke();
    }

    public void magenta()
    {
        if (renkNumarasi == 0)
        {
            renkNumarasi++;
        }
        else
        {
            renkNumarasi = 0;
        }
    }
    public void yellow()
    {
        if (renkNumarasi == 1)
        {
            renkNumarasi++;
        }
        else
        {
            renkNumarasi = 0;
        }
    }
    public void cyan()
    {
        if (renkNumarasi == 3)
        {
            renkNumarasi++;
        }
        else
        {
            renkNumarasi = 0;
        }
    }
    public void white()
    {
        if (renkNumarasi == 4)
        {
            SceneManager.LoadScene("Bedroom");
        }
        else
        {
            renkNumarasi = 0;
        }
    }
    public void black()
    {
        if (renkNumarasi == 2)
        {
            renkNumarasi++;
        }
        else
        {
            renkNumarasi = 0;
        }
    }
}

