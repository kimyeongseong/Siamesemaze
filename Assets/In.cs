using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class In : MonoBehaviour
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
    Rigidbody rigid;
    Animator animator;
    public int tret;
    Vector3 m_vCrushSavePos;
    Vector3 tre;
    public bool tretertr;
    public bool left, right, up, down = false;
    Clear clearnum;
    Clear clearnum2;
    stagemove rtet;

    // Use this for initialization
    void Start()
    {
        //tre = new Vector3(0, 100, 0);
        clearnum = GameObject.Find("clear").GetComponent<Clear>();
        clearnum2 = GameObject.Find("clear2").GetComponent<Clear>();    
        rtet = GameObject.Find("move").GetComponent<stagemove>();
        if (rtet == null)
        {
            rtet = null;
        }
    }

    //    if (Input.GetKey(KeyCode.A) == true)
    //    {
    //        transform.localPosition = new Vector3(transform.localPosition.x - (-(speed + 1)), transform.localPosition.y, transform.localPosition.z);
    //        state = 1;
    //        if (Input.GetKey(KeyCode.W) == true)
    //        {
    //            transform.localPosition = new Vector3(transform.localPosition.x, transform.localPosition.y + ((-(speed + 1)) / 2), transform.localPosition.z);
    //            state = 5;
    //        }
    //        else if (Input.GetKey(KeyCode.S) == true)
    //        {
    //            transform.localPosition = new Vector3(transform.localPosition.x, transform.localPosition.y - ((-(speed + 1)) / 2), transform.localPosition.z);
    //            state = 6;
    //        }
    //    }
    //    else if (Input.GetKey(KeyCode.W) == true)
    //    {
    //        transform.localPosition = new Vector3(transform.localPosition.x, transform.localPosition.y + ((-(speed + 1)) / 2), transform.localPosition.z);
    //        state = 2;
    //        if (Input.GetKey(KeyCode.A) == true)
    //        {
    //            transform.localPosition = new Vector3(transform.localPosition.x - (-(speed + 1)), transform.localPosition.y, transform.localPosition.z);
    //            state = 5;
    //        }
    //        if (Input.GetKey(KeyCode.D) == true)
    //        {
    //            transform.localPosition = new Vector3(transform.localPosition.x + (-(speed + 1)), transform.localPosition.y, transform.localPosition.z);
    //            state = 7;
    //        }
    //    }
    //    else if (Input.GetKey(KeyCode.D) == true)
    //    {
    //        transform.localPosition = new Vector3(transform.localPosition.x + (-(speed + 1)), transform.localPosition.y, transform.localPosition.z);
    //        state = 3;
    //        if (Input.GetKey(KeyCode.W) == true)
    //        {
    //            transform.localPosition = new Vector3(transform.localPosition.x, transform.localPosition.y + ((-(speed + 1)) / 2), transform.localPosition.z);
    //            state = 7;
    //        }
    //        else if (Input.GetKey(KeyCode.S) == true)
    //        {
    //            transform.localPosition = new Vector3(transform.localPosition.x, transform.localPosition.y - ((-(speed + 1)) / 2), transform.localPosition.z);
    //            state = 8;
    //        }
    //    }
    //    else if (Input.GetKey(KeyCode.S) == true)
    //    {
    //        transform.localPosition = new Vector3(transform.localPosition.x, transform.localPosition.y - ((-(speed + 1)) / 2), transform.localPosition.z);
    //        state = 4;
    //        if (Input.GetKey(KeyCode.D) == true)
    //        {
    //            transform.localPosition = new Vector3(transform.localPosition.x + (-(speed + 1)), transform.localPosition.y, transform.localPosition.z);
    //            state = 8;
    //        }
    //        else if (Input.GetKey(KeyCode.A) == true)
    //        {
    //            transform.localPosition = new Vector3(transform.localPosition.x - (-(speed + 1)), transform.localPosition.y, transform.localPosition.z);
    //            state = 6;
    //        }
    //    }
    //    tretertr = true;
    //}
    private void Update()
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

                    if (Input.GetKey(KeyCode.A) == true)
                    {
                        transform.localPosition = new Vector3(transform.localPosition.x - speed, transform.localPosition.y, transform.localPosition.z);
                        state = 1;
                        if (Input.GetKey(KeyCode.W) == true)
                        {
                            transform.localPosition = new Vector3(transform.localPosition.x, transform.localPosition.y + (speed / 2), transform.localPosition.z);
                            state = 5;
                        }
                        else if (Input.GetKey(KeyCode.S) == true)
                        {
                            transform.localPosition = new Vector3(transform.localPosition.x, transform.localPosition.y - (speed / 2), transform.localPosition.z);
                            state = 6;
                        }
                    }
                    else if (Input.GetKey(KeyCode.W) == true)
                    {
                        transform.localPosition = new Vector3(transform.localPosition.x, transform.localPosition.y + (speed), transform.localPosition.z);
                        state = 2;
                        if (Input.GetKey(KeyCode.A) == true)
                        {
                            transform.localPosition = new Vector3(transform.localPosition.x - (speed / 2), transform.localPosition.y, transform.localPosition.z);
                            state = 5;
                        }
                        if (Input.GetKey(KeyCode.D) == true)
                        {
                            transform.localPosition = new Vector3(transform.localPosition.x + (speed / 2), transform.localPosition.y, transform.localPosition.z);
                            state = 7;
                        }
                    }
                    else if (Input.GetKey(KeyCode.D) == true)
                    {
                        transform.localPosition = new Vector3(transform.localPosition.x + speed, transform.localPosition.y, transform.localPosition.z);
                        state = 3;
                        if (Input.GetKey(KeyCode.W) == true)
                        {
                            transform.localPosition = new Vector3(transform.localPosition.x, transform.localPosition.y + (speed / 2), transform.localPosition.z);
                            state = 7;
                        }
                        else if (Input.GetKey(KeyCode.S) == true)
                        {
                            transform.localPosition = new Vector3(transform.localPosition.x, transform.localPosition.y - (speed / 2), transform.localPosition.z);
                            state = 8;
                        }
                    }
                    else if (Input.GetKey(KeyCode.S) == true)
                    {
                        transform.localPosition = new Vector3(transform.localPosition.x, transform.localPosition.y - (speed), transform.localPosition.z);
                        state = 4;
                        if (Input.GetKey(KeyCode.D) == true)
                        {
                            transform.localPosition = new Vector3(transform.localPosition.x + (speed / 2), transform.localPosition.y, transform.localPosition.z);
                            state = 8;
                        }
                        else if (Input.GetKey(KeyCode.A) == true)
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
                if (_anim != null)
                {
                    //_anim.GetInteger("playerState");
                    //_anim.SetInteger("playerState", (int)_state);
                    //state = 0;
                    _anim.SetInteger("playerState", state);
                }
            }
        }
        if (SceneManager.GetActiveScene().buildIndex!=6)
        {
            if (clearnum.StageClear == false || clearnum2.StageClear == false)
            {
                if (Input.anyKey == true )
                {

                    if (Input.GetKey(KeyCode.A) == true)
                    {
                        transform.localPosition = new Vector3(transform.localPosition.x - speed, transform.localPosition.y, transform.localPosition.z);
                        state = 1;
                        if (Input.GetKey(KeyCode.W) == true)
                        {
                            transform.localPosition = new Vector3(transform.localPosition.x, transform.localPosition.y + (speed / 2), transform.localPosition.z);
                            state = 5;
                        }
                        else if (Input.GetKey(KeyCode.S) == true)
                        {
                            transform.localPosition = new Vector3(transform.localPosition.x, transform.localPosition.y - (speed / 2), transform.localPosition.z);
                            state = 6;
                        }
                    }
                    else if (Input.GetKey(KeyCode.W) == true)
                    {
                        transform.localPosition = new Vector3(transform.localPosition.x, transform.localPosition.y + (speed), transform.localPosition.z);
                        state = 2;
                        if (Input.GetKey(KeyCode.A) == true)
                        {
                            transform.localPosition = new Vector3(transform.localPosition.x - (speed / 2), transform.localPosition.y, transform.localPosition.z);
                            state = 5;
                        }
                        if (Input.GetKey(KeyCode.D) == true)
                        {
                            transform.localPosition = new Vector3(transform.localPosition.x + (speed / 2), transform.localPosition.y, transform.localPosition.z);
                            state = 7;
                        }
                    }
                    else if (Input.GetKey(KeyCode.D) == true)
                    {
                        transform.localPosition = new Vector3(transform.localPosition.x + speed, transform.localPosition.y, transform.localPosition.z);
                        state = 3;
                        if (Input.GetKey(KeyCode.W) == true)
                        {
                            transform.localPosition = new Vector3(transform.localPosition.x, transform.localPosition.y + (speed / 2), transform.localPosition.z);
                            state = 7;
                        }
                        else if (Input.GetKey(KeyCode.S) == true)
                        {
                            transform.localPosition = new Vector3(transform.localPosition.x, transform.localPosition.y - (speed / 2), transform.localPosition.z);
                            state = 8;
                        }
                    }
                    else if (Input.GetKey(KeyCode.S) == true)
                    {
                        transform.localPosition = new Vector3(transform.localPosition.x, transform.localPosition.y - (speed), transform.localPosition.z);
                        state = 4;
                        if (Input.GetKey(KeyCode.D) == true)
                        {
                            transform.localPosition = new Vector3(transform.localPosition.x + (speed / 2), transform.localPosition.y, transform.localPosition.z);
                            state = 8;
                        }
                        else if (Input.GetKey(KeyCode.A) == true)
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
                if (_anim != null)
                {
                    //_anim.GetInteger("playerState");
                    //_anim.SetInteger("playerState", (int)_state);
                    //state = 0;
                    _anim.SetInteger("playerState", state);
                }
            }
        }
            //if (transform.localPosition.x > 920)//오른쪽 상단
            //{
            //    transform.localPosition = new Vector3(920, transform.localPosition.y, 0);
            //    Debug.Log(transform.localPosition.x);
            //    return;
            //}
            //if (transform.localPosition.x < -920)//오른쪽 상단
            //{
            //    Debug.Log(transform.localPosition.x);
            //    transform.localPosition = new Vector3(-920, transform.localPosition.y, 0);

            //    return;
            //}
            //if (transform.localPosition.y > 1720)//오른쪽 상단
            //{
            //    Debug.Log(transform.localPosition.y);
            //    transform.localPosition = new Vector3(transform.localPosition.x, 1720, 0);
            //    return;
            //}
            //if (transform.localPosition.y < -480)//오른쪽 상단
            //{
            //    transform.localPosition = new Vector3(transform.localPosition.x, -480, 0);
            //    return;
            //}
        }
}    //if (Input.GetAxisRaw("Horizontal")<0)
     //{
     //    //animator.SetInteger("Blend", -1);
     //}
     //if (Input.GetAxisRaw("Vertical") > 0)
     //{
     //    //animator.SetInteger("Blend", +1);
     //}
     //transform.Translate(Vector3.right * speed * Time.smoothDeltaTime * keyHorizontal, Space.World);
     //transform.Translate(Vector3.up * speed * Time.smoothDeltaTime * keyVertical, Space.World);
     ////Move = true;

