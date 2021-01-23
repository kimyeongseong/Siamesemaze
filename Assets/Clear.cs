using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Clear : MonoBehaviour
{
    //public GameObject GameFaill;
    public AudioSource pause;
    //bool a = false;
    bool b = false;
    public bool player1 = false;
    public bool player2 = false;
    public GameObject clear1;
    public GameObject clear2;
    int t;
    Clear feverGauge;
    public bool StageClear;
    void MoveMoles()
    {
        SceneManager.LoadScene(2);
    }
    void GameFail()
    {
        if (feverGauge.player1 == true && feverGauge.player2 == true && b == false)
        {
            b = true;
            StageClear = false;
            pause.Play();
            Debug.Log("clear");
            //Invoke("MoveMoles", 3.0f);.
                Invoke("MoveMoles", 3.0f);

            if (SceneManager.GetActiveScene().buildIndex == 6)
                StageClear = true;
        
        }
    }
    void Start()
    {
        //a = false;
        feverGauge = GameObject.Find("clear").GetComponent<Clear>();
        //b = false;
    }
    // Update is called once per frame
    void Update()
    {
    }
    void OnTriggerEnter(Collider other)
    {
        //Debug.Log("die:");

        if (other.gameObject.tag.Equals("Player"))
        {
            feverGauge.player1 = true;
            GameFail();
            if (SceneManager.GetActiveScene().buildIndex == 6)
            {

                PlayerPrefs.SetInt("clearstage", 7);
                PlayerPrefs.Save();
            }
            else if (SceneManager.GetActiveScene().buildIndex == 7)
            {
                PlayerPrefs.SetInt("clearstage", 8);
                PlayerPrefs.Save();
            }
            else if (SceneManager.GetActiveScene().buildIndex == 8)
            {
                PlayerPrefs.SetInt("clearstage", 9);
                PlayerPrefs.Save();
            }
            else if (SceneManager.GetActiveScene().buildIndex == 9)
            {
                PlayerPrefs.SetInt("clearstage", 10);
                PlayerPrefs.Save();
            }
            else if (SceneManager.GetActiveScene().buildIndex == 10)
            {
                PlayerPrefs.SetInt("clearstage", 11);
                PlayerPrefs.Save();
            }
            else if (SceneManager.GetActiveScene().buildIndex == 11)
            {
                PlayerPrefs.SetInt("clearstage", 12);
                PlayerPrefs.Save();
            }
            else if (SceneManager.GetActiveScene().buildIndex == 12)
            {
                PlayerPrefs.SetInt("clearstage", 13);
                PlayerPrefs.Save();
            }
        }
        if (other.gameObject.tag.Equals("Player2"))
        {
            feverGauge.player2 = true;
            GameFail();
            if (SceneManager.GetActiveScene().buildIndex == 6)
            {
                PlayerPrefs.SetInt("clearstage", 7);
                PlayerPrefs.Save();
            }
            else if (SceneManager.GetActiveScene().buildIndex == 7)
            {
                PlayerPrefs.SetInt("clearstage", 8);
                PlayerPrefs.Save();
            }
            else if (SceneManager.GetActiveScene().buildIndex == 8)
            {
                PlayerPrefs.SetInt("clearstage", 9);
                PlayerPrefs.Save();
            }
            else if (SceneManager.GetActiveScene().buildIndex == 9)
            {
                PlayerPrefs.SetInt("clearstage", 10);
                PlayerPrefs.Save();
            }
            else if (SceneManager.GetActiveScene().buildIndex == 10)
            {
                Debug.Log(t);
                PlayerPrefs.SetInt("clearstage", 11);
                PlayerPrefs.Save();
            }
            else if (SceneManager.GetActiveScene().buildIndex == 11)
            {
                PlayerPrefs.SetInt("clearstage", 12);
                PlayerPrefs.Save();
            }
            else if (SceneManager.GetActiveScene().buildIndex == 12)
            {
                PlayerPrefs.SetInt("clearstage", 13);
                PlayerPrefs.Save();
            }
        }
    }
    //void OnTriggerExit(Collider other)
    //{

    //    if (other.gameObject.tag.Equals("Player"))
    //    {
    //        feverGauge.player1 = false;
    //    }
    //    if (other.gameObject.tag.Equals("Player2"))
    //    {
    //        feverGauge.player2 = false;
    //    }

    //}
}
