using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GirisEkrani : MonoBehaviour
{
    public GameObject ayarlarPanel;
    public GameObject ekipPanel;

    public void PlayGame()
    {
        SceneManager.LoadScene(1);
    }

    public void Ayarlar()
    {
        ayarlarPanel.SetActive(true);
    }

    public void EkipUyeleri()
    {
        ekipPanel.SetActive(true);
    }


    public void GirisEkraninaDon()
    {
        SceneManager.LoadScene(0);
    }

    public void GirisEkraninaDon2()
    {
        ayarlarPanel.SetActive(false);
        ekipPanel.SetActive(false);
    }


    public void QuitGame()
    {
      Debug.Log("oyundan ciktik");  
      Application.Quit();
    }
}
