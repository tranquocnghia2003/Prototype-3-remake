using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    private Vector3 spawnPos;
    public bool gameIsActive;
    private ObstacleGeneral obstaclePos;
    public List<GameObject> spawnObjectsPrefabs;
    
    // Start is called before the first frame update
    void Start()
    {
        
        obstaclePos = GameObject.Find("Obstacle").GetComponent<ObstacleGeneral>();
        StartCoroutine("SpawnObject");
        
    }
    IEnumerator SpawnObject()
    {
        yield return new WaitForSeconds(1.3f);
        SpawnManager();
        StartCoroutine("SpawnObject");
    }
    // Update is called once per frame
    void Update()
    {
        
    }
    private void SpawnManager()
    {
        int index = Random.Range(0, spawnObjectsPrefabs.Count);
        if(index == 1)
        {
            spawnPos = new Vector3(30f, 1.5f, 0f);
        }
        else
        {
            spawnPos = new Vector3(30f, 0f, 0f);
        }
        Instantiate(spawnObjectsPrefabs[index], spawnPos, Quaternion.Euler(Vector3.zero));
    }
}