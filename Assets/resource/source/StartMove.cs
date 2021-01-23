using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class StartMove : MonoBehaviour
{
    public bool b;
    public AudioSource click;
    public int a;
    public GameObject[] StagePos = new GameObject[] { };
    public Vector3[] StagePos1 = new Vector3[] { };
    public int clearstage = 1;
    //public Vector2[] stagepos = new Vector2[] {};
    // Use this for initialization

    void Start()
    {
        a = 1;
        b = false;
        //PlayerPrefs.GetInt("clearstage");
        Debug.Log(PlayerPrefs.GetInt("clearstage"));

        if (PlayerPrefs.GetInt("clearstage") < 6)
        {
            PlayerPrefs.SetInt("clearstage", 6);
        }
        PlayerPrefs.SetInt("clearstage", 200);

        PlayerPrefs.Save();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("space"))
        {
            if (a == 1 && PlayerPrefs.GetInt("clearstage") >= 6)
                SceneManager.LoadScene(6);
            else if (a == 2 && PlayerPrefs.GetInt("clearstage") >= 7)
                SceneManager.LoadScene(7);
            else if (a == 3 && PlayerPrefs.GetInt("clearstage") >= 8)
                SceneManager.LoadScene(8);
            else if (a == 4 && PlayerPrefs.GetInt("clearstage") >= 9)
                SceneManager.LoadScene(9);
            else if (a == 5 && PlayerPrefs.GetInt("clearstage") >= 10)
                SceneManager.LoadScene(11);
            else if (a == 6 && PlayerPrefs.GetInt("clearstage") >= 11)
                SceneManager.LoadScene(12);
            else if (a == 7 && PlayerPrefs.GetInt("clearstage") >= 12)
                SceneManager.LoadScene(13);
            else if (a == 8 && PlayerPrefs.GetInt("clearstage") >= 13)
                SceneManager.LoadScene(2);
        }
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            {
                Debug.Log("RightArrow");
                if (a == 2 && b == false)
                {
                    click.Play();
                    transform.localPosition = StagePos[0].transform.localPosition;
                    a = 1;
                    b = true;
                }
                if (a == 3 && b == false)
                {
                    transform.localPosition = StagePos[1].transform.localPosition;
                    click.Play();
                    a = 2;
                    b = true;
                }
                if (a == 4 && b == false)
                {
                    transform.localPosition = StagePos[2].transform.localPosition;
                    click.Play();
                    a = 3;
                    b = true;
                }
                if (a == 5 && b == false)
                {
                    transform.localPosition = StagePos[3].transform.localPosition;
                    click.Play();
                    a = 4;
                    b = true;
                }
                if (a == 6 && b == false)
                {
                    transform.localPosition = StagePos[4].transform.localPosition;
                    click.Play();
                    a = 5;
                    b = true;
                }
                if (a == 7 && b == false)
                {
                    transform.localPosition = StagePos[5].transform.localPosition;
                    click.Play();
                    a = 6;
                    b = true;
                }
                if (a == 8 && b == false)
                {
                    transform.localPosition = StagePos[6].transform.localPosition;
                    click.Play();
                    a = 7;
                    b = true;
                }
            }
            b = false;
        }

        else if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            {
                Debug.Log("RightArrow");
                if (a == 1 && b == false)
                {
                    transform.localPosition = StagePos[1].transform.localPosition;
                    click.Play();
                    a = 2;
                    b = true;
                }
                if (a == 2 && b == false)
                {
                    transform.localPosition = StagePos[2].transform.localPosition;
                    click.Play();
                    a = 3;
                    b = true;
                }
                if (a == 3 && b == false)
                {
                    transform.localPosition = StagePos[3].transform.localPosition;
                    click.Play();
                    a = 4;
                    b = true;
                }
                if (a == 4 && b == false)//i
                {
                    transform.localPosition = StagePos[4].transform.localPosition;
                    click.Play();
                    a = 5;
                    b = true;
                }
                if (a == 5 && b == false)
                {
                    transform.localPosition = StagePos[5].transform.localPosition;
                    click.Play();
                    a = 6;
                    b = true;
                }
                if (a == 6 && b == false)
                {
                    transform.localPosition = StagePos[6].transform.localPosition;
                    click.Play();
                    a = 7;
                    b = true;
                }
                if (a ==7 && b == false)
                {
                    transform.localPosition = StagePos[7].transform.localPosition;
                    click.Play();
                    a = 8;
                    b = true;
                }
            }
            b = false;
        }
    }

}
