using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public bool gameIsActive;
    public List<GameObject> spawnObjectsPrefabs;
    
    // Start is called before the first frame update
    void Start()
    {
       
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
        Vector3 SpawnPos = new Vector3(30, 0f, 0f); 
        Instantiate(spawnObjectsPrefabs[Random.Range(0, spawnObjectsPrefabs.Count)], SpawnPos, Quaternion.Euler(Vector3.zero));
    }
}
