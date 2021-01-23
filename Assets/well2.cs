using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class well2 : MonoBehaviour
{
    public float speed = 50;
    Transform b;
    public float fireRate = 0;
    public float fireRate2 = 0;

    private float nextFire = 0.0f;
    private float nextFire2 = 0.0f;

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
        if (a == true && Time.time > nextFire2)
        {
            transform.localScale += new Vector3(-x, -x, -x);
            GetComponent<Image>().color += new Color(1, 1, 1, -x);
            if(this.transform.localScale.x < 0.5f && this.transform.localScale.y < 0.5f && this.transform.localScale.z < 0.5f)
            {
                GetComponent<BoxCollider>().isTrigger = false;
            }
            if (this.transform.localScale.x < 0.1f && this.transform.localScale.y < 0.1f && this.transform.localScale.z < 0.1f)//완전히 없어 졌을 때
            {
                nextFire = Time.time + fireRate;//지연시간
                a = false;
            }   

        }
        if (a == false && Time.time > nextFire)
        {
            transform.localScale += new Vector3(+x, +x, +x);
            GetComponent<Image>().color += new Color(1, 1, 1, +x);
            GetComponent<BoxCollider>().size += new Vector3(+x, +x, +x);
            if (this.transform.localScale.x >= 1.0f && this.transform.localScale.y >= 1.0f && this.transform.localScale.z >= 1.0f)//완전히 나타났을 때
            {
                a = true;
                nextFire2 = Time.time + fireRate2;//지연시간
                GetComponent<BoxCollider>().isTrigger = true;
            }
        }
    }
    void Update()
    {
        Example();
    }
}
