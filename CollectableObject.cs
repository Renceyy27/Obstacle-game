using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectableObject : MonoBehaviour
{

    public ParticleSystem collectParticle;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Kiwi"))
        {

            collectParticle.Play();
            gameObject.SetActive(false);
        }

    }
}
