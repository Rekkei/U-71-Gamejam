using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.GraphicsBuffer;
using UnityEngine.UI;
using TMPro;

public class clickpointer : MonoBehaviour
{

    public GameObject popup, text1, text2;
    public TMP_Text TEXT1, TEXT2, TEXT3;
    public static int durum;



    void Start()
    {
        popup.SetActive(false);
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            var ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            if(Physics.Raycast(ray, out hit))
            {
                var selection = hit.transform;
                var selectionrenderer = selection.GetComponent<Renderer>();
                if(selectionrenderer!= null)
                {
                    if (selectionrenderer.CompareTag("pc"))
                    {
                        Debug.Log("pc");
                        durum = 1;
                        text1.SetActive(true);
                        text2.SetActive(true);
                        TEXT3.text = "Bilgisayar";
                        
                        TEXT1.text = "Oyun ve Uygulama Akedemisi egitimlerini izle";
                        TEXT2.text = "Ders calis";



                        popup.SetActive(true);
                    }
                    if (selectionrenderer.CompareTag("door"))
                    {
                        Debug.Log("door");
                        durum = 2;
                        TEXT3.text = "Kapi";
                        text1.SetActive(true);
                        text2.SetActive(true);
                        
                        TEXT1.text = "Okula git";
                        TEXT2.text = "Arkadaslarinla disari cik";
                        popup.SetActive(true);
                    }
                    if (selectionrenderer.CompareTag("yatak"))
                    {
                        Debug.Log("yatak");
                        durum = 3;
                        TEXT3.text = "Yatak";
                        text1.SetActive(true);
                        text2.SetActive(false);
                        
                        TEXT1.text = "Uyu";
                        popup.SetActive(true);
                    }

                }
            }

            
        }
    }
}
