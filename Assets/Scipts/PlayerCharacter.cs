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
}
  
}
