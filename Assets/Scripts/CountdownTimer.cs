using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CountdownTimer : MonoBehaviour
{
    float startingTime = 5f;
    public static float temp;
    public static int cal=0;

    public Text CountdownText;
    void Update()
    {
	if (startingTime<0.5){
	startingTime=5f;
	boosters.num += 1;
	}	
	if ((cal==boosters.num) && startingTime>0)
	{
        startingTime -= 1 * Time.deltaTime;
        //print (currentTime);
        CountdownText.text = "TIMER:" + startingTime.ToString ("0");

        if(startingTime>=3.5f){CountdownText.color = Color.black;}
        if(startingTime<3.5f){CountdownText.color = Color.red;}
	}
	
        
    }
}
