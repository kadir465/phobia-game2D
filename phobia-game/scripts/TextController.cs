using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class TextController : MonoBehaviour
{
    public TMP_Text text;
    public TMP_Text text1;
    public TMP_Text text2;
    public TMP_Text text3;

    public GameObject glow1;
    public GameObject glow2;
    public GameObject glow3;
    public GameObject glow4;
    public int sayi = 3;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        text.text = (sayi >> 3).ToString();
        text1.text = ((sayi >> 2) & 1).ToString();
        text2.text = ((sayi >> 1) & 1).ToString();
        text3.text = (sayi & 1).ToString();
    }
    public void sayi3()
    {
        if (sayi == 3)
        {
            sayi = 14;
            glow1.SetActive(true);
        }
        else
        {
            sayi = 3;
        }
    }
    public void sayi14()
    {
        if (sayi == 14)
        {
            sayi = 5;
            glow2.SetActive(true);
        }
        else
        {
            sayi = 3;
        }
    }
    public void sayi5()
    {
        if (sayi == 5)
        {
            sayi = 10;
            glow3.SetActive(true);
        }
        else
        {
            sayi = 3;
        }
    }
    public void sayi10()
    {
        if (sayi == 10)
        {
            glow4.SetActive(true);
            SceneManager.LoadScene("kurtulus");
        }
        else
        {
            sayi = 3;
        }
    }
}
