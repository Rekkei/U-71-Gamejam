using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.Mathematics;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class main : MonoBehaviour
{
    public GameObject popupexam,popup, popup2, popup3, popup4, popup5, popup6,popup7, popup8, popup9, popup10, popup11, popup12, popup13, popup14, popup15, popup16, popup17, popup18, popup19, popup20, popup21;
    public TMP_Text TEXT1, TEXT2, TEXT3, TEXT4, TEXT5;
    //public Sprite[] kalanzaman;
    public Image[] timeIntervals;
    public int totalTimeIntervals = 8;

    public Image bar;
    public Sprite[] akademibar;
    public Image akademimage;
    public Sprite[] dersbar;
    public Image dersimage;
    public Sprite[] sosyalbar;
    public Image sosyalimage;
    public static int kalanzamanbar = 0;
    public static int dersstat = 1;
    public static int akademistat = 0;
    public static int sosyalstat = 1;
    public Sprite[] moonandsunsprite;
    public Image moonandsun123;
    
    public TMP_Text countertxt1;
    public TMP_Text countertxt2;
    public int countDers;
    public int countAkademi;
    public int popupbirthday;
    public int daycounter;
    public int studycounter=2;
    public int twodaycounter;
    public bool twodaysedu, twodayssocial;
    public bool uyudumu;


    private void Start()
    {
        daycounter = 1;
        dersstat = 1;
        sosyalstat = 1;
        akademimage.sprite = akademibar[akademistat];
        dersimage.sprite = dersbar[dersstat];
        sosyalimage.sprite = sosyalbar[sosyalstat];
        //bar.sprite = kalanzaman[kalanzamanbar];

        kalanzamanbar = totalTimeIntervals;

        countertxt1.text = "Sinava kalan sure: " + countDers.ToString() + " gun";
        countertxt2.text = "Akademi sonuna kalan sure: " + countAkademi.ToString() + " gun";

        //if (kalanzamanbar < 5)
        //{
        //    moonandsun123.sprite = moonandsunsprite[1];

        //}
        //else
        //{
        //    moonandsun123.sprite = moonandsunsprite[0];
        //}

    }
    private void FixedUpdate()
    {
        if(sosyalstat==0)
        {
            SceneManager.LoadScene(4);
            PlayerPrefs.SetInt("reason", 1);
        }
        if (dersstat == 0)
        {
            SceneManager.LoadScene(4);
            PlayerPrefs.SetInt("reason", 2);
        }

    }


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


    public void okul()
    {
        if (kalanzamanbar == 8)
        {
            if (sosyalstat == 7)
            {
            }
            else
            {
                sosyalstat += 1;
                
            }
            if (dersstat == 7)
            {
            }
            else
            {
                dersstat += 1;
            }
            kalanzamanbar -= 4;
           
            popup.SetActive(false);
            TEXT4.text = "Okula gidiyorsun";
            TEXT3.text = "Okula gidip akademik basarini arttirdin ve sosyallestin";

            popup2.SetActive(true);



        }
        else
        
        {

            if (kalanzamanbar == 6)
            {
                if (sosyalstat == 7)
                {
                }
                else
                {
                    sosyalstat += 1;
                    sosyalstat += 1;
                }
                if (dersstat == 7)
                {
                }
                else
                {
                    dersstat += 1;
                }
                kalanzamanbar -= 4;
                
                popup.SetActive(false);
                TEXT4.text = "Okula gidiyorsun";
                TEXT3.text = "Okula gidip akademik basarini ve populerligini arttirdin";

                popup2.SetActive(true);



            }
            else
            {
                popup5.SetActive(true);
                popup.SetActive(false);
            }

        }

    }
    public void disari()
    {
        if (kalanzamanbar > 0)
        {

            twodayssocial = true;
            if (sosyalstat == 7)
            {
            }
            else
            {
                
                sosyalstat += 1;
            }
            kalanzamanbar -= 2;
            popup.SetActive(false);
            TEXT4.text = "Disari cikiyorsun";
            TEXT3.text = "Disari cikip arkadaslarinla eglendin, populerlik artti";
            popup2.SetActive(true);

        }
        else
        {
            popup4.SetActive(true);
            popup.SetActive(false);
        }

    }
    public void uyu()
    {

        popup4.SetActive(false);
        popup5.SetActive(false);
        popup.SetActive(false);
        TEXT4.text = "Yataga gittin";
        TEXT3.text = "Butun gece deliksiz uyudun, enerjini yeniledin";
        twodaycounter++;
        if (twodaycounter == 2)
        {
            twodaycounter = 0;

            if (twodaysedu == false)
            {
                if (dersstat == 0)
                {
                    SceneManager.LoadScene(4);
                    PlayerPrefs.SetInt("reason", 2);
                }
                else
                {
                    dersstat--;
                }


            }
            else
            {
            }
            if (twodayssocial == false)
            {
                if (sosyalstat == 0)
                {
                    SceneManager.LoadScene(4);
                    PlayerPrefs.SetInt("reason", 1);
                }
                else
                {
                    sosyalstat--;
                }
            }
            else
            {
            }
            twodayssocial = false;
            twodaysedu = false;
        }
        

        
        decCount();
        popup2.SetActive(true);

        kalanzamanbar = 8;
        uyudumu = true;
    }


    IEnumerator daycounterf()
    {
        yield return new WaitForSecondsRealtime(3f);
        if (daycounter == 2)
        {
            popup6.SetActive(true);

        }
        
        
            if (daycounter == 7)
            {
                popup7.SetActive(true);

            }
        
        
        if (daycounter == 8)
        {
            popupexam.SetActive(true);

            
        }
        if (daycounter == 9)
        {
            popup8.SetActive(true);
        }
        if (daycounter == 13)
        {
            popup9.SetActive(true);
        }

        if (daycounter == 11)
        {
            if (akademistat == 7)
            {
                SceneManager.LoadScene(5); //WIN
            }
            else
            {
                SceneManager.LoadScene(4); //LOSE
                PlayerPrefs.SetInt("reason", 3);
            }
        }

    }
    public void dogumgunu1()
    {
        if (dersstat > 0)
        {
            dersstat -= 1;
        }
        if (sosyalstat == 7)
        {

        }
        else
        {
            sosyalstat += 1;
        }
        kalanzamanbar -= 4;

        TEXT3.text = "Arkadasinin dogum gununu kutladin ve iyi vakit gecirdin";
        if (daycounter == 2)
        {
            popup6.SetActive(false);

        }
        if (daycounter == 7)
        {
            popup7.SetActive(false);
        }
        if (daycounter == 9)
        {
            popup8.SetActive(false);
        }
        if (daycounter == 13)
        {
            popup9.SetActive(false);
        }
        cikis2();
    }
    public void dogumgunu2()
    {
        if (sosyalstat > 0)
        {
            sosyalstat -= 1;
        }
        if (dersstat == 7)
        {

        }
        else
        {
            dersstat += 1;
        }

        kalanzamanbar -= 4;

        TEXT3.text = "Aferin, ders calisirken zor bir soruyu cozdun";
        if (daycounter == 2)
        {
            popup6.SetActive(false);
        }
        if (daycounter == 7)
        {
            popup7.SetActive(false);
        }
        if (daycounter == 9)
        {
            popup8.SetActive(false);
        }
        if (daycounter == 13)
        {
            popup9.SetActive(false);
        }
        cikis2();


    }
    public void akademi()
    {

        if (kalanzamanbar > 0)
        {
            if (akademistat == 7)
            {
            }
            else
            {
                akademistat += 1;
                
            }
            kalanzamanbar -= 2;
            popup.SetActive(false);
            TEXT4.text = "Oyun ve Uygulama Akademisi sitesine giris yaptin";
            TEXT3.text = "Oyun ve Uygulama Akademisinin aylik gorevlerinde ilerleme kaydettin";
            popup2.SetActive(true);
        }
        else
        {
            popup4.SetActive(true);
            popup.SetActive(false);
        }


    }
    public void ders()
    {
        if (kalanzamanbar > 0)
        {

            twodaysedu = true;
            if (dersstat == 7)
            {
            }
            else
            {
                dersstat += 1;
            }
            kalanzamanbar -= 2;
            popup.SetActive(false);
            TEXT4.text = "Ders calismaya basladin";
            TEXT3.text = "Ders calisip universitedeki basarini arttirdin";
            popup2.SetActive(true);
        }
        else
        {
            popup4.SetActive(true);
            popup.SetActive(false);
        }

    }
    public void cikis()
    {
        clickpointer.durum = 0;
        popup.SetActive(false);
        clickpointer.durum = 0;

    }
    public void cikis3()
    {
        popup4.SetActive(false);

    }
    public void cikis4()
    {
        popup5.SetActive(false);

    }
    public void cikisexam()
    {
        popupexam.SetActive(false);
        
       

    }
    public void cikis2()
    {
        if (uyudumu)
        {

            uyudumu= false;
            StartCoroutine(daycounterf());
        }







        clickpointer.durum = 0;
        popup.SetActive(false);
        popup2.SetActive(false);
        clickpointer.durum = 0;
        popup3.SetActive(true);
        StartCoroutine(blackscreen());
    }

        IEnumerator blackscreen()
        {

            yield return new WaitForSecondsRealtime(3f);
            akademimage.sprite = akademibar[akademistat];
            dersimage.sprite = dersbar[dersstat];
            sosyalimage.sprite = sosyalbar[sosyalstat];
        //bar.sprite = kalanzaman[kalanzamanbar];

        UpdateTimeline();
        ZamanYenileme();

        if (kalanzamanbar < 5)
            {
                moonandsun123.sprite = moonandsunsprite[1];

            }
            else
            {
                moonandsun123.sprite = moonandsunsprite[0];
            }
            

            popup3.SetActive(false);
        }


    public void UpdateTimeline()
    {
        if (kalanzamanbar >= 0 && kalanzamanbar <= totalTimeIntervals)
        {
            for (int i = kalanzamanbar; i < totalTimeIntervals; i++)
            {
                if (i >= 0 && i <= totalTimeIntervals)
                {
                    timeIntervals[i].gameObject.SetActive(false);
                }
            }
        }
        else
        {
            CancelInvoke("UpdateTimeline");
        }
    }

    public void ZamanYenileme()
    {
        for (int i = 0; i < kalanzamanbar; i++)
        {
            if (timeIntervals[i].gameObject.activeSelf == false)
            {
                timeIntervals[i].gameObject.SetActive(true);
            }
        }
    }


    public void decCount()
    {
        daycounter++;
        countDers--;
        countAkademi--;
        if(daycounter>=9) {

            countertxt1.text = "Sinavi gectin ";

        }
        else
        {
            countertxt1.text = "Sinava kalan sure: " + countDers.ToString() + " gun";
        }
       
        
            countertxt2.text = "Akademi sonuna kalan sure: " + countAkademi.ToString() + " gun";








        countertxt2.text = "Akademi sonuna kalan sure: " + countAkademi.ToString() + " gun" ;
    }

    public void sinav()
    {

        if (dersstat == 7)
        {
            TEXT3.text = "Tebrikler, calismalarin meyvesini verdi. Sinavi gectin!";
            cikis2();
            popupexam.SetActive(false);
            
        }
        else
        {
            SceneManager.LoadScene(4);
            PlayerPrefs.SetInt("reason", 4);
        }
    }
}