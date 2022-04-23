using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField]private float jumpForce = 30f;
    private Rigidbody playerrb;
    [SerializeField] bool isOnGround = true;
    [SerializeField] bool isDead = false;
    private GameManager gameManager;
    private Animator playerAnim;
    public AudioSource audioSource;
    public AudioClip jumpSound;
    public AudioClip crashSound;
    public ParticleSystem Explosion;
    public ParticleSystem dirtSpash;

    // Start is called before the first frame update
    void Start()
    {
        dirtSpash.Play();
        playerAnim = GetComponent<Animator>();
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
        playerrb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && isOnGround && !isDead)
        {
            Jumping();
            playerAnim.SetTrigger("Jump_trig");
            isOnGround = false;
        }
    }
    private void Jumping()
    {
        
        playerrb.AddForce(Vector3.up*jumpForce,ForceMode.Impulse);
        audioSource.PlayOneShot(jumpSound);
        dirtSpash.Stop();
        
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            dirtSpash.Play();
            isOnGround = true;
        }
        if (collision.gameObject.CompareTag("Obstacle"))
        {
            gameManager.GameOver();
            isDead = true;
            playerAnim.SetBool("Death_b", true);
            audioSource.PlayOneShot(crashSound);
            Explosion.Play();
            dirtSpash.Stop();
        }
    }
   
    


}
