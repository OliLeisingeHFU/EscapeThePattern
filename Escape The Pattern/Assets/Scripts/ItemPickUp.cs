using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ItemPickUp : MonoBehaviour
{
    public GameObject inventoryPanel;
    public GameObject item;
    public GameObject Canvas;
    public GameObject WinPanel;
    

    // Start is called before the first frame update
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Stift")
        {
            StaticVariables.hatStift = true;
            GameObject i;
            i = Instantiate(item);
            i.transform.SetParent(inventoryPanel.transform);
        }

        if (collision.gameObject.tag == "Knopf" && StaticVariables.hatStift)
        {
            GameObject i;
            i = Instantiate(WinPanel);
            i.transform.SetParent(Canvas.transform);
        }

        if (collision.gameObject.tag == "Bett")
        {
            SceneManager.LoadScene("Sleeping", LoadSceneMode.Additive);
        }
    }

}



