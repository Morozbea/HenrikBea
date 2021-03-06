﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Question2 : MonoBehaviour
{
    // denna script är för den andra frågescenen
    Button Abutton1;
    Button Abutton2;
    Button Abutton3;
    Button Abutton4;

    GameObject StartGameButton;

    public Image questionImage;
    

    Text questionText;

    Text ChangeTextInstructions;
    Text InfoAboutPlatformText;

    Text buttonTextA1;
    Text buttonTextA2;
    Text buttonTextA3;
    Text buttonTextA4;
   
    bool isRightAnswer1;
    bool isRightAnswer2;
   

    // Use this for initialization
    void Start()
    {
        Abutton1 = GameObject.Find("AButton1").GetComponent<Button>();
        Abutton2 = GameObject.Find("AButton2").GetComponent<Button>();
        Abutton3 = GameObject.Find("AButton3").GetComponent<Button>();
        Abutton4 = GameObject.Find("AButton4").GetComponent<Button>();
        
        StartGameButton = GameObject.Find("ButtonStartGame");

        ChangeTextInstructions = GameObject.Find("TextInstructions").GetComponent<Text>();
        InfoAboutPlatformText = GameObject.Find("TextInfo").GetComponent<Text>();
        buttonTextA1 = GameObject.Find("TextA1").GetComponent<Text>();
        buttonTextA2 = GameObject.Find("TextA2").GetComponent<Text>();
        buttonTextA3 = GameObject.Find("TextA3").GetComponent<Text>();
        buttonTextA4 = GameObject.Find("TextA4").GetComponent<Text>();
        questionText = GameObject.Find("QuestionUpText").GetComponent<Text>();
        

       
        questionImage.enabled = false;
        questionText.enabled = false;
        //Abutton1.enabled = false;
        //Abutton2.enabled = false;
        //Abutton3.enabled = false;
        //Abutton4.enabled = false;
        Abutton1.gameObject.SetActive(false);
        Abutton2.gameObject.SetActive(false);
        Abutton3.gameObject.SetActive(false);
        Abutton4.gameObject.SetActive(false);

        InfoAboutPlatformText.enabled = false;
        StartGameButton.SetActive(false);
        isRightAnswer1 = false;
        isRightAnswer2 = false;
       
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void LateUpdate()
    {
        if (isRightAnswer1 == true)
        {
            SecondQuestion();
        }

        if (isRightAnswer2)
        {

            StartGameButton.SetActive(true);
            InfoAboutPlatformText.enabled = true;

            questionImage.enabled = false;
            questionText.enabled = false;
            Abutton1.gameObject.SetActive(false);
            Abutton2.gameObject.SetActive(false);
            Abutton3.gameObject.SetActive(false);
            Abutton4.gameObject.SetActive(false);
            Abutton1.enabled = false;
            Abutton2.enabled = false;
            Abutton3.enabled = false;
            Abutton4.enabled = false;
        }
    }

    //mid sverige
    public void Question1Pressed()
    {        
        questionImage.enabled = true;
        questionText.enabled = true;
        Abutton1.enabled = true;
        Abutton2.enabled = true;
        Abutton3.enabled = true;
        Abutton4.enabled = true;
        Abutton1.gameObject.SetActive(true);
        Abutton2.gameObject.SetActive(true);
        Abutton3.gameObject.SetActive(true);
        Abutton4.gameObject.SetActive(true);
        ChangeTextInstructions.text = "Svara på frågan!";
        ChangeTextInstructions.color = Color.yellow;
    }

    // här kommer 2 metoder för de fyra svar knappar
    // right answer till onclick i unity
    public void AnswerIsRight()
    {        
       
        ChangeTextInstructions.text = "Rätt Svar! Svara på nästa frågan!";
        ChangeTextInstructions.color = new Color32(32, 144, 79, 255);

        questionImage.enabled = true;
        questionText.enabled = true;

        Abutton1.enabled = false;
        Abutton2.enabled = true;
        Abutton3.enabled = true;
        Abutton4.enabled = true;
        Abutton1.gameObject.SetActive(true);
        isRightAnswer1 = true;
    }

    // alla fel svar i fråge 1 får samma metod eftersom de gör samma sak
    public void AnswersAreWrong()
    {        
        ChangeTextInstructions.text = "Fel Svar! Försök svara igen!";
        ChangeTextInstructions.color = Color.red;
    }

    public void SecondQuestion()
    {
        buttonTextA1.text = "Enköping"; 
        buttonTextA2.text = "Krösastaden";
        buttonTextA3.text = "Villekulla";
        buttonTextA4.text = "Vadköping";// rätt svar
        questionText.text = "Hjalmar Bergman är känd författare från Närke, vilken påhittad stad skriver han mycket om?";
        questionImage.enabled = true;
        questionText.enabled = true;
        Abutton1.enabled = true;
        Abutton2.enabled = true;
        Abutton3.enabled = true;
        Abutton4.enabled = true;
        Abutton1.gameObject.SetActive(true);
        Abutton2.gameObject.SetActive(true);
        Abutton3.gameObject.SetActive(true);
        Abutton4.gameObject.SetActive(true);
        Abutton1.onClick.RemoveAllListeners();
        Abutton2.onClick.RemoveAllListeners();
        Abutton3.onClick.RemoveAllListeners();
        Abutton4.onClick.RemoveAllListeners();
        Abutton4.onClick.AddListener(SecondAnswerIsRight);
        Abutton1.onClick.AddListener(SecondAnswersAreWrong);
        Abutton2.onClick.AddListener(SecondAnswersAreWrong);
        Abutton3.onClick.AddListener(SecondAnswersAreWrong);
    }

    public void SecondAnswerIsRight()
    {
        Debug.Log("rätt2");
        isRightAnswer2 = true;
        ChangeTextInstructions.text = "Rätt Svar!";
        ChangeTextInstructions.color = new Color32(32, 144, 79, 255);

        questionImage.enabled = true;
        questionText.enabled = true;
        Abutton1.gameObject.SetActive(true);
        Abutton2.gameObject.SetActive(false);
        Abutton3.gameObject.SetActive(false);
        Abutton4.gameObject.SetActive(false);
        Abutton1.enabled = false;
        Abutton2.enabled = false;
        Abutton3.enabled = false;
        Abutton4.enabled = false;
        

    }
    public void SecondAnswersAreWrong()
    {
        Debug.Log("fel2");
        ChangeTextInstructions.text = "Fel Svar! Försök svara igen!";
        ChangeTextInstructions.color = Color.red;
    }

    public void StartPlattformGameButton()
    {
        SceneManager.LoadScene("PlatformLevel2");
    }

}
