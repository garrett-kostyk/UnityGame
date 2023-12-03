using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class moneyCounter : MonoBehaviour
{
    public Text txt;
    public int balance = 0;
    private void Awake()
    {
        txt = GetComponent<Text>();
        
    }

    private void Update()
    {
        balance = PlayerPrefs.GetInt("fishCount");
        txt.text = "$" + balance.ToString();
    }
}
