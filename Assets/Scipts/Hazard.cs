using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Hazard : MonoBehaviour{
private Animator anim;

    void Start()
{
    anim = GetComponent<Animator>();
}

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            Debug.Log("Player entered hazard.");
            PlayerCharacter player = collision.GetComponent<PlayerCharacter>();
            //collision.transform.parent.GetComponent<PlayerAnim>();
            player.Respawn();
        }
        else
        {
            Debug.Log("Something other than Player entered the Hazard!");
        }

}

    private void Hit()
    {
        anim.SetTrigger("Die");
        Invoke("Explode", 0.01f);

    }

}
