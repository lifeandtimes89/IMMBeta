﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Repository : MonoBehaviour
{

    // Opens Github repository
    public string Url;
    

  
   public void Open()
    {
        Application.OpenURL(Url);
        Debug.Log("Hopefully its working");
    }
}
