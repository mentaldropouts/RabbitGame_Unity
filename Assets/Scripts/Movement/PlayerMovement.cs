using.Systems.Collections;
using Systems.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

//Purpose: To give the Player the ability to move their character across the 
//screen by sliding, jumping, hopping or whatever else
//Pre-Conditions: A Rigidbody to manipulate, and an Input script to get the players inputs.
public class PlayerMovement : MonoBehavior
{
[Header("Player Components")]
[SerializeField] private Rigidbody rb;
[SerializeField] private Vector2 speed = new Vector2(50f,50f);
private Vector2 movement;

//Executes at the start of the game
private void Start()
{ 
    rb = GetComponent<Rigidbody2D>();
}

//Can run zero, once, or multiple times a frame
void FixedUpdate()
{
    //Moving the player according to the Input done in Update
    GetComponent<Rigidbody2D>().velocity = movement;
}

//Executes every frame
private void Update()
{
    float inputX = Input.GetAxis("Horizontal");
    float inputY = Input.GetAxis("Vertical");
    movement = new Vector2(speed.x * inputX, speed.y * inputY);
    FixedUpdate();
}

}