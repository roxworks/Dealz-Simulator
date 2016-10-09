using UnityEngine;
using System.Collections;

public class Buildmanager : MonoBehaviour
{

    private GameObject phoneToPlace; //Phone that will be placed
    private int phoneCost; //Cost of phone that will be placed

    public static Buildmanager instance; //Singleton of Buildmanager

    public int currentMoney; //Current Money player has.

    public UnityEngine.UI.Text Money;
    public int numPhones;


    /// <summary>
    /// Make's sure there's only one buildManager. Initially sets phone being purchased to null.
    /// </summary>
    void Awake()
    {
        if (instance != null) { Debug.Log("More than one buildmanager!"); }
        instance = this;
        phoneToPlace = null;
        currentMoney = 20;
        numPhones = 0;
    }

    // Update is called once per frame
    void Update()
    {
        Money.text = CurrentMoney.ToString();
    }

    /// <summary>
    /// Adds money to total
    /// </summary>
    /// <param name="moneyToAdd">Amount of money to be added</param>
    public void AddMoney(int moneyToAdd)
    {
        currentMoney += moneyToAdd;
    }

    public void SubtractMoney(int moneyToSubtract)
    {
        currentMoney -= moneyToSubtract;
    }

    public int CurrentMoney
    {
        get { return currentMoney; }
    }

    /// <summary>
    /// Get/Set Phone that you want to put down
    /// </summary>
    public GameObject PhoneToPlace
    {
        get { return phoneToPlace; }
        set { phoneToPlace = value; }
    }



    public int PhoneCost
    {
        get { return phoneCost; }
        set { phoneCost = value; }
    }


}
