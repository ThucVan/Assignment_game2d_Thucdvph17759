using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class boss_controller : MonoBehaviour
{
    public GameObject skill;
    public GameObject skill_left;
    Animator animatior;
    SpriteRenderer spriteRenderer, renderer_skill;
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
        if (spriteRenderer.flipX == false)
        {
            Vector3 vector_right = transform.position;
            vector_right.x = vector_right.x + 1;
            
            Instantiate(skill, vector_right, Quaternion.identity);
            renderer_skill.flipX = false;
        }
        else if (spriteRenderer.flipX == true)
        {
            Vector3 vector = transform.position;
            vector.x = vector.x - 1;
            
            Instantiate(skill_left, vector, Quaternion.identity);
            renderer_skill.flipX = true;
        }
    }
}
