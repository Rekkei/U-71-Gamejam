using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AnaSahnePause : MonoBehaviour
{
    public GameObject ayarlarPanel;

    public void AyarlarPanelAcma()
    {
        ayarlarPanel.SetActive(true);
    }

    public void OyunaDon()
    {
        ayarlarPanel.SetActive(false);
    }

    public void AnaMenuyeGit()
    {
        SceneManager.LoadScene(0);
    }

}
