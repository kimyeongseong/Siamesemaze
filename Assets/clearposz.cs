using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class clearposz : MonoBehaviour {
    public int x, y, z;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        transform.rotation = Quaternion.Euler(x, y, z+=1);
    }
}
