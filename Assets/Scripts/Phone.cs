using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Phone : MonoBehaviour {

    // initialize variables
    public string phoneName = "default";
    public string phoneStatus = "default";
    public bool functionality = true;       // true if phone did not crash, 
    private GameObject phone;

    public float currencyRate = 0;      // how often phone makes money
    public float originalRate = 0;      // original rate of currencer
    public int moneyCount = 0;          // total monies

    public double explodeChance = -1;   // chance of phone exploding
    public double crashChance = -1;     // chance of phone crashing

    public int level = -1;              // level of phone
    

	// Update is called once per frame
	void Update ()
    {
        if (functionality == true)
        {
            // count down timer
            currencyRate -= Time.deltaTime;

            if (currencyRate <= 0)
            {
                // reverts to original to restart timer, and adds money
                currencyRate = originalRate;
                moneyCount += 1;

                int explodeGenerator = Random.Range(0, 101);    // generate a number for explodeChance
                int crashGenerator = Random.Range(0, 101);      // for crashChance

                if (explodeGenerator <= explodeChance)  // check explosion number to determine if phone ded
                {
                    print(phoneName + "Gone Done Did Explode");
                    Destroy(gameObject);
                }

                if (crashGenerator <= crashChance)
                {
                    print(phoneName + "Gone Done Crashed");
                    functionality = false;
                }
            }
        }
        else
        {
            //print("NOT WORKING");  
            currencyRate = originalRate;          
        } 
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
        }
    }
}