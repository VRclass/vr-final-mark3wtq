using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WalkToLight : MonoBehaviour
{
	public float m_speed;
    
    private void Start()
    {
        m_speed = 0.8f;
    }

    // Update is called once per frame
    private void Update()
    {
    
		transform.Translate(Vector3.forward * Time.deltaTime * m_speed);

    }
}
