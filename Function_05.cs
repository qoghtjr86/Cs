using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Function_05 : MonoBehaviour
{

    int Plus(int number1, int number2)
    {
        int result = number1 + number2;
        return result;
    }
    // Start is called before the first frame update
    void Start()
    {
        int sum = Plus(2, 10);
        print(sum);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
