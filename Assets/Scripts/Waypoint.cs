using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Waypoint : MonoBehaviour
{
    [SerializeField] GameObject prefabTower;
    [SerializeField] bool canBePlaced;//did not delcare true or false because we set if the object bool is true in the inspector.
    
    public bool CanBePlaced//this is a property method notice that there is no "()" vs a normal method that would have parmeter brackets.property being used in myCoOrdinateLabeler
    {  get{  return canBePlaced;   }   }


  
     void OnMouseDown()//is called when the user has pressed tge mouse button while over a collider.
    {
        if(canBePlaced)//if the object bool canBePlaced is ticked in the inspector than it will run the code below.
        {
            // Debug.Log(canBePlaced);
            Instantiate(prefabTower,transform.position,Quaternion.identity);
            canBePlaced = false;
        }//once we instatiated a tower to the tile set the canBePlaced flag is set to false to stop us from placing another tower.
        
    }

}
