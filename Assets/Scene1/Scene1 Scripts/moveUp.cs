using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveUp : MonoBehaviour
{
    public float m_speed;

    void Update()
    {
        transform.Translate(Vector3.up * Time.deltaTime * m_speed);
    }
}
