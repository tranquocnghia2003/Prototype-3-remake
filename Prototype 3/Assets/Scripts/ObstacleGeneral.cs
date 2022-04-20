using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleGeneral : MonoBehaviour
{
    private float boundary = -10f;
    [SerializeField] float speed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        DestroyOutOfBound();
        MoveLeft();
    }
    private void DestroyOutOfBound()
    {
        if(transform.position.x < boundary)
        {
            Destroy(gameObject);
        }
    }
    public virtual void MoveLeft()
    {
        transform.Translate(Vector3.left * speed * Time.deltaTime);
    }
}
