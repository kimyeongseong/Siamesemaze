using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class oijhgfds : MonoBehaviour {

    // Use this for initialization


    public float m_fSpeed = 0;
    public int m_nIsLeft = 0;
	void Start () {
        int asd = Random.Range(0, 100);
        m_nIsLeft = 1;
        if (asd >= 50)
            m_nIsLeft = 0;
        m_fSpeed = Random.Range(3, 10);
        if (m_nIsLeft == 1)
        {
            m_fSpeed = Random.Range(-10, -3);
        }
    }
	
	// Update is called once per frame
	void Update () {
        
        if (m_nIsLeft == 1)
        {
            if (transform.localPosition.x >= 1300)
            {
                transform.localPosition = new Vector3(-1300, Random.Range(-35, 45)*10, transform.localPosition.z);
                m_fSpeed = Random.Range(-10, -3);
                int asd = Random.Range(0, 100);
                m_nIsLeft = 1;
                if (asd >= 50)
                {
                    m_nIsLeft = 0;
                    m_fSpeed = Random.Range(3, 10);
                }
            }
        }
        if(m_nIsLeft==0)
        {
            if (transform.localPosition.x <= -1300)
            {
                transform.localPosition = new Vector3(+1300, Random.Range(-35, 45)*10, transform.localPosition.z);
                m_fSpeed = Random.Range(-10, -3);
                int asd = Random.Range(0, 100);
                m_nIsLeft = 1;
                if (asd >= 50)
                {
                    m_nIsLeft = 0;
                    m_fSpeed = Random.Range(3, 10);
                }
            }
        }
        
        transform.localPosition = new Vector3(transform.localPosition.x - m_fSpeed, transform.localPosition.y, transform.localPosition.z);

    }
}
