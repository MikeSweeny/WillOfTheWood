//FILE          :   AbilityManager.cs
//PROJECT       :   Will of the Wood
//PROGRAMMER    :   Jonathan Parsons
//FIRST VERSION :   07/1/2020
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AbilityManager : MonoBehaviour
{
    public delegate void AbilityEvent();

    public static event AbilityEvent UnlockAtArms;
    public static event AbilityEvent UnlockBackStab;
    public static event AbilityEvent UnlockBerserker;
    public static event AbilityEvent UnlockDominate;
    public static event AbilityEvent UnlockExceptionalAttribute;
    public static event AbilityEvent UnlockFeign;
    public static event AbilityEvent UnlockPoisoner;
    public static event AbilityEvent UnlockPoleArmMastery;
    public static event AbilityEvent UnlockRecovery;
    public static event AbilityEvent UnlockShieldFighter;
    public static event AbilityEvent UnlockTwinAttack;
    public static event AbilityEvent UnlockTwoHandedForce;

    //Function : TriggerUnlockAtArms
    //DESCRIPTION : Unlocks AtArms
    //PARAMETERS : none
    //RETURNS : none
    public static void TriggerUnlockAtArms()
    {
        if (UnlockAtArms != null)
            UnlockAtArms();
    }
    //Function : TriggerUnlockBackStab
    //DESCRIPTION : Unlocks BackStab
    //PARAMETERS : none
    //RETURNS : none
    public static void TriggerUnlockBackStab()
    {
        if (UnlockBackStab != null)
            UnlockBackStab();
    }
    //Function : TriggerUnlockBerserker
    //DESCRIPTION : Unlocks Berserker
    //PARAMETERS : none
    //RETURNS : none
    public static void TriggerUnlockBerserker()
    {
        if (UnlockBerserker != null)
            UnlockBackStab();
    }
    //Function : TriggerUnlockDominate
    //DESCRIPTION : Unlocks Dominate
    //PARAMETERS : none
    //RETURNS : none
    public static void TriggerUnlockDominate()
    {
        if (UnlockDominate != null)
            UnlockDominate();
    }
    //Function : TriggerUnlockExceptionalAttribute
    //DESCRIPTION : Unlocks ExceptionalAttribute
    //PARAMETERS : none
    //RETURNS : none
    public static void TriggerUnlockExceptionalAttribute()
    {
        if (UnlockExceptionalAttribute != null)
            UnlockExceptionalAttribute();
    }
    //Function : TriggerUnlockFeign
    //DESCRIPTION : Unlocks Feign
    //PARAMETERS : none
    //RETURNS : none
    public static void TriggerUnlockFeign()
    {
        if (UnlockFeign != null)
            UnlockFeign();
    }
    //Function : TriggerUnlockPoisoner
    //DESCRIPTION : Unlocks Poisoner
    //PARAMETERS : none
    //RETURNS : none
    public static void TriggerUnlockPoisoner()
    {
        if (UnlockPoisoner != null)
            UnlockPoisoner();
    }
    //Function : TriggerUnlockPoleArmMastery
    //DESCRIPTION : Unlocks PoleArmMastery
    //PARAMETERS : none
    //RETURNS : none
    public static void TriggerUnlockPoleArmMastery()
    {
        if (UnlockPoleArmMastery != null)
            UnlockPoleArmMastery();
    }
    //Function : TriggerUnlockRecovery
    //DESCRIPTION : Unlocks Recovery
    //PARAMETERS : none
    //RETURNS : none
    public static void TriggerUnlockRecovery()
    {
        if (UnlockRecovery != null)
            UnlockRecovery();
    }
    //Function : TriggerUnlockShieldFighter
    //DESCRIPTION : Unlocks ShieldFighter
    //PARAMETERS : none
    //RETURNS : none
    public static void TriggerUnlockShieldFighter()
    {
        if (UnlockShieldFighter != null)
            UnlockShieldFighter();
    }
    //Function : TriggerUnlockTwinAttack
    //DESCRIPTION : Unlocks TwinAttack
    //PARAMETERS : none
    //RETURNS : none
    public static void TriggerUnlockTwinAttack()
    {
        if (UnlockTwinAttack != null)
            UnlockTwinAttack();
    }
    //Function : TriggerUnlockTwoHandedForce
    //DESCRIPTION : Unlocks TwoHandedForce
    //PARAMETERS : none
    //RETURNS : none
    public static void TriggerUnlockTwoHandedForce()
    {
        if (UnlockTwoHandedForce != null)
            UnlockTwoHandedForce();
    }
}
