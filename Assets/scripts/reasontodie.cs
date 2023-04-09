using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class reasontodie : MonoBehaviour
{
    [SerializeField] public TMP_Text deadreason;
    void Start()
    {
        if(PlayerPrefs.GetInt("reason")==1)
        {
            deadreason.text = "Sosyal hayatin bitti";

        }
        else 
        {
            if (PlayerPrefs.GetInt("reason") == 2)
            {
                deadreason.text = "Sinifta kaldin";

            }
            else
            {
                if (PlayerPrefs.GetInt("reason") == 3)
                {
                    deadreason.text = "Oyun ve Uygulama Akedemisi gorevlerini zamaninda tamamlayamadin";

                }
                else
                {
                    if (PlayerPrefs.GetInt("reason") == 4)
                    {
                        deadreason.text = "Sinavdan kaldin";

                    }
                }
            }
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
