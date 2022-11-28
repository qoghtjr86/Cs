using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cylinder : MonoBehaviour
{
    float minTime = 1;
    float maxTime = 5;
    float currentTime;
    float intervalTime;
    public GameObject enemy;
    
    // Start is called before the first frame update
    void Start()
    {
        intervalTime = UnityEngine.Random.Range(minTime, maxTime);
    }

    // Update is called once per frame
    void Update()
    {
        currentTime += Time.deltaTime;

        if(currentTime > intervalTime)
        {
            GameObject Cylinder = Instantiate(enemy);
            Cylinder.transform.position = transform.position;
            intervalTime = UnityEngine.Random.Range(minTime, maxTime);
            currentTime = 0;
        }
    }
}
