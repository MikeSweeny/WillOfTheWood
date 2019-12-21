using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseNpc : CharacterBase
{


    public NpcPathing pathingPattern;

    private void Start()
    {
        pathingPattern = GetComponent<NpcPathing>();
    }

    protected void RoamingPatterns()
    {
        if (pathingPattern.WaypointContainer && pathingPattern.canWait)
        {
            pathingPattern.WaitWhilePathing();
        }
        else if (pathingPattern.WaypointContainer && pathingPattern.canWait == false)
        {
            pathingPattern.RoamingPath();
        }
    }

}
