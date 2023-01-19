using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Residuo : MonoBehaviour
{
    void Start()
    {
        Transform transform= GetComponent<Transform>();
        
    }

    void Update()
    {
        if(transform.position.y < -5.5)
        {
            Destroy(gameObject);
        }
    }
}
