using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class savedate : MonoBehaviour {
    public bool sound = true;

    // Use this for initialization
    void Start () {
        if (PlayerPrefs.GetInt("sound") == 1)
        {
            AudioListener.volume = 0.75f;
        }
        else if (PlayerPrefs.GetInt("sound") == 0)
        {
            AudioListener.volume = 0;
        }
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
