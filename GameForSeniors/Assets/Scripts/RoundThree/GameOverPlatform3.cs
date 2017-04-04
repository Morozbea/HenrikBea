using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameOverPlatform3 : MonoBehaviour {

    Text winText;
    Image winBG;
    Image winBirdWin;
    GameObject restartButton;
    GameObject quitGame;
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
        restartButton = GameObject.Find("ButtonRestart");
        quitGame = GameObject.Find("ButtonQuit");
        banaInfo = GameObject.Find("TextBana").GetComponent<Text>();
        winText.enabled = false;
        winBG.enabled = false;
        winBirdWin.enabled = false;
        isCollided = false;
        restartButton.SetActive(false);
        quitGame.SetActive(false);
        banaInfo.enabled = true;
    }
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (isCollided)
        {
            time -= Time.deltaTime;

            if (time <= 0)
            {
                

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
            restartButton.SetActive(true);
            quitGame.SetActive(true);
            banaInfo.enabled = false;
            isCollided = true;


        }
    }
}
