using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEnginge.UI;

public class ItemPickUp : MonoBehaviour
{
    public GameObject inventoryPanel;
    public GameObject item;
    // Start is called before the first frame update
    void OnCollisionEnter(Collision colision)
    {
        i = Instantiate(item);
        if.transform.SetParent(inventoryPanel.transform);
    }

}



