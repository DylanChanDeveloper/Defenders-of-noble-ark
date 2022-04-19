using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{

    [SerializeField] [Range(0f, 5f)] float mySpeed = 1f;
    [SerializeField] List<Waypoint> myPathWay = new List<Waypoint>();//List syntax is we declare the list with sheverons, 
                                                                     //then inside the cheverons we specifiy the thing its goint to be storing in this case the waypoint script,
                                                                     //we finally initalize the list with new List<Waypoints>, e.g. we initalize pathway to a new list of waypoints
    void OnEnable()// onEnable and on disable is called whenever a object is either enabled or disabled in the hierarchy.
    {
        FindPoint();
        ReturnToStart();
        StartCoroutine(FollowPoint());//using a co routine so for loop will wait for x amount of seconds before executing. To prevent object from teleporting from point A to B instantly
    //1.we are going to start our co-routine here
    }

    void FindPoint()
    {
        myPathWay.Clear();//when we find a path, we're going to clear the existing one and then add a new one. To prevent the path adding existing paths and getting longer.

        GameObject[] waypoints = GameObject.FindGameObjectsWithTag("Pathway");//finds all the objects with tag Pathway and places it in a array.

        foreach(GameObject waypoint in waypoints)//we then loop through the waypoints array object
        {
            myPathWay.Add(waypoint.GetComponent<Waypoint>());//we then find the waypoint component on the object,  then add it to are List called myPathWay. 
        }

    }

   public void ReturnToStart()
    {
        transform.position = myPathWay[0].transform.position;//gets the first elements position and stores it in transform.position
    }

    IEnumerator FollowPoint()
    {
        foreach (Waypoint myWaypoint in myPathWay)//loops through every element in the list 2.co routine starts the for loop
        {
            //3.sets up the start and end position we want to move too
            Vector3 startPos = transform.position;
            Vector3 endPos = myWaypoint.transform.position;
            float distanceTravelPercent = 0f;

            transform.LookAt(endPos);//makes the game object look at the current end point

            while (distanceTravelPercent < 1f) {//4.while our travel percent is less than one. other words while were not at our end position
                distanceTravelPercent += Time.deltaTime * mySpeed;//5.we will update our travel percent with time.delta time and multiply by speed to increase the speed.
                transform.position = Vector3.Lerp(startPos, endPos, distanceTravelPercent);//6. then move the position of our enemy
                yield return new WaitForEndOfFrame();//7. we will then yield back to the ipdate function until the end of the frame has been completed.Then we will jump back to our co routnine
            }//this will then continue the while loop until our travel percent is greater than one.At which the while loop will be broken out of and the foreach loop will move to the next waypoint

            //No longer needed: transform.position = myWaypoint.transform.position;//the first transform.position is on the root of our enemy object we are reassigning the enemy object position to be the waypoints position.          
        }

        gameObject.SetActive(false);//were turning the gameobject off, rather then destroy it because it will be free for the pool to reuse again later.
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
