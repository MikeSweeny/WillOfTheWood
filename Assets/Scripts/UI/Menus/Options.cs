using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MOptions : Menu
{
    // Start is called before the first frame update
    void Start()
    {
        UIEventManager.OpenOptions += OpenMenu;
        UIEventManager.CloseOptions += CloseMenu;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
