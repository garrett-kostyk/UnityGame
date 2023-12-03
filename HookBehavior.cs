using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class HookBehavior : MonoBehaviour
{
    public Rigidbody2D hook;
    public Rigidbody2D pivotpoint;
    public JointMotor2D motor;
    public GameObject player;
    public AudioSource reelSound;
    public Collision2D collision;
    public GameObject fish;


    // Start is called before the first frame update
    void Start()
    {
        hook = GetComponent<Rigidbody2D>();
        pivotpoint = player.GetComponent<Rigidbody2D>();
        hook.gravityScale = 0;
        motor.motorSpeed = 0;
        collision = fish.GetComponent<Collision2D>();
    }

    // Update is called once per frame
    void Update()
    {
        //behavior for hook once under water
        if (hook.transform.position.y <= -5)
        {

            hook.bodyType = RigidbodyType2D.Kinematic;
            hook.velocity = new Vector2(-4, -2);
            hook.bodyType = RigidbodyType2D.Dynamic;
            if(hook.transform.position.x <= player.transform.position.x)
            {
                hook.bodyType = RigidbodyType2D.Kinematic;
                hook.velocity = new Vector2(0, 0);
            }
            if(Input.GetKey(KeyCode.Space)== true)
            {
                reelSound.Play();
                hook.velocity = new Vector2(0,3);
            }

            
            
            
            

        }
        
    }
    public void ReelSound()
    {
        reelSound.Play();
    }


}
