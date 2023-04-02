using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdController : MonoBehaviour
{

    [SerializeField]
    float zýplamaGucu;

    [SerializeField]
    Rigidbody2D rb;


    public bool isDead;

    public GameManager gameManager;

    public GameObject DeadScreen;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }


    void Update()
    {

        if (Input.GetMouseButtonDown(0))
        {
            rb.velocity = Vector2.up * zýplamaGucu;
        }



    }

    private void OnTriggerEnter2D(Collider2D temas)
    {
        if (temas.gameObject.name == "SkorKutu")
        {
            gameManager.SkorUpdate();
        }
    }

    private void OnCollisionEnter2D(Collision2D enemy)
    {
        if (enemy.gameObject.tag == "enemy")
        {
            isDead = true;
            Time.timeScale = 0;

            DeadScreen.SetActive(true);

            
        }
    }
}
