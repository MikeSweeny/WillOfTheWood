//FILE : FillerNPC
//PROJECT : Will of the Woods
//PROGRAMMER : Rebecca Stewart
//FIRST VERSION : 08/01/2019

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//NAME : FillerNPC
//PURPOSE : To allow not interacting NPCs to say Hello, and face the NPC upon Interaction. 
public class FillerNPC : BaseInteractableNpc
{
    public AudioSource source;
    private void Awake()
    {
        source = GetComponent<AudioSource>();
    }
    public override void NextDialogue() { }

    public override void OnInteract()
    {
        if (source)
            source.Play();
    }
}
