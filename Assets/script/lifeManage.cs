using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class lifeManage : MonoBehaviour
{
    public static int lifeCount;
    public Text lifeText;
    public GameObject[] lifeIcons;
    public int maxLife = 5;
    public GameObject lostPanel;
    public GameObject winPanel;
    public GameObject[] textString;
    public bool ready = false;
    public Player script_player;
    void Start()
    {
        textString[0].SetActive(false);
        textString[1].SetActive(false);
        lostPanel.SetActive(false);
        winPanel.SetActive(false);
        PlayerPrefs.SetInt("lifeBalance",5);
        lifeCount = PlayerPrefs.GetInt("lifeBalance");
        for(int x =0; x < lifeCount; x++)
        {
            lifeIcons[x].SetActive(true);
                
        }
        if (lifeCount < maxLife)
        {
            for (int y = (maxLife - lifeCount) + 1; y < maxLife; y++)
            {
                lifeIcons[y].SetActive(false);
            }
        }
        
    }

    void Update()
    {
        print(lifeCount);
        if (lifeCount <= 0)
        {
            lifeCount = 0;
            MissionFail();
            //lostPanel.SetActive(true);
        }
        for (int x = 0; x < lifeCount; x++)
        {
            lifeIcons[x].SetActive(true);
            
        }
        if (lifeCount < maxLife)
        {
            for (int y = lifeCount; y < maxLife; y++)
            {
                lifeIcons[y].SetActive(false);
            }
        }
        if(Input.GetKey("space"))
        {
            healed();
        }

        if(TimeCount.timeOver == true)
        {
            MissionFail();
        }
    }

    public void MissionFail()
    {
        lostPanel.SetActive(true);
        script_player.enabled = false;

    }

    public void MissionPassed()
    {
        winPanel.SetActive(true);

        script_player.enabled = false;
    }

    public void healed()
    {
        if(lifeCount == maxLife)
        {
            textString[0].SetActive(true);
            StartCoroutine(Hide_());
        }
        else if(vaccineManage.vaccineBal == 0)
        {
            textString[1].SetActive(true);
            StartCoroutine(Hide_());
        }
        else if(!ready)
        {
            StartCoroutine(ReadtTo());
        }
    }

    IEnumerator ReadtTo()
    {
        ready = true;
        yield return new WaitForSeconds(1);
        vaccineManage.vaccineBal -= 1;
        PlayerPrefs.SetInt("vaccineBalance", vaccineManage.vaccineBal);
        lifeCount += 1;
        ready = false;


    }

    IEnumerator Hide_()
    {
    
        yield return new WaitForSeconds(2);
        textString[0].SetActive(false);
        textString[1].SetActive(false);

    }

}
