using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnBoat : MonoBehaviour
{

    
    void OnTriggerEnter2D(Collider2D fish)
    {
        if(fish.tag == "Fish")
        {
            Debug.Log("Fish on boat!");
            //add fish to score
            ScoreManager.instance.AddFish();
            //destroy the fish
            Destroy(fish.gameObject);
        }

    }
    


}
