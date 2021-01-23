using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class Well : MonoBehaviour
{
    public float speed = 50;
    Transform b;
    //private float fAlpha = 0;
    //private float fireRate = 2.0f;
    public float fireRate = 0;
    private float nextFire = 0.0f;
    //public Vector3 Bar;
    //gameObjet m_BarObjCopy;
    //public GameObject m_BarObjCopy;
    // Use this for initialization
    public bool a = true;
    public bool c = true;
    float x = 0.01f;
    void Start()
    {
        //b = this.transform.localScale.x;
         //fireRate= Random.Range(1,5);
    }
    void Example()
    {
        if (a == true)
        {
            transform.localScale += new Vector3(-x, -x, -x);
            GetComponent<Image>().color += new Color(255/255, 255 / 255, 255 / 255, -x);
            if (this.transform.localScale.x < 0.0f && this.transform.localScale.y < 0.0f && this.transform.localScale.z < 0.0f)//완전히 없어 졌을 때
            {
                //GetComponent<BoxCollider>().isTrigger = false;
                nextFire = Time.time + fireRate;//지연시간
                a = false;
                //GetComponent<BoxCollider>().size = new Vector3 (0,0,0);
            }
            
        }
        if (a == false&& Time.time > nextFire)
        {
            transform.localScale += new Vector3(+x, +x, +x);
            GetComponent<Image>().color += new Color(255/255, 255 / 255, 255 / 255, +x);
            if (this.transform.localScale.x > 1.0f && this.transform.localScale.y > 1.0f && this.transform.localScale.z > 1.0f)//완전히 나타났을 때
            {
                a = true;
            }   
        }
    }
    // Update is called once per frame
    void Update()
    {
        Example();
        //transform.Rotate(gameObject.transform.localRotation.x, gameObject.transform.localRotation.y, this.speed * 2.0f * Time.deltaTime);
    }
}
