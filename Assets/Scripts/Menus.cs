using UnityEngine;
using System.Collections;

public class Menus : MonoBehaviour {


	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public void LookAtMenu(Transform menuTransform) {
        Camera.main.transform.LookAt(menuTransform.position);
    }
}
