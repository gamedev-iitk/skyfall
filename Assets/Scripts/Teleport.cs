using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleport : MonoBehaviour
{
    public AudioSource collectSound;
    
    Animator m_Animator;
    float Width; //width of game window
    
    void Start()
    {
        m_Animator = GetComponent<Animator>;
    }
    
    void OnTriggerEnter(Collider other)
    {
        m_Animator.enabled = true;
        other.transform.position = new Vector3(Random.Range(-Width, Width), 0, other.transform.position.z + 100);

    }
}
