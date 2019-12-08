using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class damageTest : MonoBehaviour
{
    int test1;
    int test2;
    string test3;
    private void OnTriggerEnter(Collider other)
    {
        test1 = other.gameObject.GetComponent<PlayerController>().playerBrain.pStats.accuracy;
        Debug.Log(test1);
        test2 = other.gameObject.GetComponent<PlayerController>().playerBrain.pStats.cunning;
        Debug.Log(test2);
        test3 = other.gameObject.GetComponent<PlayerController>().playerBrain.name;
        Debug.Log(test3);
    }
}
