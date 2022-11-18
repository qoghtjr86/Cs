using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class If_03 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int number = 0;
        if(number <= 0)
        {
            print("값이 0보다 작습니다.");
        }
        else if(number >= 1 && number <= 5)
        {
            print("값은 1~5 사이입니다.");
        }
        else
        {
            print("값이 5보다 큽니다.");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
