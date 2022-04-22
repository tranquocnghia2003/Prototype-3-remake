using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleGeneral : MonoBehaviour
{
    private GameManager gameManager;
    private float boundary = -3f;
    [SerializeField] float speed;
    // Start is called before the first frame update
    void Start()
    {
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {
        if(gameManager.gameOver == false)
        {
            MoveLeft();
        }
        
        DestroyOutOfBound();
        
    }
    private void DestroyOutOfBound()
    {
        if(transform.position.y < boundary)
        {
            Destroy(gameObject);
        }
    }
    public  void MoveLeft()
    {
        transform.Translate(Vector3.left * speed * Time.deltaTime);
    }
 
}
