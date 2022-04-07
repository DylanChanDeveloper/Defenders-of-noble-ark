using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    [SerializeField] int Totalhitpoints = 4;
    [SerializeField] int currentHitPoints;//serilizing the currenthitpoints will allow us to see updates on the variable in the inspector.

    void Start()
    {
        currentHitPoints = Totalhitpoints;
    }

    // Update is called once per frame
   

     void OnParticleCollision(GameObject other)
    {//enable the collision module and make sure "send collision mesage" is ticked this will allow the particle collision to register.
        processHit();
    }
    //When OnParticleCollision is invoked from a script attached to a GameObject with a Collider, the GameObject parameter represents the ParticleSystem. The Collider receives at most one message per Particle System that collided with it in any given frame even when the Particle System struck the Collider with multiple particles in the current frame. To retrieve detailed information about all the collisions caused by the ParticleSystem, the ParticlePhysicsExtensions.GetCollisionEvents must be used to retrieve the array of ParticleSystem.CollisionEvent.
   // When OnParticleCollision is invoked from a script attached to a ParticleSystem, the GameObject parameter represents a GameObject with an attached Collider struck by the ParticleSystem.The ParticleSystem receives at most one message per Collider that is struck.As above, ParticlePhysicsExtensions.GetCollisionEvents must be used to retrieve all the collision incidents on the GameObject.
     void processHit()
    {
        currentHitPoints--;

        if(currentHitPoints <= 0)
        {
            Destroy(gameObject);
        }
    }
}
