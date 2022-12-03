using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    float minTime = 0.5f;
    float maxTime = 1.5f;
    float currentTime;
    float intervalTime;

    public GameObject enemyBody;
    public int capacity = 10;
    GameObject[] Cartridge;
    public Transform[] Publisher;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    void OnEnable()
    {
        intervalTime = UnityEngine.Random.Range(minTime, maxTime);

        Cartridge = new GameObject[capacity];
        for (int i = 0; i < capacity; i++)
        {
            GameObject enemy = Instantiate(enemyBody);
            Cartridge[i] = enemy;
            enemy.SetActive(false);
        }
    }

    // Update is called once per frame
    void Update()
    {
        currentTime += Time.deltaTime;

        if(currentTime > intervalTime)
        {
            for(int i = 0; i < capacity; i++)
            {
                GameObject Generator = Cartridge[i];
                if(Generator.activeSelf == false)
                {
                    int sector = UnityEngine.Random.Range(0, Publisher.Length - 1);
                    Generator.transform.position = Publisher[sector].position;
                    Generator.SetActive(true);
                    break;
                }
            }
            intervalTime = UnityEngine.Random.Range(minTime, maxTime);
            currentTime = 0;
        }
    }
}
