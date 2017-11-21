using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickerScript : MonoBehaviour {

    public UnityEngine.UI.Text DepressionDisplay;

    public int depression = 0;

    public int depressionperclick = 1;


    void Update()
    {
        DepressionDisplay.text = "Depression: " + depression;
        

    }


    public void Clicked()
    {
        depression += depressionperclick;



    }























}
