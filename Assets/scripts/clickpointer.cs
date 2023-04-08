using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.GraphicsBuffer;

public class clickpointer : MonoBehaviour
{

    

   

    void Start()
    {
       
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
                    }
                    if (selectionrenderer.CompareTag("door"))
                    {
                        Debug.Log("door");
                    }
                    if (selectionrenderer.CompareTag("yatak"))
                    {
                        Debug.Log("yatak");
                    }

                }
            }

            
        }
    }
}
