using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class BirdPlayer3 : MonoBehaviour {

    GameObject bird;
    // Use this for initialization
    void Start()
    {
        bird = GameObject.Find("BirdPlayer");
    }
    float Speed = 0;//Don't touch this
    float MaxSpeed = 0.2f;//This is the maximum speed that the object will achieve
    float Acceleration = 0.15f;//How fast will object reach a maximum speed
    float Deceleration = 0.2f;//How fast will object reach a speed of 0



    // Update is called once per frame
    void Update()
    {

        this.transform.Translate(Vector2.right * 0.04f, Space.World);
        if (Input.GetKey(KeyCode.W) && (Speed < MaxSpeed))
            Speed = Speed - Acceleration + Time.deltaTime;
        else if ((Input.GetKey(KeyCode.S)) && (Speed > -MaxSpeed))
        {
            Speed = Speed + Acceleration + Time.deltaTime;
            //this.transform.Translate(Vector2.up * 1.25f * (Time.), Space.World);
            //this.transform.Translate(0.0f, 0.0f, zSpeed * Time.deltaTime);

        }

        else
        {
            if (Speed > Deceleration + Time.deltaTime)
                Speed = Speed - Deceleration + Time.deltaTime;
            else if (Speed < -Deceleration + Time.deltaTime)
                Speed = Speed + Deceleration + Time.deltaTime;
            else
                Speed = 0;
        }
        if (bird.transform.position.y > 15) // to high for map
        {
            Speed = 1;
            Debug.Log("High");
        }
        if (bird.transform.position.y < -11) // to high for map
        {
            Speed = -1;
            Debug.Log("High");
        }




        this.transform.Translate(Vector2.down * (Speed * Time.deltaTime), Space.World);
    }

    public void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Enemy")
        {
            SceneManager.LoadScene("PlatformLevel3");
            Debug.Log("collide");
        }
    }
}
