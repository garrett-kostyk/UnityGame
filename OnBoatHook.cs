using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnBoatHook : MonoBehaviour
{

    
    void OnTriggerEnter2D(Collider2D hook)
    {
        if(hook.tag == "hook")
        {
            Debug.Log("hook on boat!");
            //destroy the hook
            Destroy(hook.gameObject);
            //hook.gameObject.transform.position = new Vector3(.1254f,-.054f,0f);
            //respawn the hook
            
            
        }

    }
    


}
