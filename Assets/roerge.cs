using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class roerge : MonoBehaviour
{
    private float a, b, c;
    private bool d=true;
    // Use this for initialization
    void Start()
    {
    }

    // Update is called once per frame

    private void Update()
    {
        if (d == true)
        {
            a = transform.localPosition.x;
            b = transform.localPosition.y;
            c = transform.localPosition.z;
        }
    }
   private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag.Equals("Well"))
        {
            d = false;
            Debug.Log("hello");
            transform.localPosition = new Vector3(a, b, c);
        }
    }
    private void OnCollisionStay(Collision collision)
    {
        if (collision.gameObject.tag.Equals("Well"))
        {
            Debug.Log("hello2");
            d = false;
            transform.localPosition = new Vector3(a, b, c);
        }
    }
    private void OnCollisionExit(Collision collision)
    {
        d = true;
    }
}
