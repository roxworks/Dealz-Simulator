using UnityEngine;
using System.Collections;

public class Buildmanager : MonoBehaviour {

    private GameObject phoneToPlace;
    public static Buildmanager instance;
    public GameObject standardPhonePrefab;


	// Use this for initialization
	void Awake () {
        if (instance != null) { Debug.Log("More than one buildmanager!"); }
        instance = this;
        phoneToPlace = standardPhonePrefab;
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public GameObject GetPhoneToPlace() {
        return phoneToPlace;
    }
}
