using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Hazard : MonoBehaviour
{
    private AudioSource audioSource;
    private Animator anim;

    public GameObject ExplosionGo;//this is explosion prefab

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        anim = GetComponent<Animator>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            audioSource.Play();
            Debug.Log("Player entered hazard.");
            PlayerCharacter player = collision.GetComponent<PlayerCharacter>();
            //collision.transform.parent.GetComponent<PlayerAnim>();
            player.Respawn();
            PlayExplosion();
        }
        else
        {
            Debug.Log("Something other than Player entered the Hazard!");
        }

    }

    //Function to instantiate an explosion
    void PlayExplosion()
    {
        GameObject explosion = (GameObject)Instantiate(ExplosionGo);
        explosion.transform.position = transform.position;
    }

    //private void Hit()
    //{
    //    anim.SetTrigger("Die");
    //    Invoke("Explode", 0.01f);

    //}

}