using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class CharacterController : MonoBehaviour
{
    public float speed = 10.0f;
    public GameObject TextBox;
    // Start is called before the first frame update
    void Start()
    {
        SceneManager.UnloadSceneAsync("Sleeping");
        SceneManager.UnloadSceneAsync("Menu");
        Cursor.lockState = CursorLockMode.Locked;

        TextBox.GetComponent<Text>().text = "" + StaticVariables.tcount + " Uhr";
    }

    // Update is called once per frame
    void Update()
    {
        float translation = Input.GetAxis("Vertical") * speed;
        float straffe = Input.GetAxis("Horizontal") * speed;
        translation *= Time.deltaTime;
        straffe *= Time.deltaTime;

        transform.Translate(straffe, 0, translation);

        if (Input.GetKeyDown("escape"))
            Cursor.lockState = CursorLockMode.None;
    }
}
