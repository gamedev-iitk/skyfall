using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreMultiplier : MonoBehaviour
{
    public AudioSource collectSound;
    public Transform player;

    bool hasHit = false;

    void OnTriggerEnter(Collider other)
    {
        if (other.transform == player)
        {
            collectSound.Play();
            Score.scoreRate=2;
            hasHit = true;
            Destroy(gameObject);
        }
    }
}
