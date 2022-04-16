using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectPool : MonoBehaviour
{
    [SerializeField] GameObject myEnemies;
    [SerializeField] float spawnTimer = 1f;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(enemySpawn());
    }

    IEnumerator enemySpawn()
    {
            while (true) 
            {
                Instantiate(myEnemies,transform);
                yield return new WaitForSeconds(spawnTimer);
            }       
        
    }
}
