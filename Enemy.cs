using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float speed = 5;
    Vector3 dir;
    public GameObject effect;
    // Start is called before the first frame update
    void Start()
    {

    }

    void OnEnable()
    {
        int randValue = UnityEngine.Random.Range(0, 10);

        if (randValue < 3)
        {
            GameObject target = GameObject.Find("Player");
            if (target)
            {
                dir = target.transform.position - transform.position;
                dir.Normalize();
            }
            else
            {
                dir = Vector3.down;
            }
        }
        else
        {
            dir = Vector3.down;
        }
    }

    // Update is called once per frame
    void Update()
    { 
        transform.position += dir * speed * Time.deltaTime;
    }

    private void OnCollisionEnter(Collision other)
    {
        ScoreManager.Instance.Score++;

        GameObject Event = Instantiate(effect);
        Event.transform.position = transform.position;

        if (other.gameObject.name.Contains("BulletBody"))
        {
            other.gameObject.SetActive(false);
            PlayerGun player = GameObject.Find("Player").GetComponent<PlayerGun>();
            player.Magazine.Add(other.gameObject);
            gameObject.SetActive(false);
            Facility enemy = GameObject.Find("Facility").GetComponent<Facility>();
            enemy.Sector.Add(gameObject);
        }
        else
        {
            Destroy(other.gameObject);
            gameObject.SetActive(false);
            Facility enemy = GameObject.Find("Facility").GetComponent<Facility>();
            enemy.Sector.Add(gameObject);
        }

        
    }
}