//down = false;
//left = false;
//right = false;
//up = false;
//if (left==true&&up==true)
//{
//    transform.localPosition = new Vector3(transform.localPosition.x - speed, transform.localPosition.y+speed, transform.localPosition.z);
//    state = 5;
//    Debug.Log(left);
//}
//else if (left == true && down == true)
//{
//    transform.localPosition = new Vector3(transform.localPosition.x - speed, transform.localPosition.y-speed, transform.localPosition.z);
//    state = 6;
//    Debug.Log(left);
//}
//else if (right == true && up == true)
//{
//    transform.localPosition = new Vector3(transform.localPosition.x + speed, transform.localPosition.y + speed, transform.localPosition.z);
//    state = 7;

//    Debug.Log(left);
//}
//else if (right == true && down == true)
//{
//    transform.localPosition = new Vector3(transform.localPosition.x+speed, transform.localPosition.y-speed, transform.localPosition.z);
//    state = 8;
//    Debug.Log(left);
//} 
//float keyHorizontal = Input.GetAxis("Horizontal");
//float keyVertical = Input.GetAxis("Vertical");
//state = 0;
////Debug.Log(_anim);
//if (Input.GetAxisRaw("Horizontal") < 0 && Input.GetAxisRaw("Vertical") > 0 /*&& Move == true*/)
//{
//    transform.localEulerAngles = new Vector3(transform.localRotation.x, transform.localRotation.y, 45); 
//    state = 1;
//}
//else if (Input.GetAxisRaw("Horizontal") > 0 && Input.GetAxisRaw("Vertical") > 0)
//{
//    transform.localEulerAngles = new Vector3(transform.localRotation.x, transform.localRotation.y, -45);
//    state = 1;
//}
//else if (Input.GetAxisRaw("Horizontal") < 0 && Input.GetAxisRaw("Vertical") < 0)
//{
//    transform.localEulerAngles = new Vector3(transform.localRotation.x, transform.localRotation.y, 135);
//    state = 1;
//}
//else if (Input.GetAxisRaw("Horizontal") > 0 && Input.GetAxisRaw("Vertical") < 0)
//{
//    transform.localEulerAngles = new Vector3(transform.localRotation.x, transform.localRotation.y, -135);
//    state = 1;
//}
//else if (Input.GetAxisRaw("Horizontal") < 0)//왼쪽
//{
//    transform.localEulerAngles = new Vector3(transform.localRotation.x, transform.localRotation.y, 90);
//    state = 1;
//    Debug.Log(state);

//}
//else if (Input.GetAxisRaw("Vertical") > 0)//위
//{
//    transform.localEulerAngles = new Vector3(transform.localRotation.x, transform.localRotation.y, 0);
//    state = 2;
//    Debug.Log(state);
//}

//else if (Input.GetAxisRaw("Horizontal") > 0)//오른쪽
//{
//    state = 3;
//    Debug.Log(state);
//    transform.localEulerAngles = new Vector3(transform.localRotation.x, transform.localRotation.y, -90);
//}
//else if (Input.GetAxisRaw("Vertical") < 0)//아래
//{
//    state = 4;
//    Debug.Log(state);
//    //transform.localEulerAngles = new Vector3(transform.localRotation.x, transform.localRotation.y, 180);
//    transform.localPosition = new Vector3(transform.localRotation.x, this.transform.localRotation.y-1, 180);
//    gameObject.transform.localPosition = new Vector3(gameObject.transform.localPosition.x,gameObject.transform.localRotation.y - 1, 180);
//}