using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarMove : MonoBehaviour
{
    public float speed = 1;
    void Start()
    {
        
    }

    
    void Update()
    {
        transform.Translate(0,0, -1 * speed * Time.deltaTime);
    }
}
