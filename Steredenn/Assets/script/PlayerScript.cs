using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{

    public Vector2 speed = new Vector2(5, 5);

    private Vector2 movement;
    private Rigidbody2D rigidbodyComponent;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Retrieve axis information
        float inputX = Input.GetAxis("Horizontal");
        float inputY = Input.GetAxis("Vertical");

        //Movement per direction
        movement = new Vector2(speed.x * inputX, speed.y * inputY);

        //shooting
        bool shoot = Input.GetButtonDown("Fire1");
        shoot |= Input.GetButtonDown("Fire2");

        if(shoot)
        {
            WeaponScript weapon = GetComponent<WeaponScript>();

            if(weapon != null)
            {
                weapon.Attack(false);
            }
        }
    }

    private void FixedUpdate()
    {
        //Get the component and store the reference
        if (rigidbodyComponent == null)
            rigidbodyComponent = GetComponent<Rigidbody2D>();

        //move the game object
        rigidbodyComponent.velocity = movement;
    }
}
