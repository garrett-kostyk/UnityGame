using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotaterod : MonoBehaviour
{
      
    public HingeJoint2D rodRotation;
    public JointMotor2D motor;
    public Rigidbody2D rod;
    public RelativeJoint2D hookjoint;
    public AudioSource castSound;


    // Start is called before the first frame update
    void Start()
    {
        rodRotation = GetComponent<HingeJoint2D>();
        motor.motorSpeed = 0;
        motor = rodRotation.motor;
        rod = GetComponent<Rigidbody2D>();
        rod.bodyType = RigidbodyType2D.Kinematic;
        hookjoint = GetComponent<RelativeJoint2D>();

    }

    // Update is called once per frame
    void Update()
    {   
        if (Input.GetKeyDown(KeyCode.Mouse0)== true){
            Debug.Log("Left Mouse Down");
            rod.bodyType = RigidbodyType2D.Dynamic;
            motor.motorSpeed = -50;
            rodRotation.motor = motor;
            rodRotation.useMotor = true;
        }
        
        if (Input.GetKeyUp(KeyCode.Mouse0)== true){
            Debug.Log("Left Mouse Up");
            motor.motorSpeed = 350;
            rodRotation.motor = motor;
            CastSound();
        }
        if(rodRotation.jointAngle >= -90 && motor.motorSpeed == 350 && rodRotation.jointAngle <= -80)
            {
                Debug.Log("angle at 90 on way down");
                hookjoint.enabled = false;

            }

        
            
        

    }

    public void CastSound()
    {
        castSound.Play();
    }

}
