using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Scene : MonoBehaviour
{
    MainMove howscene;
    // Use this for initialization
    void Start()
    {
        howscene = GameObject.Find("Canvas/gr").GetComponent<MainMove>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("space"))
        {
            Debug.Log(howscene.start);
            if (howscene.start == true)
            {
                if (SceneManager.GetActiveScene().buildIndex == 1)
                {
                    SceneManager.LoadScene(2);
                }
            }
            else if (howscene.credit == true)
            {
                if (SceneManager.GetActiveScene().buildIndex == 1)
                {
                    SceneManager.LoadScene(3);
                }
            }
            else if (howscene.howto == true)
            {
                if (SceneManager.GetActiveScene().buildIndex == 1)
                {
                    SceneManager.LoadScene(4);
                }
            }
            else if (howscene.option == true)
            {
                if (SceneManager.GetActiveScene().buildIndex == 1)
                {
                    SceneManager.LoadScene(5);
                }
            }
            else if (howscene.exit == true)
            {
                Application.Quit();
            }

        }
    }

}
