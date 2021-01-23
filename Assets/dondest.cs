using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.SceneManagement;
public class dondest : MonoBehaviour
{
    public AudioClip _playBgm;
    public AudioClip _damaEffSound;
    public GameObject a;
    public bool sound;
    void Awake()
    {
        //DontDestroyOnLoad(transform.gameObject);
        DontDestroyOnLoad(a);
        DontDestroyOnLoad(this);
    }

    void Start()
    {
        DontDestroyOnLoad(this.gameObject);

    }
    private void Update()
    {
        if ((SceneManager.GetActiveScene().buildIndex == 0 || SceneManager.GetActiveScene().buildIndex == 1 || SceneManager.GetActiveScene().buildIndex == 2) && sound == false)
        {
            Debug.Log("soundon");

            //GameObject.GetComponent<AudioSource>().Play();
            gameObject.GetComponent<AudioSource>().Play();
            sound = true;
        }
        if (SceneManager.GetActiveScene().buildIndex >= 3 && sound == true)
        {
            //GameObject.GetComponent<AudioSource>().Play();
            Debug.Log("soundoff");
            gameObject.GetComponent<AudioSource>().Pause();
            sound = false;
        }
    }
}

