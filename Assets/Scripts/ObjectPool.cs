using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectPool : MonoBehaviour
{
    [SerializeField] GameObject myEnemiePrefab;
    [SerializeField] float spawnTimer = 1f;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(enemySpawn());//calling co-routine
    }

    IEnumerator enemySpawn()//co routine declaration
    {
            while (true) 
            {
            Instantiate(myEnemiePrefab,transform);//the parent for the second parameter is the transform, which is our object in our hierarchy.
                yield return new WaitForSeconds(spawnTimer);
            }              
    }
}

//while loops means while some condition is true.
//while(true) can be dangerious because if we dont give it a way to break out a infinate loop will occur and crash the game.
//the position and roatation is handled in our enemyMovement script so we dont need to use them in this insantiate.
//with this instatiation overload we just create the object and sets the parent for our newly created object.
//if we just have the overload were we create a enemy Prefab   Instantiate(myEnemiePrefab); it will create the object but wont put it anywhere.
