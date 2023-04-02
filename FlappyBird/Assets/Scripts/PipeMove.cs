using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeMove : MonoBehaviour
{

    [SerializeField]
    float speed;

    void Start()
    {
        Destroy(gameObject , 7f);
    }

    void FixedUpdate()
    {
        transform.position += Vector3.left * speed * Time.deltaTime;
        
    }

   
}
