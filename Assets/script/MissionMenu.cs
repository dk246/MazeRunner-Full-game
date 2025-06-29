using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MissionMenu : MonoBehaviour
{
    public Button[] missionBtns;
    void Start()
    {
        print(buttons.levelNo);
        for (int x = 0; x < buttons.levelNo; x++)
        {
            missionBtns[x].interactable = true;
        }
    }

    // Update is called once per frame
    void Update()
    {
        


    }
}
