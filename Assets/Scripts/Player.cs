using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Player : MonoBehaviour
{
    public Rigidbody rd;
    public int score = 0;
    public TMP_Text scoreText;
    public GameObject WinText;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("游戏开始了！");
        rd = GetComponent<Rigidbody>();
        scoreText = GameObject.Find("ScoreText").GetComponent<TMP_Text>();
       
    }

    // Update is called once per framea
    void Update()
    {
        //Debug.Log("游戏开始了！");
        //rd.AddForce(new Vector3(2, 0, 1));

        float h = Input.GetAxis("Horizontal");  //a -1 d 1
        float v = Input.GetAxis("Vertical");
        //Debug.Log(h);
        rd.AddForce(new Vector3(h, 0, v) * 5);
    }
    //private void OnCollisionEnter(Collision collision)
    //{
    //    //Debug.Log("碰撞啦！");

    //    if (collision.gameObject.tag == "Food")
    //    {
    //        Destroy(collision.gameObject);
    //    }
    //}


    private void OnTriggerEnter(Collider other)
    {
        string s = other.gameObject.tag;
        if(s == "Food")
        {
            Destroy(other.gameObject);
            score++;

            scoreText.text = "Score : " + score;

            if(score == 9)
            {
                WinText.SetActive(true);
            }
            //Debug.Log(score);
        }
    }

    //private void OnCollisionStay(Collision collision)
    //{

    //}
    //private void OnCollisionExit(Collision collision)
    //{

    //}




}
