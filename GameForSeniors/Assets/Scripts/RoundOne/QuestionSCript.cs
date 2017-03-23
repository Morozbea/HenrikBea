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

    GameObject StartGameButton;

    GameObject pic;
    
    public Image questionImage;
    public Text questionText;

    bool isRightAnswer1;

    Text ChangeTextInstructions;
    Text InfoAboutPlatformText;

    

    
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

        StartGameButton = GameObject.Find("ButtonStartGame");

        ChangeTextInstructions = GameObject.Find("TextInstructions").GetComponent<Text>();
        InfoAboutPlatformText = GameObject.Find("TextInfoAboutPlattform").GetComponent<Text>();

        questionImage.enabled = false;

        questionText.enabled = false;
        InfoAboutPlatformText.enabled = false;

        Abutton1.SetActive(false);
        Abutton2.SetActive(false);
        Abutton3.SetActive(false);
        Abutton4.SetActive(false);
        StartGameButton.SetActive(false);

        isRightAnswer1 = false;

        

        
    }

    // Update is called once per frame
    void Update()
    {
        if (isRightAnswer1)
        {
            
            StartGameButton.SetActive(true);
            InfoAboutPlatformText.enabled = true;

            questionImage.enabled = false;
            questionText.enabled = false;
            Abutton1.SetActive(false);
            Abutton2.SetActive(false);
            Abutton3.SetActive(false);
            Abutton4.SetActive(false);
        }
        
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
        ChangeTextInstructions.text = "Rätt Svar!";
        ChangeTextInstructions.color = new Color32(32, 144, 79, 255);

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

    public void StartPlattformGameButton()
    {
        SceneManager.LoadScene("PlatformLevel1");
    }


}
