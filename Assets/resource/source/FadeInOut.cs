using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class FadeInOut : MonoBehaviour
{
    public float alpha = 0;
    public bool b = false;
    //public AudioSource pause;
     public float fDestroyTime = 4.0f;
    public float fDestroyTime2 = 1.0f;
    public float fAlpha = 0;
    public float fTickTime, fTickTime2;
    public bool q, c, d, e = false;
    void Start()
    {
        q = false;
    }
    void Update()
    {
        fTickTime += Time.deltaTime;
        fAlpha = (fTickTime / fDestroyTime2) /** 4.0f*/;    
        alpha = fAlpha;
        if (fAlpha >= 1.0f)
        {
            if (q == false)
            {
                //pause.Play();
                q = true;
            }
            alpha = 1.0f;
        }
        if (fAlpha >= 3.0f)
        {
            alpha = 4.0f - fAlpha;
            if (alpha <= 0.02f)
                if (SceneManager.GetActiveScene().buildIndex == 0)
                {
                    SceneManager.LoadScene(1);
                }
        }
        GetComponent<Image>().color = new Color(255, 255 / 255, 255 / 255, alpha);
    }
}