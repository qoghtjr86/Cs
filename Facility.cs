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
    public Transform[] Cylinder;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    void OnEnable()
    {
        gap = UnityEngine.Random.Range(min, max);

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

        if(now > gap)
        {
            for(int i = 0; i < length; i++)
            {
                GameObject Facility = Sector[i];
                if(Facility.activeSelf == false)
                {
                    int capacity = Cylinder.Length - 1;
                    int section = UnityEngine.Random.Range(0, capacity);
                    Facility.transform.position = Cylinder[section].position;
                    Facility.SetActive(true);
                    break;
                }
            }
            gap = UnityEngine.Random.Range(min, max);
            now = 0;
        }
    }
}
