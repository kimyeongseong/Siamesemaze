using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class change : MonoBehaviour
{
    MainMove e;
    public Sprite a;
    public Sprite b;
    public int sound = 1;
    // Use this for initialization
    void Awake()
    {
        e = GameObject.Find("gr").GetComponent<MainMove>();
        PlayerPrefs.GetInt("sound");
        PlayerPrefs.Save();

    }
    void Start()
    {
        if (PlayerPrefs.GetInt("sound") == 1)
        {
            gameObject.GetComponent<Image>().sprite = a;
            AudioListener.volume = 1;
        }
        else if (PlayerPrefs.GetInt("sound") == 0)
        {
            gameObject.GetComponent<Image>().sprite = b;
            AudioListener.volume = 0;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("space"))
        {
            if (PlayerPrefs.GetInt("sound") == 1)
            {
                gameObject.GetComponent<Image>().sprite = b;
                AudioListener.volume = 0;
                PlayerPrefs.SetInt("sound", 0);
                PlayerPrefs.Save();
            }
            else if (PlayerPrefs.GetInt("sound") == 0)
            {
                gameObject.GetComponent<Image>().sprite = a;
                e.pause.Play();
                AudioListener.volume = 1;
                PlayerPrefs.SetInt("sound", 1);
                PlayerPrefs.Save();
            }
        }
    }
}
