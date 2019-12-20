using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseNpc : CharacterBase
{


    public NpcPathing pathingPattern;

    // Start is called before the first frame update
    void Start()
    {
        pathingPattern = GetComponent<NpcPathing>();
    }

    // Update is called once per frame
    void Update()
    {
        if (pathingPattern.WaypointContainer && pathingPattern.canWait)
        {
            pathingPattern.WaitWhilePathing();
        } else if(pathingPattern.WaypointContainer && pathingPattern.canWait == false)
        {
            pathingPattern.RoamingPath();
        }
    }

}
