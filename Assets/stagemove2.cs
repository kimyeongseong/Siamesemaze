using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class stagemove2 : MonoBehaviour
{
    public bool Stagemove = false;
    public bool Stagemove2 = false;
    public bool Stagemove3 = false;
    public bool Stagemove4 = false;

    public bool b;
    public float c, d = 0;
    public float a = -1360;
    public bool t;
    // Use this for initialization
    void Start()
    {
        Stagemove = false;
        Stagemove2 = false;
        Stagemove3 = false;
        Stagemove4 = false;

}

// Update is called once per frame
void Update()
    {
        if (Input.GetKeyDown("space"))
        {
            if (Stagemove4 == false&&Stagemove3==true   )
            {
                Stagemove = false;
                Stagemove2 = false;
                Stagemove3 = false;
                Stagemove4 = true;
                return;
            }
            else if (Stagemove == false && Stagemove2 == false)
            {
                Stagemove = true;
                Stagemove2 = false;
                Stagemove3 = false;
                Stagemove4 = false;

                return;
            }
            else if (Stagemove2 == false)
            {
                Stagemove = false;
                Stagemove2 = true;
                Stagemove3 = false;
                Stagemove4 = false;
                return;
            }
            else if (Stagemove3 == false)
            {
                Stagemove = false;
                Stagemove2 = false;
                Stagemove3 = true;
                Stagemove4 = false;
                return;
            }
          
        }
        if (Stagemove == true)
        {
            if (a <= -700)
                a += 10;
            transform.localPosition = new Vector3(0, a, 0);
        }
        else if (Stagemove2 == true)
        {
            if (a <= -390)
                a += 10;
            transform.localPosition = new Vector3(0, a, 0);
        }
        else if (Stagemove3 == true)
        {
            if (a < 100)
                a += 10;
            transform.localPosition = new Vector3(0, a, 0);
        }
        else if(Stagemove4==true)
        {
            if (a >= -1254)
                a -= 10;
            transform.localPosition = new Vector3(0, a, 0);
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