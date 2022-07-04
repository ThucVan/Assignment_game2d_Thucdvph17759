using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class skill_left : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject broken_skill;
    void Start()
    {
        Destroy(gameObject, 1);
    }

    // Update is called once per frame
    void Update()
    {
         gameObject.transform.Translate(Vector3.left * 5 * Time.deltaTime, Space.World);
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        string name_nv = collision.gameObject.name;
        Destroy(gameObject);
        Destroy(collision.gameObject);
        Vector3 vector = transform.position;
        Instantiate(broken_skill, vector, Quaternion.identity);
    }
    void OnCollisionStay2D(Collision2D collision)
    {

    }
    void OnCollisionExit2D(Collision2D collision)
    {

    }
}
