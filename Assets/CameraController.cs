using UnityEngine;
using System.Collections;

public class CameraSwitcher : MonoBehaviour {
	public GameObject camera1;
	public GameObject camera2;
	public GameObject camera3;
	public GameObject camera4;

	public void EnableCamera1() {
		camera1.SetActive(true);
		camera2.SetActive(false);
		camera3.SetActive(false);
		camera4.SetActive(false);
	}
	public void EnableCamera2() {
		camera1.SetActive(false);
		camera2.SetActive(true);
		camera3.SetActive(false);
		camera4.SetActive(false);
	}
	public void EnableCamera3() {
		camera1.SetActive(false);
		camera2.SetActive(false);
		camera3.SetActive(true);
		camera4.SetActive(false);
	}
	public void EnableCamera4() {
		camera1.SetActive(false);
		camera2.SetActive(false);
		camera3.SetActive(false);
		camera4.SetActive(true);
	}
}
