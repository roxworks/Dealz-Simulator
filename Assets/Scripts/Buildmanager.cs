using UnityEngine;
using System.Collections;

public class Buildmanager : MonoBehaviour
{

    private GameObject phoneToPlace; //Phone that will be placed
    public static Buildmanager instance; //Singleton of Buildmanager

    public int currentMoney; //Current Money player has.


    /// <summary>
    /// Make's sure there's only one buildManager. Initially sets phone being purchased to null.
    /// </summary>
    void Awake()
    {
        if (instance != null) { Debug.Log("More than one buildmanager!"); }
        instance = this;
        phoneToPlace = null;
    }

    // Update is called once per frame
    void Update()
    {

    }

    /// <summary>
    /// Adds money to total
    /// </summary>
    /// <param name="moneyToAdd">Amount of money to be added</param>
    public void AddMoney(int moneyToAdd) {
        currentMoney += moneyToAdd;
    }

    /// <summary>
    /// Get/Set Phone that you want to put down
    /// </summary>
    public GameObject PhoneToPlace
    {
        get { return phoneToPlace; }
        set { phoneToPlace = value; }
    }

}
