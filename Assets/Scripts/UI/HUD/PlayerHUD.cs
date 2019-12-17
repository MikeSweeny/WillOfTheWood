using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHUD : MonoBehaviour
{
    private List<HUDElement> elements;

    // Start is called before the first frame update
    void Awake()
    {
        for (int i = 0; i < transform.childCount; ++i)
        {
            elements.Add(transform.GetChild(i).GetComponent<HUDElement>());
        }
    }

    // Update is called once per frame
    void Update()
    {
        foreach (HUDElement element in elements)
        {
            element.UpdateElement();
        }
    }
}
