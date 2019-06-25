using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ItemPickUp : MonoBehaviour
{
    public GameObject info;
    public GameObject item;
    public GameObject Canvas;
    public GameObject inventoryPanel;
    

    // Start is called before the first frame update
    void OnTriggerEnter()
    {
        CharacterController.tip.gameObject.SetActive(true);
    }

    void OnTriggerExit()
    {
        CharacterController.tip.gameObject.SetActive(false);
    }

    void OnTriggerStay(Collider collision)
    {


        Debug.Log("berührt " + this.gameObject.tag);

        if (this.gameObject.tag == "Stift" && Input.GetKeyDown(KeyCode.E))
        {

            StaticVariables.hatStift = true;
            GameObject i;
            i = Instantiate(item);
            i.transform.SetParent(inventoryPanel.transform);
            PickingUp(this.gameObject);
        }

        if (this.gameObject.tag == "Knopf" && StaticVariables.hatStift && Input.GetKeyDown(KeyCode.E))
        {
            PickingUp(this.gameObject);
            LevelLoader.LoadNextLevel();
        }

        if (this.gameObject.tag == "Bett" && Input.GetKeyDown(KeyCode.E))
        {
            CharacterController.tip.gameObject.SetActive(false);
            SceneManager.LoadSceneAsync("Sleeping", LoadSceneMode.Additive);
        }

        if (this.gameObject.tag == "Brille" && Input.GetKeyDown(KeyCode.E))
        {
            StaticVariables.hatBrille = true;
            PickingUp(this.gameObject);
            CharacterController.tip.gameObject.SetActive(false);
        }
    }



    void PickingUp(GameObject obj)
    {
        Destroy(obj);
        return;
    }
}



