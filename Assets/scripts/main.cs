using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.Mathematics;
using UnityEngine;
using UnityEngine.UI;



public class main : MonoBehaviour
{
    public GameObject popup, popup2, popup3,popup4;
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
    public bool mustsleep = false;
    





    private void Start()
    {
        kalanzamanbar = 8;
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

        popup.SetActive(false);
        TEXT4.text = "okula gidiyorsun";
        TEXT3.text = "okula gidip akademik basarini arttirdin";
        Debug.Log(dersstat);
        popup2.SetActive(true);
    }
    public void disari()
    {
        sosyalstat += 2;
        kalanzamanbar -= 2;
        popup.SetActive(false);
        TEXT4.text = "disari cikiyorsun";
        TEXT3.text = "disari cikip arkadaslarin ile eglendin populerlik artti";
        popup2.SetActive(true);
    }
    public void uyu()
    {
        kalanzamanbar = 8;
        popup.SetActive(false);
        TEXT4.text = "yataga gittin";
        TEXT3.text = "guzel bir uyku cekip enerjini yeniledin";
        popup2.SetActive(true);
    }
    public void akademi()
    {
        akademistat += 1;
        kalanzamanbar -= 2;
        popup.SetActive(false);
        TEXT4.text = "oyun ve uygulama akademisi sitesine giris yaptin";
        TEXT3.text = "oyun ve uygulama akademisinde ilerleme kaydettin";
        popup2.SetActive(true);
    }
    public void ders()
    {
        dersstat += 2;
        kalanzamanbar -= 2;
        popup.SetActive(false);
        TEXT4.text = "ders calismaya basladin";
        TEXT3.text = "ders calisip akademik basarini arttirdin";
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

    }
    private void FixedUpdate()
    {
        if (kalanzamanbar <= 0)
        {
            mustsleep = true;
        }
        if(mustsleep)
        {
            popup4.SetActive(false);
            TEXT5.text = "enerjin kalmadý uyumak zorundasýn";
            popup4.SetActive(true);
        }
    }
}