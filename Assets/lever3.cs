using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class lever3 : MonoBehaviour
{
    float timer;
    float waitingTime;
    public GameObject disappearwell;
    public GameObject disappearwell2;
    public GameObject disappearwell3;
    public GameObject disappearwell4;
    void Start()
    {
        timer = 0.0f;
        waitingTime = 2.0f;
    }
    // Use this for initialization

    // Update is called once per frame
    void Update()
    {

    }
    private void OnTriggerStay(Collider other)
    {
        if (other.tag == "Player")
        {
            timer += Time.deltaTime;
            Debug.Log(timer);
            if (timer > waitingTime)
            {
                //Action
                timer = 0;
                disappearwell.GetComponent<Image>().color = new Color(disappearwell.GetComponent<Image>().color.r, disappearwell.GetComponent<Image>().color.g, disappearwell.GetComponent<Image>().color.b, 0);
                disappearwell.GetComponent<BoxCollider>().isTrigger = true;
                disappearwell2.GetComponent<Image>().color = new Color(disappearwell.GetComponent<Image>().color.r, disappearwell.GetComponent<Image>().color.g, disappearwell.GetComponent<Image>().color.b, 0);
                disappearwell2.GetComponent<BoxCollider>().isTrigger = true;
                disappearwell3.GetComponent<Image>().color = new Color(disappearwell.GetComponent<Image>().color.r, disappearwell.GetComponent<Image>().color.g, disappearwell.GetComponent<Image>().color.b, 0);
                disappearwell3.GetComponent<BoxCollider>().isTrigger = true;
                disappearwell4.GetComponent<Image>().color = new Color(disappearwell.GetComponent<Image>().color.r, disappearwell.GetComponent<Image>().color.g, disappearwell.GetComponent<Image>().color.b, 0);
                disappearwell4.GetComponent<BoxCollider>().isTrigger = true;
            }
        }

    }
    private void OnTriggerExit(Collider other)
    {
        //Action
        timer = 0;
        disappearwell.GetComponent<Image>().color = new Color(disappearwell.GetComponent<Image>().color.r, disappearwell.GetComponent<Image>().color.g, disappearwell.GetComponent<Image>().color.b, 0);
        disappearwell.GetComponent<BoxCollider>().isTrigger = false;
        disappearwell2.GetComponent<Image>().color = new Color(disappearwell.GetComponent<Image>().color.r, disappearwell.GetComponent<Image>().color.g, disappearwell.GetComponent<Image>().color.b, 0);
        disappearwell2.GetComponent<BoxCollider>().isTrigger = false;
        disappearwell3.GetComponent<Image>().color = new Color(disappearwell.GetComponent<Image>().color.r, disappearwell.GetComponent<Image>().color.g, disappearwell.GetComponent<Image>().color.b, 0);
        disappearwell3.GetComponent<BoxCollider>().isTrigger = false;
        disappearwell4.GetComponent<Image>().color = new Color(disappearwell.GetComponent<Image>().color.r, disappearwell.GetComponent<Image>().color.g, disappearwell.GetComponent<Image>().color.b, 0);
        disappearwell4.GetComponent<BoxCollider>().isTrigger = false;
    }
}
