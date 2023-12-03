using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class boatscript : MonoBehaviour
{   
    public Rigidbody2D myRigidbody;
    public GameObject boatBlock1;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        //Move right
        if(Input.GetKey(KeyCode.RightArrow) == true){
            myRigidbody.AddForce(new Vector2(5, 0));
        }
        //Move left
        if(Input.GetKey(KeyCode.LeftArrow) == true){
            myRigidbody.AddForce(new Vector2(-5, 0));
        }

        if(PlayerPrefs.GetInt("isBoatUG") == 1)
        {
            boatBlock1.SetActive(false);
        }
        
        

    }
}
