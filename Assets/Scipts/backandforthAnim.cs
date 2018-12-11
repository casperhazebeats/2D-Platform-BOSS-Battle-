using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class backandforthAnim : MonoBehaviour
{

    [SerializeField]
    private float xLimit = -4f;

    [SerializeField]
    private float moveSpeed;

    private bool movingRight = true;
    private int direction = 1;


    void Start()
    {

    }

    // Update is called once per frame
    void Update () {

        ChangeDirection();

        transform.position += Vector3.right * moveSpeed * Time.deltaTime * direction;
        transform.position = new Vector3(Mathf.Clamp(transform.position.x, xLimit, -xLimit), transform.position.y);


	}

    void ChangeDirection()
    {
        if(movingRight && transform.position.x >= xLimit)
        {
            movingRight = false;
            direction = -1;
            transform.localScale = new Vector3(direction, 1, 1);

        }
        if (!movingRight && transform.position.x <= xLimit)
        {
            movingRight = true;
            direction = 1;
            transform.localScale = new Vector3(direction, 1, 1);

        }
    }
}
