using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class exitpopup : MonoBehaviour {
    MainMove feverGauge;
    void Awake()
    {
        feverGauge = GameObject.Find("gr").GetComponent<MainMove>();
    }
    // Use this for initialization
    void Start () {
        //feverGauge.trye = false;
    }

    // Update is called once per frame
    void Update () {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            feverGauge.trye = false;
            Destroy(gameObject);
        }
    }
}
