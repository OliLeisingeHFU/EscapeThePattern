using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ItemPickUp : MonoBehaviour
{
    public GameObject info;
    public GameObject item;
    public GameObject topf;
    public GameObject topfModel;
    public GameObject stuhl;
    public GameObject stuhlModel;
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
            PickingUp(this.gameObject);
            CharacterController.tip.gameObject.SetActive(false);
            SceneManager.LoadSceneAsync("Sleeping", LoadSceneMode.Single);

        }

        if (this.gameObject.tag == "Brille" && Input.GetKeyDown(KeyCode.E))
        {
            StaticVariables.hatBrille = true;
            PickingUp(this.gameObject);
            CharacterController.tip.gameObject.SetActive(false);
        }

        if (this.gameObject.name == "TopfForm" && Input.GetKeyDown(KeyCode.E) && !StaticVariables.hatStuhl)
        {
            StaticVariables.hatTopf = true;
            GameObject i;
            i = Instantiate(topf);
            i.transform.SetParent(inventoryPanel.transform);
            this.GetComponent<MeshRenderer>().enabled = false;
        }
        if (this.gameObject.name == "StuhlForm" && Input.GetKeyDown(KeyCode.E) && !StaticVariables.hatTopf)
        {
            StaticVariables.hatStuhl = true;
            GameObject i;
            i = Instantiate(stuhl);
            i.transform.SetParent(inventoryPanel.transform);
            this.GetComponent<MeshRenderer>().enabled = false;
        }

        if (this.gameObject.name == "Holo" && Input.GetKeyDown(KeyCode.E) && StaticVariables.hatStuhl)
        {
            StaticVariables.hatStuhl = false;
            GameObject i;
            i = Instantiate(stuhlModel);
            i.transform.SetParent(this.transform);
            this.GetComponent<MeshRenderer>().enabled = false;
        }
        if (this.gameObject.name == "Holo2" && Input.GetKeyDown(KeyCode.E) && StaticVariables.hatTopf)
        {
            StaticVariables.hatTopf = false;
            GameObject i;
            i = Instantiate(topfModel);
            i.transform.SetParent(this.transform);
            this.GetComponent<MeshRenderer>().enabled = false;

        }
    }

    void PickingUp(GameObject obj)
    {
        Destroy(obj);
        return;
    }
}



