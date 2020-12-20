using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destroy : MonoBehaviour
  
{
    //Destroys balls on colision and plays sound
    public AudioClip bumpsound;
    private AudioSource playerAudio;

    private void Start()
    {
        playerAudio = GetComponent<AudioSource>();
    }
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag.Equals("BallCol"))
        {
            
            Destroy(collision.gameObject);
            playerAudio.PlayOneShot(bumpsound, 1.0f);
        }
    }
}
