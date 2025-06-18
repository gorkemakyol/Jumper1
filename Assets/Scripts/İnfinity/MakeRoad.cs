using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MakeRoad : MonoBehaviour
{
    public Transform Road;
    public Transform Road1;
    public Transform Road2;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            Road.transform.position = new Vector3(Road2.transform.position.x, Road2.transform.position.y, Road2.transform.position.z + 50);

        }
    }
}
