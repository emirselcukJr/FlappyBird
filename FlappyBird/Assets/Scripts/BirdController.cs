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
}
