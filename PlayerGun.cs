using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerGun : MonoBehaviour
{
    public GameObject bulletBody;
    public int capacity = 20;
    public List<GameObject> Magazine;
    // Start is called before the first frame update
    void Start()
    {
        Magazine = new List<GameObject>();
        for(int i = 0; i < capacity; i++)
        {
            GameObject bullet = Instantiate(bulletBody);
            bullet.SetActive(false);
            Magazine.Add(bullet);
        }
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetButtonDown("Fire1"))
        {
            GameObject bullet = Magazine[0];
            bullet.SetActive(true);
            Magazine.Remove(bullet);
            bullet.transform.position = transform.position;            
        }
    }
}
