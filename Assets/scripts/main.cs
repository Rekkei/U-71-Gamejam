using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.Mathematics;
using UnityEngine;
using UnityEngine.UI;



public class main : MonoBehaviour
{
    public GameObject popup, popup2, popup3, popup4, popup5, popup6,popup7, popup8, popup9, popup10, popup11, popup12, popup13, popup14, popup15, popup16, popup17, popup18, popup19, popup20, popup21;
    public TMP_Text TEXT1, TEXT2, TEXT3, TEXT4, TEXT5;
    public Sprite[] kalanzaman;
    public Image bar;
    public Sprite[] akademibar;
    public Image akademimage;
    public Sprite[] dersbar;
    public Image dersimage;
    public Sprite[] sosyalbar;
    public Image sosyalimage;
    public static int kalanzamanbar = 0;
    public static int dersstat = 0;
    public static int akademistat = 0;
    public static int sosyalstat = 0;
    public Sprite[] moonandsunsprite;
    public Image moonandsun123;
    
    public TMP_Text countertxt1;
    public TMP_Text countertxt2;
    public int countDers;
    public int countAkademi;
    public int popupbirthday;
    public int daycounter;







    private void Start()
    {
        daycounter = 1;
        kalanzamanbar = 8;
        countertxt1.text = "Sýnava Kalan Süre:" + countDers.ToString() + "gün";
        countertxt2.text = "Akademi Sonuna Kalan Süre:" + countAkademi.ToString() + "gün";
        if (kalanzamanbar < 5)
        {
            moonandsun123.sprite = moonandsunsprite[1];

        }
        else
        {
            moonandsun123.sprite = moonandsunsprite[0];
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
            sosyalstat += 1;
            kalanzamanbar -= 4;
            dersstat += 1;
            popup.SetActive(false);
            TEXT4.text = "okula gidiyorsun";
            TEXT3.text = "okula gidip akademik basarini arttirdin ve sosyallestin";

            popup2.SetActive(true);



        }
        else
        
        {

            if (kalanzamanbar == 6)
            {
                sosyalstat += 1;
                kalanzamanbar -= 4;
                dersstat += 1;
                popup.SetActive(false);
                TEXT4.text = "okula gidiyorsun";
                TEXT3.text = "okula gidip akademik basarini arttirdin ve sosyallestin";

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

            sosyalstat += 1;
            kalanzamanbar -= 2;
            popup.SetActive(false);
            TEXT4.text = "disari cikiyorsun";
            TEXT3.text = "disari cikip arkadaslarin ile eglendin populerlik artti";
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
        kalanzamanbar = 8;
        popup4.SetActive(false);
        popup5.SetActive(false);
        popup.SetActive(false);
        TEXT4.text = "yataga gittin";
        TEXT3.text = "guzel bir uyku cekip enerjini yeniledin";
        StartCoroutine(daycounterf());

        
        decCount();
        popup2.SetActive(true);
        
        
    }
    IEnumerator daycounterf()
    {
        yield return new WaitForSecondsRealtime(4f);
        if (daycounter == 2)
        {
            popup6.SetActive(true);

        }
        if (daycounter == 7)
        {
            popup7.SetActive(true);

        }
        if (daycounter == 7)
        {
            popup7.SetActive(true);

        }
        if (daycounter == 9)
        {
            popup8.SetActive(true);
        }
        if (daycounter == 13)
        {
            popup9.SetActive(true);
        }

    }
    public void dogumgunu1()
    {
        if (dersstat > 0)
        {
            dersstat -= 1;
        }
        sosyalstat += 1;
        kalanzamanbar -= 4;
        
        TEXT3.text = "Arkadasinin dogum gununde iyi vakit gecirdin";
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

        
        kalanzamanbar -= 4;
        dersstat += 1;
        TEXT3.text = "Ders calisirken zor bir soruyu cozdun";
        if (daycounter==2)
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
            akademistat += 1;
            kalanzamanbar -= 2;
            popup.SetActive(false);
            TEXT4.text = "oyun ve uygulama akademisi sitesine giris yaptin";
            TEXT3.text = "oyun ve uygulama akademisinde ilerleme kaydettin";
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

            dersstat += 1;
            kalanzamanbar -= 2;
            popup.SetActive(false);
            TEXT4.text = "ders calismaya basladin";
            TEXT3.text = "ders calisip akademik basarini arttirdin";
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
    public void cikis2()
    {
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
            bar.sprite = kalanzaman[kalanzamanbar];
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

    
    public void decCount()
    {
        daycounter++;
        countDers--;
        countAkademi--;
        countertxt1.text = "Sýnava Kalan Süre:" + countDers.ToString() + "gün";
        countertxt2.text = "Akademi Sonuna Kalan Süre:" + countAkademi.ToString() + "gün";
    }

}