using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class crush : MonoBehaviour
{
    public bool move;
    private static crush instance;
    public float a = 100;
    public static crush GetInstance
    {
        get
        {
            if (instance == null)
            {
                instance = FindObjectOfType(typeof(crush)) as crush;
            }

            if (instance == null)
            {
                GameObject obj = new GameObject("obj");
                instance = obj.AddComponent(typeof(crush)) as crush;
            }
            return instance;
        }
    }

    public int m_data { set; get; }

    // Use this for initialization
    void Start()
    {
        //move = gameObject.GetComponent<stagemove>.move;
    }

    // Update is called once per frame
    void Update()
    {

    }
    void OnTriggerEnter(Collider other)
    {

    }
}
