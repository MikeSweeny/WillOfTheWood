using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectableItems : MonoBehaviour, IQuestID
{
    public string ID { get; set; }

    PlayerController PC;


    public void OnInteract()
    {
        gameObject.SetActive(false);
        Cleared();

        Invoke("reset", 10);
    }

    private void OnTriggerEnter(Collider other)
    {
        PC = other.GetComponent<PlayerController>();

        if (other.gameObject.tag == "Player")
        {
            gameObject.SetActive(false);
            Cleared();
        }
        this.Invoke("reset", 10);

    }

    void reset()
    {
        gameObject.SetActive(true);
    }
    public void Cleared()
    {
        QuestEvents.ItemCleared(this);
    }

}
