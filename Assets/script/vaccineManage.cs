using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class vaccineManage : MonoBehaviour
{
    public Text vaccineText;
    public static int vaccineBal;
    public GameObject vaccineBuyText;
    public GameObject coinOverText;
    void Start()
    {
        vaccineBal = PlayerPrefs.GetInt("vaccineBalance");
    }

    // Update is called once per frame
    void Update()
    {
        vaccineText.text = vaccineBal.ToString();
    }

    public void BuyVaccine()
    {
        if(coinManage.coinBal < 10)
        {
            coinOverText.SetActive(true);
            StartCoroutine(Hide_());
        }
        else
        {
            vaccineBal += 1;
            PlayerPrefs.SetInt("vaccineBalance", vaccineBal);
            vaccineBuyText.SetActive(true);
            coinManage.coinBal -= 10;
            PlayerPrefs.SetInt("coinBalance", coinManage.coinBal);
            StartCoroutine(Hide_());
        }
 
    }

    IEnumerator Hide_()
    {

        yield return new WaitForSeconds(1);
        vaccineBuyText.SetActive(false);

        coinOverText.SetActive(false);
    }
}
