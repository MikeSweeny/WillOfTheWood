//FILE          :   HTargetStatus.cs
//PROJECT       :   Will of the Wood
//PROGRAMMER    :   Gavin McGuire
//FIRST VERSION :   17/12/2019
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

//NAME : HTargetStatus
//PURPOSE : retrieves the target status info
public class HTargetStatus : HUDElement
{

    private CharacterBase target;
    private Slider healthBar;
    public Text nameText { get; set; }

    //Function : Start
    //DESCRIPTION : called when the object is initialized after Awake
    //PARAMETERS : none
    //RETURNS : none
    private void Start()
    {
        healthBar = transform.Find("HealthBar").GetComponent<Slider>();
        nameText = transform.Find("TargetName").GetComponent<Text>();
    }

    //Function : UpdateElement
    //DESCRIPTION : Updates the relevant information to the element
    //PARAMETERS : none
    //RETURNS : none
    public override void UpdateElement()
    {
        if (player.FindPlayerTarget() != null && !player.FindPlayerTarget().CompareTag("Player"))
        {
            target = player.FindPlayerTarget().GetComponent<CharacterBase>();
            if(target)
            {
                healthBar.value = target.GetHealthPercent();
                nameText.text = target.CharacterName;
            }

        }
        else
        {
            target = null;
            nameText.text = "";
            healthBar.value = 0;
        }
            
    }
}
