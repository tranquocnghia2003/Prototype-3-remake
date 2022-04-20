using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundMovement : MonoBehaviour
{
    private float speed = 15f;
    private float backgroundCenter;
    private Vector3 origionalPos;
    private float origionalX;
    // Start is called before the first frame update
    void Start()
    {
        origionalPos = transform.position;
        origionalX = transform.position.x;
        backgroundCenter = GetComponent<BoxCollider>().size.x / 2;
    }

    // Update is called once per frame
    void Update()
    {
        Backgroundmovement();
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
