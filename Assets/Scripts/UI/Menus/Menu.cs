using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Menu : MonoBehaviour
{
    protected void OpenMenu()
    {
        gameObject.SetActive(true);
    }

    protected void CloseMenu()
    {
        gameObject.SetActive(false);
    }
}
