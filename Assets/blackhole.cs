using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class blackhole : MonoBehaviour
{
    public float speed = 50;
    Transform b;
    public float fireRate = 2.0f;
    private float nextFire = 0.0f;
    //public Vector3 Bar;
    //gameObjet m_BarObjCopy;
    //public GameObject m_BarObjCopy;
    // Use this for initialization
    public bool a = true;
    float x = 0.01f;
    void Start()
    {
           fireRate = 2.0f;
    //b = this.transform.localScale.x;
}
    void Example()
    {
        if (a == true)
        {
            transform.localScale += new Vector3(-x, -x, -x);
            if (this.transform.localScale.x < 0.1f && this.transform.localScale.y < 0.1f && this.transform.localScale.z < 0.1f)
            {
                nextFire = Time.time + fireRate;
                GetComponent<BoxCollider>().isTrigger = false;
                a = false;
            }
        }
        if (a == false && Time.time > nextFire)
        {
            transform.localScale += new Vector3(+x, +x, +x);
            GetComponent<BoxCollider>().isTrigger = true;

            if (this.transform.localScale.x > 1.0f && this.transform.localScale.y > 1.0f && this.transform.localScale.z > 1.0f)
            {
                a = true;
            }
        }
    }
    // Update is called once per frame
    void Update()
    {
        Example();
        transform.Rotate(gameObject.transform.localRotation.x, gameObject.transform.localRotation.y, this.speed * 2.0f * Time.deltaTime);
    }
}
