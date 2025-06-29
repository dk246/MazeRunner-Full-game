using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartPannel : MonoBehaviour
{
    public GameObject startPannel;
    public int hide;

    private void Awake()
    {

        hide = PlayerPrefs.GetInt("hideButton");
        if (hide == 1)
        {
            startPannel.SetActive(false);
        }
        
       
    }

    public void startButton()
    {
   
        PlayerPrefs.SetInt("LevelNo", 1);
        PlayerPrefs.SetInt("hideButton", 1);

        startPannel.SetActive(false);
    }



}
