using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Collectable : MonoBehaviour 
{
    private AudioSource audioSource;
    private SpriteRenderer spriteRenderer;
    private BoxCollider2D boxCollider2;
    private Rigidbody rb;

    public Text countText;
    public Text winText;

    private static int coinCount;
    private int coinCoint;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        audioSource = GetComponent<AudioSource>();
        spriteRenderer = GetComponent<SpriteRenderer>();
        boxCollider2 = GetComponent<BoxCollider2D>();
        coinCount = 0;
        SetCountText();
        winText.text = "";
    }
    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            //coinCount++;
            //Debug.Log("Coin count: " + coinCount);
            audioSource.Play();
            spriteRenderer.enabled = false;
            boxCollider2.enabled = false;
            Destroy(this.gameObject, audioSource.clip.length);
            coinCount = coinCount + 1;
            countText.text = "Coin count: " + coinCount.ToString();
            SetCountText();

        }

    }
        void SetCountText()
        {
            if(coinCoint >= 25)
            {
            //spriteRenderer.enabled = true;
                winText.text = "YOU WIN";
            }
    }
}
