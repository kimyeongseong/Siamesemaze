using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rigi : MonoBehaviour {
    Rigidbody rigidb;
    // Use this for initialization
    void Start () {
        rigidb = GetComponent<Rigidbody>();
        gameObject.GetComponent<Rigidbody>().velocity = Vector3.zero;
    }
	
	// Update is called once per frame
	void Update () {
        rigidb.velocity = Vector3.zero;
       
    }
}
