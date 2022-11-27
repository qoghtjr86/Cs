using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerFire : MonoBehaviour
{
    public GameObject bullet;
    public GameObject Cylinder;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetButtonDown("Fire1"))
        {
            GameObject Gun = Instantiate(bullet);
            Gun.transform.position = Cylinder.transform.position;
        }
    }
}
