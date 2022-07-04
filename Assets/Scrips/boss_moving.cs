using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class boss_moving : MonoBehaviour
{
    // Start is called before the first frame update
    private Rigidbody2D rb;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        rb.MovePosition(rb.position + Vector2.right * 2 *Time.deltaTime);
    }
}
