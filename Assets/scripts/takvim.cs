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
        
        
        countertxt.text="S�nava Kalan S�re:"+count.ToString()+"g�n";
    }

    public void decCount()
    {
        count--;
        countertxt.text = "S�nava Kalan S�re:" + count.ToString() + "g�n";
    }
}
