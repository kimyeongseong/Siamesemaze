using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class bosshp : MonoBehaviour
{
    public Sprite a1, a2, a3, a4, a5;
    public int hp = 5;
    public GameObject Talk1;
    public GameObject parent;
    public GameObject a;
    // Use this for initialization
    void Start()
    {
        a = Instantiate(Talk1);
        a.transform.SetParent(parent.transform);
        float posx = Random.Range(-800, 800);
        float posy = Random.Range(-25, 700);
        a.transform.localPosition = new Vector3(posx, posy);
    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnCollisionEnter(Collision collision)
    {
      
    }
    void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.tag.Equals("demi"))
        {
            Debug.Log(hp);
            hp -= 1;
            if (hp == 1)
            {
                gameObject.GetComponent<Image>().sprite = a1;
            }
            if (hp == 2)
            {
                gameObject.GetComponent<Image>().sprite = a2;
            }
            if (hp == 3)
            {
                gameObject.GetComponent<Image>().sprite = a3;
            }
            if (hp == 4)
            {
                gameObject.GetComponent<Image>().sprite = a4;
            }
            if (hp == 5)
            {
                gameObject.GetComponent<Image>().sprite = a5;
            }
            a = Instantiate(Talk1);
            a.transform.SetParent(parent.transform);
            float posx = Random.Range(-800, 800);
            float posy = Random.Range(-350, 1500);
            a.transform.localPosition = new Vector3(posx, posy);
        }

    }

}
