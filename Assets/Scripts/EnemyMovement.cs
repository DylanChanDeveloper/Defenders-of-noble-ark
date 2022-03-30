using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    [SerializeField] float waitTimer = 1f;//used to tell how many seconds the co routine will wait for.

    [SerializeField] List<Waypoint> myPathWay = new List<Waypoint>();//List syntax is we declare the list with sheverons, 
                                                                     //then inside the cheverons we specifiy the thing its goint to be storing in this case the waypoint script,
                                                                     //we finally initalize the list with new List<Waypoints>, e.g. we initalize pathway to a new list of waypoints
    void Start()
    {
        StartCoroutine(PrintWayPoint());//using a co routine so for loop will wait for x amount of seconds before executing. To prevent object from teleporting from point A to B instantly
    }

    IEnumerator PrintWayPoint()
    {
        foreach (Waypoint myWaypoint in myPathWay)//loops through every element in the list
        {
            transform.position = myWaypoint.transform.position;//the first transform.position is on the root of our enemy object we are reassigning the enemy object position to be the waypoints position.
            yield return new WaitForSeconds(waitTimer);// we are using yield return because for co routines it means give up control and then in this case come back after 1 second. yield is needed when returning a co routine.
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
