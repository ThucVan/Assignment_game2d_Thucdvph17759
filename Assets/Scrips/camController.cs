using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camController : MonoBehaviour
{
    private Transform player;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("john_idle_0").transform;

    }
    
    // Update is called once per frame
    void Update()
    {
        Vector3 cam = transform.position;
        cam.x = player.position.x;
        transform.position = cam;
    }
}
