////FILE          :   Poisoner.cs
////PROJECT       :   Will of the Wood
////PROGRAMMER    :   Jonathan Parsons
////FIRST VERSION :   31/12/2019
//using UnityEngine;
//[CreateAssetMenu(fileName = "Poisoner()", menuName = "Abilities/Poisoner")]
////NAME : NaturalWarrior
////PURPOSE : All the funcionality of the NaturalWarrior ability as a child of abilities
//public class Poisoner : Abilities
//{
//    private bool isActive { get; set; }
//    //Function : OnLoad
//    //DESCRIPTION : what happens when the script is loaded in the game
//    //PARAMETERS : none
//    //RETURNS : none
//    public override void OnLoad()
//    {
//        isActive = false;
//        if (isCollected)
//        {
//            if (isNovice)
//            {
//                if (isActive)
//                {
//                    NoviceLevelAct();
//                }
//            }
//            else if (isAdept)
//            {
//                if (isActive)
//                {
//                    AdeptLevelAct();
//                }
//            }
//            else if (isMaster)
//            {
//                if (isActive)
//                {
//                    MasterLevelAct();
//                }
//            }
//        }
//    }
//    //Function : noviceLevelAct
//    //DESCRIPTION : what happens when the novice level of the spell is used
//    //PARAMETERS : none
//    //RETURNS : none
//    public override void NoviceLevelAct()
//    {
//        if (isActive)
//        {
//        isNovice = true;
//        //equippedWeapon == isPoisonous;
//        //if successfully hit enemy, apply poison damage for x ammount of time to enemy and remove poison status from weapon.
//        }
//    }
//    //Function : AdeptLevelAct
//    //DESCRIPTION : what happens when the adept level of the spell is used
//    //PARAMETERS : none
//    //RETURNS : none
//    public override void AdeptLevelAct()
//    {
//        if (isActive)
//        {
//            isAdept = true;
//            //equippedWeapon == isPoisonous;
//            //if successfully hit enemy, apply poison damage for x ammount of time to enemy
//            //remove poison effect from equipped weapon when combat is over.
//        }
//    }
//    //Function : MasterLevelAct
//    //DESCRIPTION : what happens when the master level of the spell is used
//    //PARAMETERS : none
//    //RETURNS : none
//    public override void MasterLevelAct()
//    {
//        if (isActive)
//        {
//            isMaster = true;
//            //equippedWeapon == isPoisonous;
//            //if successfully hit enemy, apply 2x poison damage for x ammount of time to enemy
//            //remove poison effect from equipped weapon when combat is over.
//        }
//    }
//}
