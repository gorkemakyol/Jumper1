using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MakeRoad3 : MonoBehaviour
{
    public Transform Road;
    public Transform Road1;
    public Transform Road2;
 
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            Road2.transform.position = new Vector3(Road1.transform.position.x, Road1.transform.position.y, Road1.transform.position.z + 50);
         
        }
    }
}
