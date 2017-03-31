using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class QuestionSCript : MonoBehaviour
{

    // Denna script är för den första scenen
    // svar knappar
    Button Abutton1;
    Button Abutton2;
    Button Abutton3;
    Button Abutton4;
    // starta platform spel knappen
    GameObject StartGameButton;    
    // bakgrunden av frågan
    public Image questionImage;
    // första svar rätt eller fel
    bool isRightAnswer1;
    // andra svar rätt eller fel
    bool isRightAnswer2;
    // text för fel svar,rätt svar,instruktion för att svara på frågan och trycka på aktuell delen av sverige på kartan
    Text ChangeTextInstructions;
    // infromationstext innan plattform spelet startar
    Text InfoAboutPlatformText;
    // text på knapparna
    Text buttonTextA1;
    Text buttonTextA2;
    Text buttonTextA3;
    Text buttonTextA4;
    // texten för frågan
    Text questionText;
    
    // Use this for initialization
    void Start()
    {
        //letar upp knapparna i editorn
        Abutton1 = GameObject.Find("AButton1").GetComponent<Button>();
        Abutton2 = GameObject.Find("AButton2").GetComponent<Button>();
        Abutton3 = GameObject.Find("AButton3").GetComponent<Button>();
        Abutton4 = GameObject.Find("AButton4").GetComponent<Button>();        
        StartGameButton = GameObject.Find("ButtonStartGame");
        // letar upp texter  i editorn
        ChangeTextInstructions = GameObject.Find("TextInstructions").GetComponent<Text>();
        InfoAboutPlatformText = GameObject.Find("TextInfo").GetComponent<Text>();
        questionText = GameObject.Find("QuestionUpText").GetComponent<Text>();
        buttonTextA1 = GameObject.Find("TextA1").GetComponent<Text>();
        buttonTextA2 = GameObject.Find("TextA2").GetComponent<Text>();
        buttonTextA3 = GameObject.Find("TextA3").GetComponent<Text>();
        buttonTextA4 = GameObject.Find("TextA4").GetComponent<Text>();
        // frågans image syns inte       
        questionImage.enabled = false;
        // frågans text syns inte
        questionText.enabled = false;
        // instruktioner innan plattformspel syns inte 
        InfoAboutPlatformText.enabled = false;
        // knapparna kan inte bli aktiverad        
        //Abutton1.enabled = false;
        //Abutton2.enabled = false;
        //Abutton3.enabled = false;
        //Abutton4.enabled = false;
        // knapparna syns inte
        Abutton1.gameObject.SetActive(false);
        Abutton2.gameObject.SetActive(false);
        Abutton3.gameObject.SetActive(false);
        Abutton4.gameObject.SetActive(false);
        StartGameButton.SetActive(false);
        // bools ini til lfalse
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
            Question2();
        }
        // om andra frågan är rätt då händer detta
        if (isRightAnswer2)
        {
            //knappen och info syns
            StartGameButton.SetActive(true);
            InfoAboutPlatformText.enabled = true;
            // allt annat försvinner
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
    //bottom skåne
    public void Question1Pressed()
    {
        // första frågan kommer upp när knappen på sverige är aktiverat
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
        // rätt svar -> nästa fråga        
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

    public void Question2()
    {        
            buttonTextA1.text = "Tomellila";
            buttonTextA2.text = "Degeberga";
            buttonTextA3.text = "Kivik";
            buttonTextA4.text = "Simrishamn"; // right
            questionText.text = "Vilken stad ligger mest österut";
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
            Abutton4.onClick.AddListener(SecondAnswerIsRight);
            Abutton1.onClick.AddListener(SecondAnswersAreWrong);
            Abutton2.onClick.AddListener(SecondAnswersAreWrong);
            Abutton3.onClick.AddListener(SecondAnswersAreWrong);
        
        
    }
    public void SecondAnswerIsRight()
    {        
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
        ChangeTextInstructions.text = "Fel Svar! Försök svara igen!";
        ChangeTextInstructions.color = Color.red;
    }

    public void StartPlattformGameButton()
    {
        SceneManager.LoadScene("PlatformLevel1");
    }
}
