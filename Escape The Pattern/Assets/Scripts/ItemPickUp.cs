using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemPickUp : MonoBehaviour
{
    public GameObject inventoryPanel;
    public GameObject item;

    // Start is called before the first frame update
    void OnCollisionEnter()
    {
        GameObject i;
        i = Instantiate(item);
        i.transform.SetParent(inventoryPanel.transform);
    }

}



