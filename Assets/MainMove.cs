using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MainMove : MonoBehaviour
{
    public Sprite a1, a2, a3, a4, a5;
    public bool b;
    public int a, c, d;
    public bool start, exit, credit, howto, option = false;
    public AudioSource pause;
    public GameObject sound;
    public GameObject parent;
    public GameObject howtoplay;
    public GameObject Credit;
    public bool trye=false;
    // Use this for initialization
    void Start()
    {
        start = false;
        option = false;
        exit = false;
        credit = false;
        howto = false;
        start = true;
        a = 1;
        c = 1;
        d = 2;
        b = false;


    }
    void OnApplicationQuit()
    {

    }
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("space"))
        {
            if (d == 1)
            {
                Application.Quit();
                return;
            }
            else if (d==2)
            {
                SceneManager.LoadScene(d);
                return;
            }
            else if( d==3 &&trye==false)
            {
                sound.transform.position = new Vector3(Screen.width / 2, Screen.height / 2 , 1);
                Instantiate(sound).transform.SetParent(parent.transform);
                trye =true;
                return;
            }
            else if( d==4 && trye == false)
            {
                howtoplay.transform.position = new Vector3(Screen.width / 2, Screen.height / 2, 1);
                Instantiate(howtoplay).transform.SetParent(parent.transform);
                trye = true;
                return;
            }
            else if (d==5)
            {
                Credit.transform.position = new Vector3(Screen.width / 2, Screen.height / 2, 1);
                Instantiate(Credit).transform.SetParent(parent.transform);
                trye = true;
                return;
            }
        }
        if (Input.GetKeyDown(KeyCode.UpArrow) && trye == false)
        {
            {
                if (a == 1 && b == false)
                {
                    gameObject.GetComponent<Image>().sprite = a5;
                    c = 5;
                    a = 2;
                    b = true;
                    d = 1;
                    pause.Play();
                    //exit
                }
                if (a == 2 && b == false)
                {
                    gameObject.GetComponent<Image>().sprite = a4;
                    c = 4;
                    a = 3;
                    b = true;
                    pause.Play();
                    d = 5;
                    //credit
                }
                if (a == 3 && b == false)
                {
                    gameObject.GetComponent<Image>().sprite = a3;
                    c = 3;
                    a = 4;
                    b = true;
                    pause.Play();
                    d = 4;
                    //howto

                }
                if (a == 4 && b == false)
                {
                    gameObject.GetComponent<Image>().sprite = a2;
                    c = 2;
                    a = 5;
                    pause.Play();
                    b = true;
                    d = 3;
                    //option

                }
                if (a == 5 && b == false)
                {
                    gameObject.GetComponent<Image>().sprite = a1;
                    c = 1;
                    a = 1;
                    b = true;
                    pause.Play();
                    d = 2;
                    //start

                }
                //if (a == 5 && b == false)
                //{
                //    gameObject.GetComponent<Image>().sprite = a5;
                //    a = 6;
                //    b = true;
                //}
            }
            b = false;
        }
        if (Input.GetKeyDown(KeyCode.DownArrow)&&trye == false)
        {
            {
                if (c == 5 && b == false)
                {
                    gameObject.GetComponent<Image>().sprite = a1;
                    c = 1;
                    a = 1;
                    b = true;
                    pause.Play();
                    d = 2;
                    //start
                }
                if (c == 1 && b == false)
                {
                    //Instantiate(popup, parent.transform.localPosition,Quaternion.identity);
                    //Instantiate(popup).transform.SetParent(transform);
                    gameObject.GetComponent<Image>().sprite = a2;
                    pause.Play();
                    c = 2;
                    a = 5;

                    b = true;
                    d = 3;

                    //option
                }
                if (c == 2 && b == false)
                {
                    gameObject.GetComponent<Image>().sprite = a3;
                    c = 3;
                    a = 4;
                    pause.Play();


                    b = true;
                    d = 4;

                    //howto
                }
                if (c == 3 && b == false)
                {
                    gameObject.GetComponent<Image>().sprite = a4;
                    c = 4;
                    pause.Play();
                    a = 3;
                    b = true;
                    d = 5;
                    //credit
                }
                if (c == 4 && b == false)
                {
                    gameObject.GetComponent<Image>().sprite = a5;
                    c = 5;
                    b = true;
                    a = 2;
                    d = 1;
                    //exit
                }
                //if (a == 5 && b == false)
                //{
                //    gameObject.GetComponent<Image>().sprite = a5;
                //    a = 6;
                //    b = true;
                //}
            }

            b = false;
        }

    }
}
