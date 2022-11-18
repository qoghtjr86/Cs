using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class For_04 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int number = 0;
        for(int i = 0; i < 100; i++)
        {
            number = number + 1;
        }
        print(number);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
