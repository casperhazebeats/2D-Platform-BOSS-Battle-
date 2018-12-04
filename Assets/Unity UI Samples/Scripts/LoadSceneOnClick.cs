using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadSceneOnClick : MonoBehaviour {
    public AudioSource myFX;
    public AudioClip hoverFX;
    public AudioClip clickFX;

    public void HoverSound()
    {
        myFX.PlayOneShot(hoverFX);
    }

    public void ClickSound()
    {
        myFX.PlayOneShot(clickFX);
    }
    public void LoadByIndex(int sceneIndex)
    {
        SceneManager.LoadScene(sceneIndex);
    }
}
