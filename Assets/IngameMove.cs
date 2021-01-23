using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class IngameMove : MonoBehaviour
{
    public enum playerState
    {
        whait = 0,
        move,
        //down
    }
    bool m_bCrush = false;
    public int state = 0;
    public Animator _anim;
    public playerState _state = playerState.move;
    public int speed = 4;
    public bool Move;
    public bool a, b, c, d, e;
    Animator animator;
    public int tret;
    Vector3 m_vCrushSavePos;
    Vector3 tre;
    public bool tretertr;
    public bool left, right, up, down = false;
    Clear clearnum;
    Clear clearnum2;
    // Use this for initialization
    stagemove rtet;
    void Start()
    {



        //tre = new Vector3(0, 100, 0);
        clearnum = GameObject.Find("clear").GetComponent<Clear>();
        clearnum2 = GameObject.Find("clear2").GetComponent<Clear>();
        rtet = GameObject.Find("move").GetComponent<stagemove>();

        if (rtet == null)
        {
            rtet.tre = true;
        }
    }

    void Update()
    {
        move();
    }

    public void move()
    {
        if (SceneManager.GetActiveScene().buildIndex == 6)

        {
            if (clearnum.StageClear == false || clearnum2.StageClear == false)
            {
                if (Input.anyKey == true && rtet.tre == true)
                {

                    if (Input.GetKey(KeyCode.LeftArrow) == true)
                    {
                        transform.localPosition = new Vector3(transform.localPosition.x - speed, transform.localPosition.y, transform.localPosition.z);
                        state = 1;
                        if (Input.GetKey(KeyCode.UpArrow) == true)
                        {
                            transform.localPosition = new Vector3(transform.localPosition.x, transform.localPosition.y + (speed / 2), transform.localPosition.z);
                            state = 5;
                        }
                        else if (Input.GetKey(KeyCode.DownArrow) == true)
                        {
                            transform.localPosition = new Vector3(transform.localPosition.x, transform.localPosition.y - (speed / 2), transform.localPosition.z);
                            state = 6;
                        }
                    }
                    else if (Input.GetKey(KeyCode.UpArrow) == true)
                    {
                        transform.localPosition = new Vector3(transform.localPosition.x, transform.localPosition.y + (speed), transform.localPosition.z);
                        state = 2;
                        if (Input.GetKey(KeyCode.LeftArrow) == true)
                        {
                            transform.localPosition = new Vector3(transform.localPosition.x - (speed / 2), transform.localPosition.y, transform.localPosition.z);
                            state = 5;
                        }
                        if (Input.GetKey(KeyCode.RightArrow) == true)
                        {
                            transform.localPosition = new Vector3(transform.localPosition.x + (speed / 2), transform.localPosition.y, transform.localPosition.z);
                            state = 7;
                        }
                    }
                    else if (Input.GetKey(KeyCode.RightArrow) == true)
                    {
                        transform.localPosition = new Vector3(transform.localPosition.x + speed, transform.localPosition.y, transform.localPosition.z);
                        state = 3;
                        if (Input.GetKey(KeyCode.UpArrow) == true)
                        {
                            transform.localPosition = new Vector3(transform.localPosition.x, transform.localPosition.y + (speed / 2), transform.localPosition.z);
                            state = 7;
                        }
                        else if (Input.GetKey(KeyCode.DownArrow) == true)
                        {
                            transform.localPosition = new Vector3(transform.localPosition.x, transform.localPosition.y - (speed / 2), transform.localPosition.z);
                            state = 8;
                        }
                    }
                    else if (Input.GetKey(KeyCode.DownArrow) == true)
                    {
                        transform.localPosition = new Vector3(transform.localPosition.x, transform.localPosition.y - (speed), transform.localPosition.z);
                        state = 4;
                        if (Input.GetKey(KeyCode.RightArrow) == true)
                        {
                            transform.localPosition = new Vector3(transform.localPosition.x + (speed / 2), transform.localPosition.y, transform.localPosition.z);
                            state = 8;
                        }
                        else if (Input.GetKey(KeyCode.LeftArrow) == true)
                        {
                            transform.localPosition = new Vector3(transform.localPosition.x - (speed / 2), transform.localPosition.y, transform.localPosition.z);
                            state = 6;
                        }
                    }
                }
                else if (Input.anyKey == false)
                {
                    state = 0;
                }
            }
            if (_anim != null)
            {
                _anim.SetInteger("playerState", state);
            }
        }
        if (SceneManager.GetActiveScene().buildIndex != 6)

        {
            if (clearnum.StageClear == false || clearnum2.StageClear == false)
            {
                if (Input.anyKey == true)
                {

                    if (Input.GetKey(KeyCode.LeftArrow) == true)
                    {
                        transform.localPosition = new Vector3(transform.localPosition.x - speed, transform.localPosition.y, transform.localPosition.z);
                        state = 1;
                        if (Input.GetKey(KeyCode.UpArrow) == true)
                        {
                            transform.localPosition = new Vector3(transform.localPosition.x, transform.localPosition.y + (speed / 2), transform.localPosition.z);
                            state = 5;
                        }
                        else if (Input.GetKey(KeyCode.DownArrow) == true)
                        {
                            transform.localPosition = new Vector3(transform.localPosition.x, transform.localPosition.y - (speed / 2), transform.localPosition.z);
                            state = 6;
                        }
                    }
                    else if (Input.GetKey(KeyCode.UpArrow) == true)
                    {
                        transform.localPosition = new Vector3(transform.localPosition.x, transform.localPosition.y + (speed), transform.localPosition.z);
                        state = 2;
                        if (Input.GetKey(KeyCode.LeftArrow) == true)
                        {
                            transform.localPosition = new Vector3(transform.localPosition.x - (speed / 2), transform.localPosition.y, transform.localPosition.z);
                            state = 5;
                        }
                        if (Input.GetKey(KeyCode.RightArrow) == true)
                        {
                            transform.localPosition = new Vector3(transform.localPosition.x + (speed / 2), transform.localPosition.y, transform.localPosition.z);
                            state = 7;
                        }
                    }
                    else if (Input.GetKey(KeyCode.RightArrow) == true)
                    {
                        transform.localPosition = new Vector3(transform.localPosition.x + speed, transform.localPosition.y, transform.localPosition.z);
                        state = 3;
                        if (Input.GetKey(KeyCode.UpArrow) == true)
                        {
                            transform.localPosition = new Vector3(transform.localPosition.x, transform.localPosition.y + (speed / 2), transform.localPosition.z);
                            state = 7;
                        }
                        else if (Input.GetKey(KeyCode.DownArrow) == true)
                        {
                            transform.localPosition = new Vector3(transform.localPosition.x, transform.localPosition.y - (speed / 2), transform.localPosition.z);
                            state = 8;
                        }
                    }
                    else if (Input.GetKey(KeyCode.DownArrow) == true)
                    {
                        transform.localPosition = new Vector3(transform.localPosition.x, transform.localPosition.y - (speed), transform.localPosition.z);
                        state = 4;
                        if (Input.GetKey(KeyCode.RightArrow) == true)
                        {
                            transform.localPosition = new Vector3(transform.localPosition.x + (speed / 2), transform.localPosition.y, transform.localPosition.z);
                            state = 8;
                        }
                        else if (Input.GetKey(KeyCode.LeftArrow) == true)
                        {
                            transform.localPosition = new Vector3(transform.localPosition.x - (speed / 2), transform.localPosition.y, transform.localPosition.z);
                            state = 6;
                        }
                    }
                }
                else if (Input.anyKey == false)
                {
                    state = 0;
                }
            }
            if (_anim != null)
            {
                _anim.SetInteger("playerState", state);
            }
        }
    }
}