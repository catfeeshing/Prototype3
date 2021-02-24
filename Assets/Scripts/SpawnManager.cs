using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{

    public GameObject obstaclePrefab;
    private Vector3 spawnPos = new Vector3(25, 0, 0);


    private PlayerController playerControllerScript;

    private float startDelay = 2;
    private float repeatRate = 2;

    private GameObject obs;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnObstacle", startDelay, repeatRate);
        playerControllerScript = GameObject.Find("Player").GetComponent<PlayerController>();
    }

    // Update is called once per frame
    void Update()
    {
        if (obs.transform.position.x < -15)
        {
            Destroy(obs);
        }
    }

    void SpawnObstacle()
    {
        if (playerControllerScript.gameOver == false)
        {
            obs = Instantiate(obstaclePrefab, spawnPos, obstaclePrefab.transform.rotation);
        }
    }
}
