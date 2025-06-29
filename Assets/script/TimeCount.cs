using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimeCount : MonoBehaviour
{



    public Text textDisplay;
    public int secondsLeft = 59;
    public int minuteLeft = 3;
    public bool takingAway = false;
    public bool takingAway2 = false;
    public static bool timeOver = false;
    void Start()
    {
        

    }

    void Update()
    {
        if (minuteLeft == 0 && secondsLeft == 0)
        {
            timeOver = true;
            takingAway = true;
            takingAway2 = true;

        }
        else
        {
            timeOver = false;
        }

        if (secondsLeft ==0)
        {
            secondsLeft = 59;
           
        }
        else if(secondsLeft == 59)
        {
            if (takingAway2 == false && minuteLeft!=0)
            {
                StartCoroutine(TimerMinute());
            }
            
            else if (takingAway == false)
            {
                StartCoroutine(TimerTake());
            }
        }
        else if (takingAway == false)
        {
            StartCoroutine(TimerTake());
        }
     

    }
    IEnumerator TimerTake()
    {
        takingAway = true;
        yield return new WaitForSeconds(1);
        secondsLeft -= 1;

        if (secondsLeft < 10)
        {
            textDisplay.text = minuteLeft+":0" + secondsLeft;
        }
        else
        {
            textDisplay.text = minuteLeft+":" + secondsLeft;
        }
 
    
        takingAway = false;

    }

    IEnumerator TimerMinute()
    {
        takingAway2 = true;
        yield return new WaitForSeconds(1);
        minuteLeft -= 1;

 
        takingAway2 = false;

    }
}
