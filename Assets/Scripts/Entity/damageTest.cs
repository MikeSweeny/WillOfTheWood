using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class damageTest : MonoBehaviour
{
    int test1, test9, test10, test11, test12;
    int test2;
    string test3;
    int test4, test5, test6, test7, test8;
    private void OnTriggerEnter(Collider other)
    {
        test1 = other.gameObject.GetComponent<PlayerController>().playerBrain.pStats.accuracy;
        test2 = other.gameObject.GetComponent<PlayerController>().playerBrain.pStats.cunning;
        test8 = other.gameObject.GetComponent<PlayerController>().playerBrain.pStats.discrete;
        test9 = other.gameObject.GetComponent<PlayerController>().playerBrain.pStats.pursuasive;
        test10 = other.gameObject.GetComponent<PlayerController>().playerBrain.pStats.quick;
        test11 = other.gameObject.GetComponent<PlayerController>().playerBrain.pStats.strong;
        test12 = other.gameObject.GetComponent<PlayerController>().playerBrain.pStats.vigilant;
        test3 = other.gameObject.GetComponent<PlayerController>().playerBrain.name;
        test4 = other.gameObject.GetComponent<PlayerController>().playerBrain.pSecondaryStats.painThreshold;
        test5 = other.gameObject.GetComponent<PlayerController>().playerBrain.pSecondaryStats.toughness;
        test6 = other.gameObject.GetComponent<PlayerController>().playerBrain.pSecondaryStats.armour;
        test7 = other.gameObject.GetComponent<PlayerController>().playerBrain.pSecondaryStats.defence;
        Debug.Log(" Name :" + test3);
        Debug.Log(" Armour:" + test6 + " Defence:" + test7 + " Toughness:" + test5 + " Pain Threshold:" + test4);
        Debug.Log(" Accuracy:" + test1 + " Cunning:" + test2 + " Discrete:" + test8 + " Pursuasive:" + test9 + " Quick:" + test10 + " Strong:" + test11 + " Vigilant:" + test12); 

    }
}
