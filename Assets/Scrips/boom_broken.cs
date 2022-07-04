using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class boom_broken : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject broken_skill;
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        string name = collision.gameObject.name;
        if (name == "groundStraight")
        {
            Destroy(gameObject);
            Vector3 vector = transform.position;
            Instantiate(broken_skill, vector, Quaternion.identity);
        }
        else if (name == "crate")
        {
            Destroy(gameObject);
            Vector3 vector = transform.position;
            Instantiate(broken_skill, vector, Quaternion.identity);
        }
        else if (name == "bigcrate")
        {
            Destroy(gameObject);
            Vector3 vector = transform.position;
            Instantiate(broken_skill, vector, Quaternion.identity);
        }
        else if (name == "caveEntrance")
        {
            Destroy(gameObject);
            Vector3 vector = transform.position;
            Instantiate(broken_skill, vector, Quaternion.identity);
        }
        else if (name == "shelter")
        {
            Destroy(gameObject);
            Vector3 vector = transform.position;
            Instantiate(broken_skill, vector, Quaternion.identity);
        }
        else if (name == "barrel")
        {
            Destroy(gameObject);
            Vector3 vector = transform.position;
            Instantiate(broken_skill, vector, Quaternion.identity);
        }
    }
}
