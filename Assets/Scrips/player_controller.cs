using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player_controller : MonoBehaviour
{
    public GameObject skill, broken_skill;
    public GameObject skill_left, skill_up, boom;
    Animator animatior;
    SpriteRenderer spriteRenderer, renderer_skill;
    int speed_up = 8;
    bool on = false;
    int i;
    // Start is called before the first frame update
    void Start()
    {
        animatior = gameObject.GetComponent<Animator>();
        spriteRenderer = gameObject.GetComponent<SpriteRenderer>();
        renderer_skill = skill.GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.A))
        {
            spriteRenderer.flipX = true;
            animatior.SetInteger("status", 1);
            transform.Translate(Vector3.left * 5 * Time.deltaTime, Space.World);
        }else if (Input.GetKey(KeyCode.D))
        {
            spriteRenderer.flipX = false;
            animatior.SetInteger("status", 1);
            transform.Translate(Vector3.right * 5 * Time.deltaTime, Space.World);
        }else if (Input.GetKey(KeyCode.Space))
        {          
            animatior.SetInteger("status", 2);
            transform.Translate(Vector3.up * speed_up * Time.deltaTime, Space.World);
            if (Input.GetKeyDown(KeyCode.Space))
            {
                i = i + 1;
                if(i == 5)
                {
                    Destroy(gameObject);
                    Vector3 vector = transform.position;
                    Instantiate(broken_skill, vector, Quaternion.identity);
                }
                Debug.Log(i);
            }
            
        }else if (Input.GetKeyDown(KeyCode.Z))
        {
            animatior.SetInteger("status", 4);
        }
        else if (Input.GetKeyDown(KeyCode.F))
        {
            if(spriteRenderer.flipX == false)
            {
                Vector3 vector_right = transform.position;
                vector_right.x = vector_right.x + 1;
                animatior.SetInteger("status", 3);
                Instantiate(skill, vector_right, Quaternion.identity);
                renderer_skill.flipX = false;
            }else if (spriteRenderer.flipX == true)
            {
                Vector3 vector = transform.position;
                vector.x = vector.x -1;
                animatior.SetInteger("status", 3);
                Instantiate(skill_left, vector, Quaternion.identity);
                renderer_skill.flipX = true;
            }
        }

        if (Input.GetKeyDown(KeyCode.B))
        {
            for (int i = 0; i < 30; i++)
            {
                Instantiate(boom, new Vector3(Random.Range(3, 28), 10, 0), Quaternion.identity);
            }
        }
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        string name = collision.gameObject.name;
        if (name == "grunt_crouch moving")
        {
            Destroy(gameObject);
            Destroy(collision.gameObject);
            Vector3 vector = transform.position;
            Instantiate(broken_skill, vector, Quaternion.identity);
        }
    }
}


