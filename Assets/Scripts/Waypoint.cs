using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Waypoint : MonoBehaviour
{
    [SerializeField] bool canBePlaced;//did not delcare true or false because we set if the object bool is true in the inspector
     void OnMouseDown()//is called when the user has pressed tge mouse button while over a collider.
    {
        if(canBePlaced)//if the object bool canBePlaced is ticked in the inspector than it will run the code below.
        {           
            Debug.Log(transform.name);
        }
        
    }

}
