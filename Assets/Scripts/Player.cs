using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    public float gravity;
    public Vector2 velocity;
    public float jumpVelocity = 20;
    public float groundHeight = 10;
    public bool isGrounded = false;
    public int Health = 3;

    public bool isHoldingJump = false;
    public float maxHoldJumpTime = 0.4f;
    public float holdJumpTimer = 0.0f;

    public float jumpGroundThreshold = 1;

    public Projectile projectilePrefab;
    public Transform LauchPos;

    public Image Heart1;
    public Image Heart2;
    public Image Heart3;

    public Sprite deadHeart;

    void Start()
    {

    }

    void Update()
    {
        Vector2 pos = transform.position;
        float groundDistance = Mathf.Abs(pos.y - groundHeight);

        if (isGrounded || groundDistance <= jumpGroundThreshold)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                isGrounded = false;
                velocity.y = jumpVelocity;
                isHoldingJump = true;
                holdJumpTimer = 0;
            }
        }

        if (Input.GetKeyUp(KeyCode.Space))
        {
            isHoldingJump = false;
        }

        if (Input.GetKeyUp(KeyCode.W))
        {
            Instantiate(projectilePrefab, LauchPos.position, transform.rotation);
        } 

        if (Health <= 0)
        {
            Heart1.gameObject.GetComponent<Image>().sprite = deadHeart;
            Heart2.gameObject.GetComponent<Image>().sprite = deadHeart;
            Heart3.gameObject.GetComponent<Image>().sprite = deadHeart;
            SceneManager.LoadScene("GameOver");
        }
        if (Health == 1)
        {
            Heart2.gameObject.GetComponent<Image>().sprite = deadHeart;
            Heart3.gameObject.GetComponent<Image>().sprite = deadHeart;
        }
        if (Health == 2)
        {
            Heart3.gameObject.GetComponent<Image>().sprite = deadHeart;
        }
        

    }

    private void FixedUpdate()
    {
        Vector2 pos = transform.position;

        if (!isGrounded)
        {
            if (isHoldingJump)
            {
                holdJumpTimer += Time.fixedDeltaTime;
                if (holdJumpTimer >= maxHoldJumpTime)
                {
                    isHoldingJump = false;
                }
            }


            pos.y += velocity.y * Time.fixedDeltaTime;
            if (!isHoldingJump)
            {
                velocity.y += gravity * Time.fixedDeltaTime;
            }

            if (pos.y <= groundHeight)
            {
                pos.y = groundHeight;
                isGrounded = true;
            }
        }


        transform.position = pos;
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.CompareTag("EnnemyPro"))
        {
            Health -= 1;
        }
    }

}

