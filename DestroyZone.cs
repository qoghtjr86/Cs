using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyZone : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name.Contains("BulletBody"))
        {
            other.gameObject.SetActive(false);
            PlayerGun player = GameObject.Find("Player").GetComponent<PlayerGun>();
            player.Magazine.Add(other.gameObject);
        }
        else if (other.gameObject.name.Contains("EnemyBody"))
        {
            other.gameObject.SetActive(false);
            Facility enemy = GameObject.Find("Facility").GetComponent<Facility>();
            enemy.Sector.Add(other.gameObject);
        }
        else
            Destroy(other.gameObject);
    }
}
