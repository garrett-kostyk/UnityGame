using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CatchFish : MonoBehaviour
{
    public AudioSource catchSound;
    void OnTriggerEnter2D(Collider2D fish)
    {
        if(fish.tag == "Fish")
        {
            Debug.Log("Fish caught!");
            gameObject.AddComponent<FixedJoint2D>();
            gameObject.GetComponent<FixedJoint2D>().connectedBody = fish.GetComponent<Rigidbody2D>();
            gameObject.GetComponent<FixedJoint2D>().autoConfigureConnectedAnchor = false;
            gameObject.GetComponent<FixedJoint2D>().connectedAnchor = new Vector2(0f,0f);
            CatchSound();


        }

    }

    public void CatchSound()
    {
        catchSound.Play();
    }
}

