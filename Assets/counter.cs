using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class counter : MonoBehaviour
{
    [SerializeField]
    private Text myText;
    private int i = 0;

    public void count(){
        i++;
        myText.text = "The number of clicks are: " + i;
        Debug.Log("Mamacita!");
    }
}