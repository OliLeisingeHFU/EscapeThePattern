using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level1script : MonoBehaviour
{
    // Start is called before the first frame update
    public static void Resetti()
    {
    StaticVariables.tcount = 7;
    StaticVariables.timesWokenUp = 1;
    StaticVariables.code = 0;

    StaticVariables.hatStift = false;
    StaticVariables.hatBrille = false;
    StaticVariables.sleeping = false;
}


}
