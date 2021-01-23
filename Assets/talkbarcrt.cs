using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class talkbarcrt : MonoBehaviour
{
    public GameObject a;
    public GameObject b;

    Clear stageclear;
    stagemove aret;
    Clear stageclear2;
    bool agfd;
    // Use this for initialization
    void Awake()
    {
        PlayerPrefs.SetInt("clearstage", 6);
        PlayerPrefs.Save();
        a = Instantiate(a);
        a.transform.SetParent(transform);
        a.transform.localPosition = new Vector3(transform.localPosition.x, transform.localPosition.y - 100);
        a.transform.localScale = new Vector3(1.0f, 1.0f, 1.0f);
        stageclear = GameObject.Find("clear").GetComponent<Clear>();
        stageclear2 = GameObject.Find("clear2").GetComponent<Clear>();
    }
    void Start()
    {
        agfd = false;

    }

    // Update is called once per frame
    void Update()
    {
        if (stageclear.StageClear == true || stageclear2.StageClear == true)
        {
            if (agfd == false)
            {
                aret = GameObject.Find("move").GetComponent<stagemove>();
                b = Instantiate(b);
                b.transform.SetParent(transform);
                b.transform.localPosition = new Vector3(transform.localPosition.x, transform.localPosition.y - 100);
                b.transform.localScale = new Vector3(1.0f, 1.0f, 1.0f);
                agfd = true;
                aret.gdfg = false;
            }
        }
    }
}
