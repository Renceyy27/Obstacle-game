using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemCollector : MonoBehaviour
{
    private int Kiwis = 0;
    public ParticleSystem collectParticle;

    [SerializeField]
    private Text kiwisText;

    [SerializeField]
    private AudioSource collecttionSoundEffect;


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Kiwi")) 
        { 
            collecttionSoundEffect.Play();
            Destroy(collision.gameObject);
            Kiwis++;
            kiwisText.text = "Kiwis: " + Kiwis;

        }
    }

   
}
