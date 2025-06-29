using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class coin : MonoBehaviour
{
    
    void Start()
    {
        
    }


    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
           
            coinManage.coinBal += 1;
            PlayerPrefs.SetInt("coinBalance", coinManage.coinBal);
            gameObject.SetActive(false);
        }
    }
}
