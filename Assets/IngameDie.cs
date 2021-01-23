using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class IngameDie : MonoBehaviour
{
    //public GameObject GameFaill;
    public AudioSource pause;
    bool a = false;
    bool b = false;
    public GameObject c;
       public GameObject d;
    public GameObject parent;
    void MoveMoles()
    {


    }
    void hello()
    {
        if (Input.anyKey)
        {
            if (!Input.anyKeyDown)
            {
                SceneManager.LoadScene(2);
            }
        }
    }

    void GameFail()
    {
        if (a == true && b == false)
        {
            b = true;
            Debug.Log("die");
        }
    }
    void Start()
    {
        //a = false;
        //b = false;
    }
    // Update is called once per frame
    void Update()
    {
    }
    void OnTriggerEnter(Collider other)
    {
        //Debug.Log("die:");

        if (other.gameObject.tag.Equals("Enemy"))
        {
            pause.Play();
            GameFail();
            c = Instantiate(d);
            c.transform.SetParent(parent.transform);
            c.transform.localPosition = new Vector3(0.0f, 0.0f, 0.0f);
            c.transform.localScale = new Vector3(1, 1, 1);
            Invoke("MoveMoles", 1.0f);
            //Invoke("hello", 1.0f);
            InvokeRepeating("hello", 0.01f, 0.01f);
            a = true;
        }
    }
}
