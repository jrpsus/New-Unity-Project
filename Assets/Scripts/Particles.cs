using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Particles : MonoBehaviour
{
    public GameObject triggerParticle;
    public GameObject collisionParticle;

    private void OnTriggerEnter(Collider other)
    {
        if (triggerParticle != null)
        {
            Instantiate(triggerParticle, this.transform.position, this.transform.rotation);
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collisionParticle != null)
        {
            Instantiate(collisionParticle, collision.contacts[0].point, this.transform.rotation);
        }
    }
}
