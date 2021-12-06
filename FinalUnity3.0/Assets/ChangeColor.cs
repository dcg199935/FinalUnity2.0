using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeColor : MonoBehaviour
{
    public Color[] colors; //colors are defined in the editor

    private Renderer thisRenderer;
    void Start()
    {
        thisRenderer = GetComponent<Renderer>();
        StartCoroutine(Blink()); // I am using a Coroutine to slow down the blink
    }

    IEnumerator Blink() // Coroutines are type IEnumerator rather than void. IEnumerators use a yield statement to pause
    {
        //this is a loop that will go for ever, because true is always true. 
        // Infinite loops are ususally bad but its is ok if there is a yield statement
        while (true)
        {
            //Random.Range returns a random number within a range. In this case between 0 and the array length
            Color newColor = colors[Random.Range(0, colors.Length)];
            thisRenderer.material.color = newColor; // set the gameObject's render material color to the random color
            yield return new WaitForSeconds(.10f); //wait for .2 sec before repeating
        }
    }
}
