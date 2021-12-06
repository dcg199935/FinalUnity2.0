using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorFade : MonoBehaviour
{
    public float speed = 1f;
    public Color[] colors; // color array is defined in the editor

    private Renderer thisRenderer;
    void Start()
    {
        thisRenderer = GetComponent<Renderer>();
        StartCoroutine(ChangeColor());
    }

    IEnumerator ChangeColor()
    {
        while (true) //repeat the process again and again
        {
            //save the current color
            Color oldColor = thisRenderer.material.color;
            //pick a new random color from the array
            Color newColor = colors[Random.Range(0, colors.Length)];

            float t = 0; // t represents time 
            while (t < 1) // while time is less than 1
            {
                //a lerp smothes a value from a to b as t goes from 0 to 1
                //set the gameobject's renderer material color to the transitional color
                thisRenderer.material.color = Color.Lerp(oldColor, newColor, t);
                t += speed * Time.deltaTime; // we add to 't' the time between frames times speed 
                yield return null; //this pauses the loop for 1 frame. We need this to give it time to update the screen
            }
        }
    }
}
