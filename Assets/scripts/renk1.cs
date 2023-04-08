using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class renk1 : MonoBehaviour
{
    public Renderer degistirici;

    public Color originalColor1, originalColor2, originalColor3;


    void Start()
    {
    }

    private void OnMouseEnter()
    {
        degistirici.materials[0].color = Color.green;
        degistirici.materials[1].color = Color.green;
        degistirici.materials[2].color = Color.green;
    }

    private void OnMouseExit()
    {
        degistirici.materials[0].color = originalColor1;
        degistirici.materials[1].color = originalColor2;
        degistirici.materials[2].color = originalColor3;
    }
}
