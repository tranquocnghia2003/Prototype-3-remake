using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField]private float jumpForce = 30f;
    private Rigidbody playerrb;
    [SerializeField] bool isOnGround = true;
    [SerializeField] bool isDead = false;
    // Start is called before the first frame update
    void Start()
    {
        playerrb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && isOnGround)
        {
            Jumping();
            isOnGround = false;
        }
    }
    private void Jumping()
    {
        
            playerrb.AddForce(Vector3.up*jumpForce,ForceMode.Impulse);
        
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            isOnGround = true;
        }  
    }


}
