using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FishMove : MonoBehaviour
{
    public Rigidbody2D myRigidbody;
    public float FishSpeed = 20;
    // Start is called before the first frame update
    void Start()
    {
        myRigidbody = gameObject.GetComponent<Rigidbody2D>();
    }
   

    // Update is called once per frame
    void Update()
    {
        myRigidbody.velocity = transform.right * FishSpeed;
    }
}
