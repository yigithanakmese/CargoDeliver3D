using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody), typeof(BoxCollider))]
public class Player : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] private Rigidbody rb;
    [SerializeField] private FixedJoystick joystick;
    [SerializeField] private float movespeed;
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
       rb.velocity = new Vector3(joystick.Horizontal * movespeed, rb.velocity.y, joystick.Vertical * movespeed);
    }
}
