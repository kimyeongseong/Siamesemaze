using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MainMove2 : MonoBehaviour
{
    MainMove feverGauge;
    public Sprite a1, a2, a3, a4, a5;
    public bool b;
    public int a, c, d;
    public AudioSource pause;
    public GameObject popup;
    public GameObject parent;
    public GameObject popup2;
    public bool trye = false;
    public bool gaugeCount = false;
    // Use this for initialization
    void Awake()
    {
        feverGauge = GameObject.Find("gr").GetComponent<MainMove>();
    }
    void Start()
    {

        //start = fals;
        a = 5;
        c = 5;
        d = 2;
        b = false;


    }
    void OnApplicationQuit()
    {

    }
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow) && feverGauge.trye == false)
        {
            if (a == 5 && b == false)
            {
                b = true;
                gameObject.GetComponent<Image>().sprite = a4;
                a = 1;
                c = 1;
                pause.Play();
                //exit -> how to 
            }//o

            if (a == 1 && b == false)
            {
                b = true;
                gameObject.GetComponent<Image>().sprite = a3;
                a = 2;
                c = 2;
                pause.Play();
                //how to -> credit
            }//o

            if (a == 2 && b == false)
            {
                b = true;
                gameObject.GetComponent<Image>().sprite = a2;
                a = 3;
                c = 3;
                pause.Play();
                //credit -> setting
            }

            if (a == 3 && b == false)
            {
                b = true;
                gameObject.GetComponent<Image>().sprite = a1;
                a = 4;
                c = 4;
                pause.Play();
                //setting->start
            }

            if (a == 4 && b == false)
            {
                b = true;
                gameObject.GetComponent<Image>().sprite = a5;
                a = 5;
                c = 5;
                pause.Play();
                //start -> exit
            }
            b = false;
        }
        //o
        if (Input.GetKeyDown(KeyCode.DownArrow) && feverGauge.trye == false)
        {
            {
                if (c == 5 && b == false)
                {
                    b = true;
                    gameObject.GetComponent<Image>().sprite = a1;
                    a = 4;
                    c = 4;
                    pause.Play();
                    //exit -> start
                }
                if (c == 4 && b == false)
                {
                    b = true;
                    gameObject.GetComponent<Image>().sprite = a2;
                    a = 3;
                    c = 3;
                    pause.Play();
                    //start -> setting
                }
                if (c == 3 && b == false)
                {
                    b = true;
                    gameObject.GetComponent<Image>().sprite = a3;
                    a = 2;
                    c = 2;
                    pause.Play();
                    //setting->credit
                }
                if (c == 2 && b == false)
                {
                    b = true;
                    gameObject.GetComponent<Image>().sprite = a4;
                    a = 1;
                    c = 1;
                    pause.Play();
                    //credit-> how to 
                }
                if (c == 1 && b == false)
                {
                    b = true;
                    gameObject.GetComponent<Image>().sprite = a5;
                    a = 5;
                    c = 5;
                    pause.Play();
                    //howto -> exit
                }
            }
            b = false;
        }
    }
}
