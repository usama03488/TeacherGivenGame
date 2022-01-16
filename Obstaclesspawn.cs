using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstaclesspawn : MonoBehaviour

{
    public GameObject[] Obstacles;
    public int number;
    private float sideX = 20;
    private float sideZ = 20;
    public SubwayController spawning;
    
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnRandomAnimal", 2, 1.5f);
        spawning = GameObject.Find("Players1").GetComponent<SubwayController>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void SpawnRandomAnimal()
    {
        int animalIndex = Random.Range(0, 4);
        Vector3 spawnpos = new Vector3(Random.Range(-sideX, sideX), 0, sideZ);
        if (spawning.gameover == false)
        {
            for (int i = 0; i < 4; i++)
            {
                if (i != animalIndex)
                {
                    Instantiate(Obstacles[i], Obstacles[i].transform.position, Obstacles[i].transform.rotation);

                }

            }
        }
        else
        {
            Debug.Log("GAME OVER");
        }
 

    }
}
