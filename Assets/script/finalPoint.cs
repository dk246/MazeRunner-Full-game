using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class finalPoint : MonoBehaviour
{
    public lifeManage plr;
    void Start()
    {


    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            plr.MissionPassed();
        }
    }
}
