using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class main : MonoBehaviour
{
    public GameObject popup, popup2,popup3;
    public TMP_Text TEXT1, TEXT2, TEXT3, TEXT4;





    public void button1durum()
    {
        if (clickpointer.durum == 1)
        {
            akademi();
            clickpointer.durum = 0;

        }
        if (clickpointer.durum == 2)
        {
            okul();
            clickpointer.durum = 0;
        }
        if (clickpointer.durum == 3)
        {
            uyu();
            clickpointer.durum = 0;
        }
    }
    public void button2durum()
    {
        if (clickpointer.durum == 1)
        {
            ders();
            clickpointer.durum = 0;
        }
        if (clickpointer.durum == 2)
        {
            disari();
            clickpointer.durum = 0;
        }

    }


    public void okul2()
    {
        popup.SetActive(false);
        TEXT4.text = "okula gidiyorsun";
        popup2.SetActive(true);
    }




    public void okul()
    {
        popup.SetActive(false);
        TEXT4.text = "okula gidiyorsun";
        popup2.SetActive(true);
    }
    public void disari()
    {
        popup.SetActive(false);
        TEXT4.text = "dýþarý çýkýyorsun";
        popup2.SetActive(true);
    }
    public void uyu()
    {
        popup.SetActive(false);
        TEXT4.text = "yataða gittin";
        popup2.SetActive(true);
    }
    public void akademi()
    {
        popup.SetActive(false);
        TEXT4.text = "oyun ve uygulama akademisi sitesine giriþ yaptýn";
        popup2.SetActive(true);
    }
    public void ders()
    {
        popup.SetActive(false);
        TEXT4.text = "ders çalýþmaya baþladýn";
        popup2.SetActive(true);
    }
    public void cikis()
    {
        clickpointer.durum = 0;
        popup.SetActive(false);
        clickpointer.durum = 0;

    }
    public void cikis2()
    {
        clickpointer.durum = 0;
        popup.SetActive(false);
        popup2.SetActive(false);
        clickpointer.durum = 0;
        popup3.SetActive(true);
        StartCoroutine(blackscreen());
        IEnumerator blackscreen()
        {
            yield return new WaitForSecondsRealtime(3f);
            popup3.SetActive(false);
            

            
        }

    }
}
