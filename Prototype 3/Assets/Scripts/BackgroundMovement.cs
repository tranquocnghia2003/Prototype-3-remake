using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundMovement : MonoBehaviour
{
    private float speed = 15f;
    private float backgroundCenter;
    private GameManager gameManager;
    private Vector3 origionalPos;
    private float origionalX;
    
    // Start is called before the first frame update
    void Start()
    {
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
        origionalPos = transform.position;
        origionalX = transform.position.x;
        backgroundCenter = GetComponent<BoxCollider>().size.x / 2;
    }

    // Update is called once per frame
    void Update()
    {

        if (gameManager.gameOver != true)
        {
            Backgroundmovement();
        }
        
    }
    private void Backgroundmovement()
    {
        transform.Translate(Vector3.left * speed * Time.deltaTime);
        if(transform.position.x < origionalX - backgroundCenter)
        {
            transform.position = origionalPos;
        }

    }
}
