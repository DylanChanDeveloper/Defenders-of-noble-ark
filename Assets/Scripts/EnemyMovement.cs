using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    [SerializeField] List<Waypoint> myPathWay = new List<Waypoint>();//List syntax is we declare the list with sheverons, 
                                                                     //then inside the cheverons we specifiy the thing its goint to be storing in this case the waypoint script,
                                                                     //we finally initalize the list with new List<Waypoints>, e.g. we initalize pathway to a new list of waypoints
    void Start()
    {//we are goint to print a list of the waypoint object names into the console
        PrintWayPoint();
    }

    void PrintWayPoint()
    {
        foreach (Waypoint myWaypoint in myPathWay)
        {
            Debug.Log(myWaypoint.name);//will print out the name of the waypoint
        }
    }

    //Can also be written like this:
    //void PrintingWaypointName()
    //{

    //foreach(var i in myPathWay)
    //{
    //    Debug.Log(i.name);
    //}

    //}
}
