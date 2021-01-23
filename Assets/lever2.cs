using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class lever2 : MonoBehaviour
{

    public enum leverState
    {
        down = 0,
        up,
        //down
    }
    float timer;
    int waitingTime;
    public GameObject disappearwell;
    public GameObject disappearwell2;
    public int state = 0;
    public Animator _anim;
    public leverState _state = leverState.up;
    void Start()
    {
        timer = 0.0f;
        waitingTime = 2;
    }
    // Use this for initialization

    // Update is called once per frame
    void Update()
    {
        if (_anim != null)
        {
            //_anim.GetInteger("playerState");
            //_anim.SetInteger("playerState", (int)_state);
            //state = 0;
            _anim.SetInteger("leverState", state);
        }
    }
    private void OnTriggerStay(Collider other)
    {
        if (other.tag == "Player2")
        {
            timer += Time.deltaTime;
            //Debug.Log(timer);
            if (timer > waitingTime)
            {
                //Action
                timer = 0;
                disappearwell.GetComponent<Image>().color = new Color(disappearwell.GetComponent<Image>().color.r, disappearwell.GetComponent<Image>().color.g, disappearwell.GetComponent<Image>().color.b, 0);
                disappearwell.GetComponent<BoxCollider>().isTrigger = true;
                disappearwell2.GetComponent<Image>().color = new Color(disappearwell.GetComponent<Image>().color.r, disappearwell.GetComponent<Image>().color.g, disappearwell.GetComponent<Image>().color.b, 0);
                disappearwell2.GetComponent<BoxCollider>().isTrigger = true;
            }
                
        }

    }

    public void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player2")
        {
            state = 1;


        }
    }
    private void OnTriggerExit(Collider other)
    {
        //Action
        timer = 0;
        state = 0;

        disappearwell.GetComponent<Image>().color = new Color(disappearwell.GetComponent<Image>().color.r, disappearwell.GetComponent<Image>().color.g, disappearwell.GetComponent<Image>().color.b, 100);
        disappearwell.GetComponent<BoxCollider>().isTrigger = false;
        disappearwell2.GetComponent<Image>().color = new Color(disappearwell.GetComponent<Image>().color.r, disappearwell.GetComponent<Image>().color.g, disappearwell.GetComponent<Image>().color.b, 100);
        disappearwell2.GetComponent<BoxCollider>().isTrigger = false;
        Debug.Log(state);
    }
}
