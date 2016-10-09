using UnityEngine;

public class Slot : MonoBehaviour
{
    public Color hoverColor;

    private GameObject phone;

    private Renderer rend;
    private Color startColor;

    private Vector3 positionOffset = new Vector3(0, 0, -1);

    // Use this for initialization
    void Start()
    {
        rend = GetComponent<Renderer>();
        startColor = rend.material.color;
    }

    void OnMouseDown()
    {
        if (phone != null)
        {
            Debug.Log("Can't place a phone here!");
            return;
        }

        GameObject phoneToBuild = Buildmanager.instance.PhoneToPlace;
        phone = (GameObject)Instantiate(phoneToBuild, transform.position + positionOffset, transform.rotation);
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnMouseEnter()
    {
        rend.material.color = hoverColor;
    }

    void OnMouseExit()
    {
        rend.material.color = startColor;
    }
}
