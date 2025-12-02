using System;
using Unity.VisualScripting.Antlr3.Runtime.Misc;
using UnityEngine;
using UnityEngine.Windows;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody rb;


    

    
    void Start()
    {
        rb = GetComponent<Rigidbody>();

        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void MovementMechanics()
    {
        rb.linearVelocity =;
    }
    

}
