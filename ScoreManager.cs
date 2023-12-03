using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
public class ScoreManager : MonoBehaviour
{
    public static ScoreManager instance;
    public Text fishCountText;
    public int balance = 0;
    public int power = 0;
    public int isRodUpgraded = 0;
    public int isBoatUpgraded = 0;

    private void Awake()
    {
        instance = this;
    }
    // Start is called before the first frame update
    void Start()
    {
        balance = PlayerPrefs.GetInt("fishCount");
        fishCountText.text = "$" + balance.ToString();
        
    }
    void Update()
    {
        balance = PlayerPrefs.GetInt("fishCount");
        fishCountText.text = "$" + balance.ToString();
    }

    public void AddFish()
    {
        balance += 50;
        fishCountText.text = "$" + balance.ToString();
        PlayerPrefs.SetInt("fishCount", balance);
        
    }

    public void UpgradeRod()
    {
        if(balance >= 500)
        {
            power = 1200;
            balance -= 500;
            PlayerPrefs.SetInt("fishCount",balance);
            PlayerPrefs.SetInt("rodPower", power);
            isRodUpgraded = 1;
            PlayerPrefs.SetInt("isRodUG", isRodUpgraded);
            if(PlayerPrefs.GetInt("isRodUG") == 1)
            {
                Debug.Log("Rod has been upgraded");
            }
        }
        else
        {
            Debug.Log("Not enough money");
        }
    }

    public void UpgradeBoat()
    {
        if(balance >= 1000)
        {
            balance -= 1000;
            PlayerPrefs.SetInt("fishCount", balance);
            isBoatUpgraded = 1;
            PlayerPrefs.SetInt("isBoatUG", isBoatUpgraded);
            if(PlayerPrefs.GetInt("isBoatUG") == 1)
            {
            Debug.Log("boat upgraded");
            }        
        }
        else
        {
            Debug.Log("Not enough money");
        }
    }
}
