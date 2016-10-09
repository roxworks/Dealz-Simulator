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


    /// <summary>
    /// Instantiates a new phone in clicked position if possible
    /// </summary>
    void OnMouseDown()
    {
        if (phone != null)
        {
            Debug.Log("Can't place a phone here!");
            return;
        }

        GameObject phoneToBuild = Buildmanager.instance.PhoneToPlace;

        if (Buildmanager.instance.CurrentMoney >= Buildmanager.instance.PhoneCost)
        {
            Buildmanager.instance.SubtractMoney(Buildmanager.instance.PhoneCost);
            phone = (GameObject)Instantiate(phoneToBuild, transform.position + positionOffset, transform.rotation);
            phone.GetComponent<Phone>().associatedSlot = this.gameObject;
        }
        else
        {
            Debug.Log("Not enough money to build that!");
        }

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
