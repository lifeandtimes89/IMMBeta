using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Repository : MonoBehaviour
{
    // Start is called before the first frame update
    

    // Update is called once per frame
   public void OpenURL ()
    {
        Application.OpenURL("https://github.com/lifeandtimes89/IMMBeta");
        Debug.Log("Hopefully its working");
    }
}
