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
    public List<GameObject> Sector;
    public Transform[] TimeCapsule;
    
    // Start is called before the first frame update
    void Start()
    {
        gap = Random.Range(min, max);

        Sector = new List<GameObject>();
        for (int i = 0; i < length; i++)
        {
            GameObject enemy = Instantiate(enemyBody);
            enemy.SetActive(false);
            Sector.Add(enemy);
        }
    }

    // Update is called once per frame
    void Update()
    {
        now += Time.deltaTime;

        if (now > gap)
        {
            GameObject enemy = Sector[0];
            Sector.Remove(enemy);

            int capacity = TimeCapsule.Length - 1;
            int section = Random.Range(0, capacity);
            enemy.transform.position = TimeCapsule[section].position;

            enemy.SetActive(true);
        
            gap = Random.Range(min, max);
            now = 0;
        }
    }
}
