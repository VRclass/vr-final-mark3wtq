using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveTimer : MonoBehaviour
{
    public float m_speed;

    void Start()
{
m_speed = 0.8f;

}

    void Update()
    {
        transform.Translate(Vector3.forward * Time.deltaTime * m_speed);
    }
}
