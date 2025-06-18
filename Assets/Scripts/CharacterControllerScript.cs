using System.Collections;
using System.Collections.Generic;
using System.Timers;
using UnityEngine;

public class CharacterControllerScript : MonoBehaviour
{
    CharacterController characterController;
    Animator Jump; // Zıplama animasyonu

    public float speed = 4.5f; // Karakterin koşu hızı
    public float MoveSpeed = 1f; // Karakterin sağ sol hareket hızı

    public bool Yerde = false;

    public Rigidbody RG;
    private Vector3 direction, forwardDirection;

    public float jumpSpeed = 2.0f;
    public float gravity = 10.0f;
    private Vector3 movingDirection = Vector3.zero;

    AudioSource jumpEffect;

    private void Start()
    {
        characterController = this.GetComponent<CharacterController>();
        jumpEffect = GameObject.Find("SoundEffects").transform.GetChild(1).gameObject.GetComponent<AudioSource>();

        Jump = GetComponent<Animator>();
    }

    private void FixedUpdate()
    {
        transform.Translate(0, 0, speed * Time.deltaTime); // Düz gtmesini sağlıyoruz

        float hInput = Input.GetAxis("Horizontal");
        direction.x = hInput * speed;
        characterController.Move(direction * Time.deltaTime);

        if (Yerde && Input.GetButton("Jump")) // Eğer karakter yerdeyse ve boşluğa bastıysak
        {
            movingDirection.y = jumpSpeed;
            Jump.SetTrigger("Jump");

            jumpEffect.Play();

            Yerde = false;
        }
        movingDirection.y -= gravity * Time.deltaTime;
        characterController.Move(movingDirection * Time.deltaTime);

    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Road")
        {
            Yerde = true;
        }
    }
}
