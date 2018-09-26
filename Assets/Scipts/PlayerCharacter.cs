using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCharacter : MonoBehaviour {
    [SerializeField]
    private int lives = 3; // PascalCase or camel Case

    [SerializeField]
    private string name = "Mario";

    [SerializeField]
    private float jumpHeight = 5, speed = 5;

    private bool hasKey;

    private bool isOnGround;
    // Use this for initialization
    void Start () {
        Debug.Log("hello");

        string pizza = "yum";
        Debug.Log(pizza);

        transform.Translate(0, -.01f, 0);
        if (hasKey)
        {
            float openTimer = 5;
            Debug.Log("Open the door!");
            for (int i = 0; i < openTimer; i++)
            {
            }

            rigidbody2DInstance.gravityScale = 5;
        }
	}
	
	// Update is called once per frame
	private void Update ()
         (Input.GetKeyDown(KeyCode.LeftArrow))
    {
       MoveLeft();
	}
    private void Move()
    {

    }
}
