using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PipeSpawner : MonoBehaviour
{

    [SerializeField]
    BirdController bird;

    [SerializeField]
    GameObject pipe;

    [SerializeField]
    float time;

        
    



    void Start()
    {
        StartCoroutine(Spawner());

    }


    void Update()
    {

    }

    public IEnumerator Spawner()
    {

        while (!bird.isDead)
        {
            

            Instantiate(pipe, new Vector3(2, Random.Range(-0.4f, 0.7f), 0), Quaternion.identity);

            yield return new WaitForSeconds(time);
        }

    }
}
