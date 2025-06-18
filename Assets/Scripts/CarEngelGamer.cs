using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarEngelGamer : MonoBehaviour
{
    [SerializeField] float spawnTime = 4f;
    Quaternion TersDondur;
    Quaternion YarimDondur;

    public GameObject Player;
    public GameObject Obstacle1, Obstacle2, Obstacle3, Obstacle4, Obstacle5;

    private void Start()
    {
        TersDondur = Quaternion.Euler(0, 180, 0);
        YarimDondur = Quaternion.Euler(0, 90, 0);

        InvokeRepeating("ObstacleMake", 1, spawnTime);
    }

    public GameObject obstacleParentGO;

    void ObstacleMake()
    {
       
        int randomObstacle = Random.Range(1, 6);

        switch (randomObstacle)
        {
            case 1:
                Instantiate(Obstacle1, new Vector3(2.6f, -1.007f, Player.transform.position.z + 80), Quaternion.identity).transform.parent = obstacleParentGO.transform;
                break;
            case 2:
                Instantiate(Obstacle2, new Vector3(0.85f, -1f, Player.transform.position.z + 80), TersDondur).transform.parent = obstacleParentGO.transform;
                break;

            case 3:
                Instantiate(Obstacle3, new Vector3(0.5f, -1.007f, Player.transform.position.z + 80), Quaternion.identity).transform.parent = obstacleParentGO.transform;
                break;
            case 4:
                Instantiate(Obstacle4, new Vector3(0.5f, -1f, Player.transform.position.z + 80), TersDondur).transform.parent = obstacleParentGO.transform;
                break;

            case 5:
                Instantiate(Obstacle5, new Vector3(0.5f, -1.007f, Player.transform.position.z + 80), YarimDondur).transform.parent = obstacleParentGO.transform;
                break;
           

        }

    }
}
