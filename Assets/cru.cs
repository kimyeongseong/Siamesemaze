using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cru: MonoBehaviour
{
    public GameObject Talk1;
    public GameObject parent;
    public GameObject a;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    void MoveMoles()
    {

    }

    void OnTriggerEnter(Collider collision)
    {

        if (collision.gameObject.tag.Equals("hp2"))
        {
            Destroy(gameObject);
            Debug.Log("CrushbossTest");
        }
    }
    private void OnCollisionEnter(Collision collision)
    {

    }
}
