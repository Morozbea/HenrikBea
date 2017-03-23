using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class QuestionSCript : MonoBehaviour
{

    // Denna script är för den första scenen
    GameObject Qbutton1;
    GameObject Qbutton2;
    GameObject Qbutton3;
    
    GameObject Abutton1;
    GameObject Abutton2;
    GameObject Abutton3;
    GameObject Abutton4;

    GameObject pic;
    
    public Image questionImage;
    public Text questionText;

    bool isRightAnswer1;

    Text ChangeTextInstructions;

    float time;

    
    // Use this for initialization
    void Start()
    {
        Qbutton1 = GameObject.Find("Button1");
        Qbutton2 = GameObject.Find("Button2");
        Qbutton3 = GameObject.Find("Button3");

        Abutton1 = GameObject.Find("AButton1");
        Abutton2 = GameObject.Find("AButton2");
        Abutton3 = GameObject.Find("AButton3");
        Abutton4 = GameObject.Find("AButton4");

        ChangeTextInstructions = GameObject.Find("TextInstructions").GetComponent<Text>();

        questionImage.enabled = false;
        questionText.enabled = false;
        Abutton1.SetActive(false);
        Abutton2.SetActive(false);
        Abutton3.SetActive(false);
        Abutton4.SetActive(false);

        isRightAnswer1 = false;

        time = 15.0f;

        
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(time);
        // om rätt svar -> gå till platform spel
        if(isRightAnswer1)
        {
            time -= Time.deltaTime;
            if(time <= 0)
            {
                SceneManager.LoadScene("PlatformLevel1");
            }
        }
        // om det är fel svar -> samma scene med samma fråga just nu kan ändras senare
        //else if(!isRightAnswer1 && SceneManager.)
        //{


        //    SceneManager.LoadScene("Question1");
        //}
    }

    //bottom skåne
    public void Question1Pressed()
    {
        questionImage.enabled = true;
        questionText.enabled = true;
        Abutton1.SetActive(true);
        Abutton2.SetActive(true);
        Abutton3.SetActive(true);
        Abutton4.SetActive(true);
        ChangeTextInstructions.text = "Svara på frågan!";
        ChangeTextInstructions.color = Color.yellow;
    }

    // här kommer 2 metoder för de fyra svar knappar
    // right answer till onclick i unity
    public void AnswerIsRight()
    {
        //Blue is the right answer -> next is the platform game
        isRightAnswer1 = true;
        ChangeTextInstructions.text = "Rätt Svar! Platform spel startar!";
        ChangeTextInstructions.color = Color.green;

        questionImage.enabled = true;
        questionText.enabled = true;
        Abutton1.SetActive(true);
        Abutton2.SetActive(false);
        Abutton3.SetActive(false);
        Abutton4.SetActive(false);

    }

    // alla fel svar får samma metod eftersom de gör samma sak
    public void AnswersAreWrong()
    {
        isRightAnswer1 = false;
        ChangeTextInstructions.text = "Fel Svar! Försök svara igen!";
        ChangeTextInstructions.color = Color.red;

    }

    //mid mitten av sverige
    public void Question2Pressed()
    {
        questionImage.enabled = true;
        questionText.enabled = true;
        Abutton1.SetActive(true);
        Abutton2.SetActive(true);
        Abutton3.SetActive(true);
        Abutton4.SetActive(true);
    }


    //top norra av sverige
    public void Question3Pressed()
    {
        questionImage.enabled = true;
        questionText.enabled = true;
        Abutton1.SetActive(true);
        Abutton2.SetActive(true);
        Abutton3.SetActive(true);
        Abutton4.SetActive(true);
    }


    public void CheckAnswerForQuestion1()
    {

    }

    public void CheckAnswerForQuestion2()
    {

    }

    public void CheckAnswerForQuestion3()
    {

    }
}
