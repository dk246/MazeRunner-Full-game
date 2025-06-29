using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class coinManage : MonoBehaviour
{
    public Text coinText;
    public static int coinBal;
    //public int tempCoinBal;
    void Start()
    {
 
        coinBal = PlayerPrefs.GetInt("coinBalance");
    }


    void Update()
    {
        if(coinBal < 0)
        {
            coinBal = 0;
        }
        coinText.text = coinBal.ToString();
    }
}
