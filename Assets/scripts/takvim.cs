using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class takvim : MonoBehaviour
{
    public TMP_Text countertxt;
    public int count;
    void Start()
    {
        
        
        countertxt.text="Sýnava Kalan Süre:"+count.ToString()+"gün";
    }

    public void decCount()
    {
        count--;
        countertxt.text = "Sýnava Kalan Süre:" + count.ToString() + "gün";
    }
}
