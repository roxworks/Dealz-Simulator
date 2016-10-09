using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class MoneyHandler : MonoBehaviour {
    public float totalMoney = 0.0f;
    public float mps = 0.0f;
    public Text totalMoneyTxt;
    public Text mpsTxt;

    // Use this for initialization
    void Start()
    {
        GameObject[] phones = GameObject.FindGameObjectsWithTag("Phones");
    }

    // Update is called once per frame
    void Update()
    {
        mpsTxt.text = mps + " Money/Second";
        totalMoneyTxt.text = totalMoney.ToString("F1") + " Dollars";
    }
}
