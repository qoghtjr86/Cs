using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerGun : MonoBehaviour
{
    public GameObject bulletBody;
    public GameObject Cylinder;
    public int capacity = 10;
    static GameObject[] Magazine;
    // Start is called before the first frame update
    void Start()
    {
        Magazine = new GameObject[capacity];
        for(int i = 0; i < capacity; i++)
        {
            GameObject bullet = Instantiate(bulletBody);
            bullet.SetActive(false);
            Magazine[i] = bullet;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetButtonDown("Fire1"))
        {
            for(int i = 0; i < capacity; i++)
            {
                GameObject Gun = Magazine[i];
                if(Gun.activeSelf == false)
                {
                    Gun.transform.position = Cylinder.transform.position;
                    Gun.SetActive(true);
                    break;
                }
            }
        }
    }
}
