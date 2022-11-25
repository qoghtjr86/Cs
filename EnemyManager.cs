using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyManager : MonoBehaviour
{
    float minTime = 1;
    float maxTime = 5;
    float currentTime;
    public float createTime;
    public GameObject enemy;
    
    // Start is called before the first frame update
    void Start()
    {
        createTime = UnityEngine.Random.Range(minTime, maxTime);
    }

    // Update is called once per frame
    void Update()
    {
        currentTime += Time.deltaTime;

        if(currentTime > createTime)
        {
            GameObject spawner = Instantiate(enemy);
            spawner.transform.position = transform.position;
            createTime = UnityEngine.Random.Range(minTime, maxTime);
            currentTime = 0;
        }
    }
}
