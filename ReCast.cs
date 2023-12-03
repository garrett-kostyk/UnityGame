using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ReCast : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D Boat)
    {
        if(Boat.tag == "Boat")
        {
            if(gameObject.GetComponent<FixedJoint2D>() == true)
            {
            Debug.Log("hook hit the boat and has a fish");
            }        
            else
            {
                Debug.Log("Hook hit boat NOFISH");
                SceneManager.LoadScene(SceneManager.GetActiveScene().name);
            }
        }

    }
}
