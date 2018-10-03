using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class PlayerCharacter : MonoBehaviour
{
    [SerializeField]
    private float speed = 5;
    [SerializeField]
    private Rigidbody2D rb2d;
private float horizontalInput;
    //Use this for Initialization
void Start()
{

}
    //update is called once per frame
void Update()
{
        horizontalInput = Input.GetAxis("Horizontal");

      
}
    private void FixedUpdate()
    {
        rb2d.AddForce(Vector2.right * horizontalInput * speed);
    }

}
