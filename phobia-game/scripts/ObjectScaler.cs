using UnityEngine;

public class ObjectScaler : MonoBehaviour
{
    public Vector3 from = Vector3.one; // Başlangıç boyutu (ör. 1,1,1)
    public Vector3 to = new Vector3(2f, 2f, 2f); // Hedef boyutu (ör. 2,2,2)
    public float speed = 0.5f; // Animasyon hızı
    private float transitionPercentage = 0.0f; // Geçiş yüzdesi
    private int direction = 1; // Yön (1: büyüt, -1: küçült)

    // Update is called once per frame
    void Update()
    {
        // Geçiş hesaplama
        transitionPercentage += direction * speed * Time.deltaTime;

        // Geçiş yüzdesini sınırla
        transitionPercentage = Mathf.Clamp01(transitionPercentage);

        // Boyutu ayarla
        transform.localScale = Vector3.Lerp(from, to, transitionPercentage);

        // Yön değişimi
        if (transitionPercentage >= 1.0f || transitionPercentage <= 0.0f)
        {
            direction *= -1;
        }
    }
}

