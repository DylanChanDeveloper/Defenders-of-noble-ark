using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TowerTargeting : MonoBehaviour
{
     Transform target;
    [SerializeField] Transform weapon;
    void Start()
    {
        target = FindObjectOfType<EnemyMovement>().transform;
        //finds the first object of type enemyMovement and its transform then reassigns the return value to target.
    }


    void Update()
    {
        AimWeapon();
    }

    void AimWeapon()
    {
        weapon.LookAt(target);
    }
}
