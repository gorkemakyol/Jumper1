using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MakeRoad2 : MonoBehaviour
{
    public Transform Road;
    public Transform Road1;
    public Transform Road2;

        
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            Road1.transform.position = new Vector3(Road.transform.position.x, Road.transform.position.y, Road.transform.position.z + 50);

        }
    }

}
