using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeScene : MonoBehaviour
{
    
 
    //Changes to different scenes in the UI
   
    public void ChangeToScene (int sceneToChangeTo)
    {
        Application.LoadLevel(sceneToChangeTo);
    }
}
