using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlipFish : MonoBehaviour
{

    void OnTriggerEnter2D(Collider2D fish)
    {
        if(fish.tag == "Fish")
        {
            fish.transform.Rotate(0f,180f,0f);
        }
    }



}