using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.Mathematics;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Splines;

public class CastReel : MonoBehaviour
{
    // Start is called before the first frame update
    public Rigidbody2D hook;
    public int xforce;
    public int yforce;
    private float startOfHoldTime;
    public RelativeJoint2D joint;
    public Rigidbody2D rod;
    public JointMotor2D motor;
    public HingeJoint2D something;
    public bool launch = false;
    public int rodPower = 350;
    public float castDistance = 1;
    void Start()
    {
        hook = GetComponent<Rigidbody2D>();
        joint = GetComponent<RelativeJoint2D>();
        rod = GetComponent<Rigidbody2D>();
        hook.bodyType = RigidbodyType2D.Kinematic;
        rod.bodyType = RigidbodyType2D.Kinematic;
        hook.gravityScale = 0; 
        something = GameObject.Find("Boat/Player/rod").GetComponent<HingeJoint2D>();
        castDistance = PlayerPrefs.GetInt("castDistance");
        
    
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0)== true){
            Debug.Log("Left Mouse Down");
            startOfHoldTime = Time.time;
            hook.bodyType = RigidbodyType2D.Dynamic;
            rod.bodyType = RigidbodyType2D.Dynamic;
            

        }

        if (Input.GetKeyUp(KeyCode.Mouse0)== true)
        {
            float endOfHoldTime = Time.time - startOfHoldTime;
            Debug.Log(endOfHoldTime);
            if(PlayerPrefs.GetInt("isRodUG") == 0)
            {
                hook.gravityScale = 1;
            }
            if(PlayerPrefs.GetInt("isRodUG") == 1)
            {
            hook.gravityScale = .5F;
            Debug.Log("Gravity of hook is now .5");
            }
            //angle detection
            hook.AddForce(new Vector2(CalcHoldPower(endOfHoldTime),CalcHoldPower(endOfHoldTime)));
        }

        if (hook.transform.position.y <= -4 && hook.transform.position.y >=-5){
            //do something at water level
        }


    }
    //calculate power of throw function
    private float CalcHoldPower(float time){
        float maxHoldTime = 4f;
        float holdTimeNm = Mathf.Clamp01(time / maxHoldTime);
        return holdTimeNm * rodPower;
    }

    private bool CheckforRodAngle(float angle)
    {
        if (angle >= 10)
        {
        return true;
        }
        else{return false;}
    }
}
