using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class stagemove : MonoBehaviour
{
    public bool Stagemove = false;
    public bool Stagemove2 = false;
    public bool Stagemove3 = false;

    Clear stageclear;
    Clear stageclear2;
    public bool b;
    public float c, d = 0;
    public float a = 0;
    public bool tre;
    int rte;
    talk talk;
    public bool gdfg;
    // Use this for initialization
    void Start()
    {
        gdfg = true;
        if (SceneManager.GetActiveScene().buildIndex == 6)
        {
            tre = false;
        }
        if (SceneManager.GetActiveScene().buildIndex != 6)
        {
            tre = true;
        }
        Stagemove = false;
        Stagemove2 = false;
        Stagemove3 = false;
        //talk = GameObject.Find("TalkBar(Clone)").GetComponent<talk>();
        stageclear = GameObject.Find("clear").GetComponent<Clear>();
        stageclear2 = GameObject.Find("clear2").GetComponent<Clear>();
    }

    // Update is called once per frame
    void Update()
    {
        if (SceneManager.GetActiveScene().buildIndex != 8)
        {
            if (Input.GetKeyUp("space"))
            {
                Debug.Log(stageclear.StageClear);
                Debug.Log(stageclear2.StageClear);
                if (SceneManager.GetActiveScene().buildIndex == 6)
                {
                    rte++;
                    if (rte >= 12)
                    {
                        tre = true;
                    }
                }
            }
            if (gdfg == true)
            {
                if ((stageclear.StageClear == false || stageclear2.StageClear == false))
                {
                    if (Input.GetKeyDown("space") && tre == true)
                    {
                        //if (talk.tlakbar == false)
                        //{
                        if (Stagemove == false && Stagemove2 == false)
                        {
                            Stagemove = true;
                            Stagemove2 = false;
                            Stagemove3 = false;
                            return;
                        }
                        else if (Stagemove2 == false)
                        {

                            Stagemove = false;
                            Stagemove2 = true;
                            Stagemove3 = false;
                            return;
                        }
                        else if (Stagemove3 == false)
                        {

                            Stagemove = false;
                            Stagemove2 = false;
                            Stagemove3 = true;
                            return;

                            //}
                        }
                    }

                    if (Stagemove == true)
                    {
                        if (a >= -660)
                            a -= 10;
                        transform.localPosition = new Vector3(transform.localPosition.x, a, 0);
                    }
                    else if (Stagemove2 == true)
                    {
                        if (a >= -1200)
                            a -= 10;
                        transform.localPosition = new Vector3(transform.localPosition.x, a, 0);
                    }
                    else if (Stagemove3 == true)
                    {
                        if (a < -10)
                            a += 10;
                        transform.localPosition = new Vector3(transform.localPosition.x, a, 0);
                    }
                }
            }
        }
    }
    //void OnTriggerEnter(Collider other)
    //{
    //    Debug.Log("hello");
    //    if(b==false)
    //    {
    //        b = true;
    //    }
    //    else if (b == true)
    //    {
    //        b = false;
    //    }
    //}
}