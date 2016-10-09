using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System;

public class Phone : MonoBehaviour
{

    // initialize variables
    public string phoneName = "default";
    public string phoneStatus = "default";
    public bool functionality = true;       // true if phone did not crash, 

    public float currencyRate = 0;      // how often phone makes money
    public float originalRate = 0;      // original rate of currencer
    public int moneyCount = 0;          // total monies


    public double explodeChance = -1;   // chance of phone exploding
    public double crashChance = -1;     // chance of phone crashing

    public int level = -1;              // level of phone
    private int cost = 0;              // cost of phone

    public GameObject associatedSlot;
    public Sprite defaultSprite;
    public Sprite crashSprite;

    // Update is called once per frame
    virtual protected void Update()
    {
        if (functionality == true)
        {
            // count down timer
            currencyRate -= Time.deltaTime;

            if (currencyRate <= 0F)
            {
                // reverts to original to restart timer, and adds money
                currencyRate = originalRate;

                if (Buildmanager.instance.Steven)
                {
                    Buildmanager.instance.AddMoney(moneyCount * 2); //calls the BuildManager method, AddMoney, and runs it, inserting the parameter.
                }
                else
                {
                    Buildmanager.instance.AddMoney(moneyCount);
                }



                int explodeGenerator = UnityEngine.Random.Range(0, 101);    // generate a number for explodeChance
                int crashGenerator = UnityEngine.Random.Range(0, 101);      // for crashChance

                if (Buildmanager.instance.Guy)
                {
                    if (explodeGenerator <= explodeChance / 2)  // check explosion number to determine if phone ded
                    {
                        print(phoneName + "Gone Done Did Explode");
                        Destroy(gameObject);
                        Destroy(associatedSlot);
                        Buildmanager.instance.numPhones--;
                    }

                    if (crashGenerator <= crashChance / 2)
                    {
                        print(phoneName + "Gone Done Crashed");
                        functionality = false;
                        this.GetComponent<SpriteRenderer>().sprite = crashSprite;
                    }
                }
                else
                {
                    if (explodeGenerator <= explodeChance)  // check explosion number to determine if phone ded
                    {
                        print(phoneName + "Gone Done Did Explode");
                        Destroy(gameObject);
                        Destroy(associatedSlot);
                        Buildmanager.instance.numPhones--;
                    }

                    if (crashGenerator <= crashChance)
                    {
                        print(phoneName + "Gone Done Crashed");
                        functionality = false;
                        this.GetComponent<SpriteRenderer>().sprite = crashSprite;
                    }
                }

            }
        }
        else
        {
            //print("NOT WORKING");  
            currencyRate = originalRate;
        }
    }

    public static explicit operator Phone(GameObject v)
    {
        throw new NotImplementedException();
    }

    void OnMouseDown()
    {
        if (functionality == true)
        {
            Debug.Log("Nothing to Fix Here!");
            return;
        }
        else
        {
            functionality = true;
            Debug.Log("ALL BETTER NOW");
            this.GetComponent<SpriteRenderer>().sprite = defaultSprite;
        }
    }

    public int Cost
    {
        get { return cost; }
        set { cost = value; }
    }


}