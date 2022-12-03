using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Facility : MonoBehaviour
{
    float min = 0.5f;
    float max = 1.5f;
    float now;
    float gap;

    public GameObject enemyBody;
    public int length = 10;
    GameObject[] Sector;
    public Transform[] Topology;
    
    // Start is called before the first frame update
    void Start()
    {
        gap = Random.Range(min, max);

        Sector = new GameObject[length];
        for (int i = 0; i < length; i++)
        {
            GameObject enemy = Instantiate(enemyBody);
            Sector[i] = enemy;
            Sector[i].SetActive(false);
        }
    }

    // Update is called once per frame
    void Update()
    {
        now += Time.deltaTime;
        
        if (now > gap)
        {
            for (int i = 0; i < length; i++)
            {
                GameObject Facility = Sector[i];
                if(Facility.activeSelf == false)
                {
                    int capacity = Topology.Length - 1;
                    int section = Random.Range(0, capacity);
                    Facility.transform.position = Topology[section].position;
                    Facility.SetActive(true);
                    break;
                }
            }
            gap = Random.Range(min, max);
            now = 0;
        }
    }
}
