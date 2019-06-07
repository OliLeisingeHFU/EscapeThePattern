using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemCollider : MonoBehaviour
{
    void OnCollisionEnter()
    {
        if (this.gameObject.tag != "Knopf" || this.gameObject.tag == "Knopf" && StaticVariables.hatStift)
            Destroy(this.gameObject);
    }
}
