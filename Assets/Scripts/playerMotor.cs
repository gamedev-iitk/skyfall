using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMotor : MonoBehaviour
{
    CharacterController controller;
    Vector3 moveVector;
    float speed = 5.0f;

    // Start is called before the first frame update
     void Start()
    {
        controller=GetComponent<CharacterController>();
        
    }

    // Update is called once per frame
    void Update()
    {
        moveVector=Vector3.zero;

        moveVector.x=Input.GetAxisRaw("Horizontal")*speed;
        moveVector.y=Input.GetAxisRaw("Vertical")*speed;
        moveVector.z=speed;
        controller.Move(moveVector*Time.deltaTime);
        
    }
}
