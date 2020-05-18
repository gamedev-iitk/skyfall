using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class RefillOxygen : MonoBehaviour
{
    public AudioSource collectSound;
    public float capacity;
    
    void OnTriggerEnter(Collider other)
    {
        if (other.transform == player)
        {
            collectSound.Play();
            Oxygen.oxyLevel = capacity;
            Destroy(gameObject);
        }
    }
}
