using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarMoveX : MonoBehaviour
{
    public int speed = 1;
    void Update()
    {
        transform.Translate(1 * speed * Time.deltaTime, 0, 0);
    }
}
