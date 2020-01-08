using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UQuestToggle : UIButton
{
    private UQuestButton qbRef;

    public override void Clicked()
    {
        qbRef.ToggleTrackingQuest();
    }

    public void SetQBRef(UQuestButton qb)
    {
        qbRef = qb;
    }
}
