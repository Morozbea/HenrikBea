using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameOverPlattform : MonoBehaviour
{
    Text winText;
    Image winBG;
    Image winBirdWin;
    float time;
    bool isCollided;
    Text banaInfo;
    // Use this for initialization

    void Awake()
    {
        time = 3.0f;
        winText = GameObject.Find("TextWin").GetComponent<Text>();
        winBG = GameObject.Find("ImageWinBG").GetComponent<Image>();
        winBirdWin = GameObject.Find("ImageBirdWin").GetComponent<Image>();
        banaInfo = GameObject.Find("TextInfo").GetComponent<Text>();
        winText.enabled = false;
        winBG.enabled = false;
        winBirdWin.enabled = false;
        isCollided = false;
        banaInfo.enabled = true;
    }
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if(isCollided)
        {
            time -= Time.deltaTime;
            
            if (time <= 0)
            {
                SceneManager.LoadScene("Question2");

            }
        }
    }

    public void OnCollisionEnter2D(Collision2D coll)
    {
         Debug.Log("collWincheck");
            if (coll.gameObject.tag == "Player")
        {
                 
            winText.enabled = true;
            winBG.enabled = true;
            winBirdWin.enabled = true;
            banaInfo.enabled = false;
            isCollided = true;
            
                
        }
    }
}
