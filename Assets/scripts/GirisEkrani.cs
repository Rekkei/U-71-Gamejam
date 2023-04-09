using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GirisEkrani : MonoBehaviour
{
    public void PlayGame()
    {
        SceneManager.LoadScene(1);
    }

    public void Ayarlar()
    {
        SceneManager.LoadScene(2);
    }

    public void EkipUyeleri()
    {
        SceneManager.LoadScene(3);
    }

    public void GirisEkraninaDon()
    {
        SceneManager.LoadScene(0);
    }


    public void QuitGame()
    {
      Debug.Log("oyundan ciktik");  
      Application.Quit();
    }
}
