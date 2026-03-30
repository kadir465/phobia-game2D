using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;
using static Unity.Burst.Intrinsics.X86;

public class SceneController : MonoBehaviour
{
  
    public string X = "Bedroom";
    public GameObject credits;

    public void toggleCredits()
    {
        credits.SetActive(!credits.activeSelf);
    }

    public void quit()
    {
        Application.Quit();
    }

    public void bedroom()
    {
        SceneManager.LoadScene(X);
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("LabirentExit"))
        {
            SceneManager.LoadScene(X);
           
        }
    }

    public void gokdelenFanus()
    {
        SceneManager.LoadScene("GokdelenFanus");
    }

    public void okyanusFanus()
    {
        SceneManager.LoadScene("OkyanusFanus");
    }
}
