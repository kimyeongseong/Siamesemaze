using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class talk2 : MonoBehaviour
{
    public GameObject Talk,Talk1, Talk2, Talk3, Talk4, Talk5, Talk6, Talk7, Talk8, Talk9, Talk10, Talk11, Talk12, Talk13, Talk14, Talk15, Talk16, Talk17;
    public GameObject parent;
    public int talknum;
    public bool tlakbar = true;
    public GameObject a;
    // Use this for initialization
    Object obj, obj2;
    public int talk23 = 1;
    void Start()
    {
        Debug.Log(PlayerPrefs.GetInt("clearstage"));
        if (PlayerPrefs.GetInt("clearstage") >=8)
        {
            Destroy(gameObject);
            tlakbar = false;
        }
        talknum = 0;
        if (a != null)
            Destroy(a);
        a = Instantiate(Talk1);
        a.transform.SetParent(transform);
        a.transform.localPosition = new Vector3(transform.localPosition.x, transform.localPosition.y + 100);
        a.transform.localScale = new Vector3(1.0f, 1.0f, 1.0f);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyUp("space"))
        {
            talknum += 1;
            if(gameObject==null)
            {
                return;
            }
            if (talknum == 1)
            {
                if (a != null)
                    Destroy(a);
                a = (GameObject)Instantiate(Talk);
                a.transform.SetParent(transform);
                a.transform.localPosition=new Vector3(transform.localPosition.x,transform.localPosition.y + 100);

                //Talk = Instantiate(Talk, transform.localPosition, transform.localRotation);
                //Talk.GetComponent<Animation>().Play();
                a.transform.localScale = new Vector3(1.0f, 1.0f, 1.0f);

            }
            if (talknum == 2)
            {
                if (a != null)
                    Destroy(a);
                a = Instantiate(Talk1);
                a.transform.SetParent(transform);
                a.transform.localPosition = new Vector3(transform.localPosition.x, transform.localPosition.y + 100);
                //a2 = (GameObject)Instantiate(Talk1, transform.position, transform.rotation);
                a.transform.localScale = new Vector3(1.0f, 1.0f, 1.0f);
            }

            if (talknum == 3)
            {
                if (a != null)
                    Destroy(a);
                a = Instantiate(Talk2);
                a.transform.SetParent(transform);
                a.transform.localPosition = new Vector3(transform.localPosition.x, transform.localPosition.y + 100);

                a.transform.localScale = new Vector3(1.0f, 1.0f, 1.0f);
            }

            if (talknum == 4)
            {
                if (a != null)
                    Destroy(a);
                a = Instantiate(Talk3);
                a.transform.SetParent(transform);
                a.transform.localPosition = new Vector3(transform.localPosition.x, transform.localPosition.y + 100);

                a.transform.localScale = new Vector3(1.0f, 1.0f, 1.0f);
            }
            if (talknum == 5)
            {
                if (a != null)
                    Destroy(a);
                a = Instantiate(Talk4);
                a.transform.SetParent(transform);
                a.transform.localPosition = new Vector3(transform.localPosition.x, transform.localPosition.y + 100);
                a.transform.localScale = new Vector3(1.0f, 1.0f, 1.0f);
            }
            if (talknum == 6)
            {
                if (a != null)
                    Destroy(a);
                a = Instantiate(Talk5);
                a.transform.SetParent(transform);
                a.transform.localPosition = new Vector3(transform.localPosition.x, transform.localPosition.y + 100);
                a.transform.localScale = new Vector3(1.0f, 1.0f, 1.0f);
            }
            if (talknum == 7)
            {
                if (a != null)
                    Destroy(a);
                a = Instantiate(Talk6);
                a.transform.SetParent(transform);
                a.transform.localPosition = new Vector3(transform.localPosition.x, transform.localPosition.y + 100);
                a.transform.localScale = new Vector3(1.0f, 1.0f, 1.0f);
            }
            if (talknum == 8)
            {
                if (a != null)
                    Destroy(a);
                a = Instantiate(Talk7);
                a.transform.SetParent(transform);
                a.transform.localPosition = new Vector3(transform.localPosition.x, transform.localPosition.y + 100);
                a.transform.localScale = new Vector3(1.0f, 1.0f, 1.0f);
            }
            if (talknum == 9)
            {
                if (a != null)
                    Destroy(a);
                a = Instantiate(Talk8);
                a.transform.SetParent(transform);
                a.transform.localPosition = new Vector3(transform.localPosition.x, transform.localPosition.y + 100);
                a.transform.localScale = new Vector3(1.0f, 1.0f, 1.0f);
            }
            if (talknum == 10)
            {
                if (a != null)
                    Destroy(a);
                a = Instantiate(Talk9);
                a.transform.SetParent(transform);
                a.transform.localPosition = new Vector3(transform.localPosition.x, transform.localPosition.y + 100);
                a.transform.localScale = new Vector3(1.0f, 1.0f, 1.0f);
            }
            if (talknum == 11)
            {
                if (a != null)
                    Destroy(a);
                a = Instantiate(Talk10);
                a.transform.SetParent(transform);
                a.transform.localPosition = new Vector3(transform.localPosition.x, transform.localPosition.y + 100);
                a.transform.localScale = new Vector3(1.0f, 1.0f, 1.0f);
            }
            if (talknum == 12)
            {
                if (a != null)
                    Destroy(a);
                a = Instantiate(Talk11);
                a.transform.SetParent(transform);
                a.transform.localPosition = new Vector3(transform.localPosition.x, transform.localPosition.y + 100);
                a.transform.localScale = new Vector3(1.0f, 1.0f, 1.0f);
            }
            if (talknum == 13)
            {
                if (a != null)
                    Destroy(a);
                a = Instantiate(Talk12);
                a.transform.SetParent(transform);
                a.transform.localPosition = new Vector3(transform.localPosition.x, transform.localPosition.y + 100);
                a.transform.localScale = new Vector3(1.0f, 1.0f, 1.0f);
            }
            if (talknum == 14)
            {
                if (a != null)
                    Destroy(a);
                a = Instantiate(Talk13);
                a.transform.SetParent(transform);
                a.transform.localPosition = new Vector3(transform.localPosition.x, transform.localPosition.y + 100);
                a.transform.localScale = new Vector3(1.0f, 1.0f, 1.0f);
            }
            if (talknum == 15)
            {
                if (a != null)
                    Destroy(a);
                a = Instantiate(Talk14);
                a.transform.SetParent(transform);
                a.transform.localPosition = new Vector3(transform.localPosition.x, transform.localPosition.y + 100);
                a.transform.localScale = new Vector3(1.0f, 1.0f, 1.0f);
            }
            if (talknum == 16)
            {
                if (a != null)
                    Destroy(a);
                a = Instantiate(Talk15);
                a.transform.SetParent(transform);
                a.transform.localPosition = new Vector3(transform.localPosition.x, transform.localPosition.y + 100);
                a.transform.localScale = new Vector3(1.0f, 1.0f, 1.0f);
            }
            if (talknum == 17)
            {
                if (a != null)
                    Destroy(a);
                a = Instantiate(Talk16);
                a.transform.SetParent(transform);
                a.transform.localPosition = new Vector3(transform.localPosition.x, transform.localPosition.y + 100);
                a.transform.localScale = new Vector3(1.0f, 1.0f, 1.0f);
            }
            if (talknum == 18)
            {
                if (a != null)
                    Destroy(a);
                a = Instantiate(Talk17);
                a.transform.SetParent(transform);
                a.transform.localPosition = new Vector3(transform.localPosition.x, transform.localPosition.y + 100);
                a.transform.localScale = new Vector3(1.0f, 1.0f, 1.0f);
            }
            if (talknum == 19)
            {
                if (a != null)
                    Destroy(a);
                tlakbar = false;
                Destroy(gameObject);
                SceneManager.LoadScene(2);
            }
        }
    }
}


