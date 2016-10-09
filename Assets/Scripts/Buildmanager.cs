using UnityEngine;
using System.Collections;

public class Buildmanager : MonoBehaviour
{

    private GameObject phoneToPlace;
    public static Buildmanager instance;
    public GameObject standardPhonePrefab;

    public int currentMoney;


    // Use this for initialization
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

    public void AddMoney(int moneyToAdd) {
        currentMoney += moneyToAdd;
    }

    public GameObject PhoneToPlace
    {
        get { return phoneToPlace; }
        set { phoneToPlace = value; }
    }

}
