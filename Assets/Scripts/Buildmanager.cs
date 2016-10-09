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
    private bool marc;
    private bool guy;
    private bool steven;


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
        if (currentMoney > 1000) {
            Money.text = "win";
        }
        else if (currentMoney < 10 && numPhones < 1)
        {
            Money.text = "lose";
        }
        else
        {
            Money.text = CurrentMoney.ToString();
        }
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
        if (marc)
        {
            currentMoney -= moneyToSubtract * (9 / 10);
        }
        else {
            currentMoney -= moneyToSubtract;
        }
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

    public bool Marc
    {
        get { return marc; }
        set
        {
            if (currentMoney >= 16 && !marc)
            {
                marc = value;
                currentMoney-=16;
            }
        }
    }

    public bool Guy
    {
        get { return guy; }
        set
        {
            if (currentMoney >= 24 && !guy)
            {
                guy = value;
                currentMoney-=24;
            }
        }
    }

    public bool Steven
    {
        get { return steven; }
        set
        {
            if (currentMoney >= 100 && !steven)
            {
                steven = value;
                currentMoney-=100;
            }
        }
    }

}
