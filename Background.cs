using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Background : MonoBehaviour
{
    public Material Panorama;
    public float scrollSpeed = 0.2f;
    // Start is called before the first frame update
    void Start()
    {
        Panorama.mainTextureOffset = new Vector2(0, 0);
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 dir = Vector2.up;
        Panorama.mainTextureOffset += dir * scrollSpeed * Time.deltaTime;
    }
}
