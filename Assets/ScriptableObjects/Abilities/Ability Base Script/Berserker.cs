////FILE          :   Berserker.cs
////PROJECT       :   Will of the Wood
////PROGRAMMER    :   Jonathan Parsons
////FIRST VERSION :   30/12/2019

//using UnityEngine;
//[CreateAssetMenu(fileName = "Berserker()", menuName = "Abilities/Berserker")]
////NAME : Berserker
////PURPOSE : All the funcionality of the berserker ability as a child of abilities
//public class Berserker : Abilities
//{
//    private bool isActive { get; set; }
//    PlayerStats stats;
//    //Function : OnLoad
//    //DESCRIPTION : what happens when the script is loaded in the game
//    //PARAMETERS : none
//    //RETURNS : none
//    public override void OnLoad()
//    {
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
//        stats.defence = stats.defence - 2;
//        if (stats.defence <= 0)
//        {
//            stats.defence = 0;
//        }

//        if (isActive)
//        {
//            isNovice = true;
//            //equipped weapon deals additional 1-6 damage
//        }
//    }
//    //Function : AdeptLevelAct
//    //DESCRIPTION : what happens when the adept level of the spell is used
//    //PARAMETERS : none
//    //RETURNS : none
//    public override void AdeptLevelAct()
//    {
//        stats.defence = stats.defence - 2;
//        if (stats.defence <= 0)
//        {
//            stats.defence = 0;
//        }

//        if (isActive)
//        {
//            isAdept = true;
//            //equipped weapon deals additional 1-6 damage
//            //player takes 1-4 less damage from enemies while activated
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
//            //equipped weapon deals additional 1-6 damage
//            //player takes 1-4 less damage from enemies while activated
//        }
//    }
//}
