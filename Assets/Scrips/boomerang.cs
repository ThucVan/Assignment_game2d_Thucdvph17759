using UnityEngine;

public class boomerang : MonoBehaviour
{
    public float speed = 10;
    bool returning = false;
    private Transform playertrans;
    float boomerangTimer;
    void OnEnable()
    {
        playertrans = GameObject.Find("john_idle_0").transform;
        boomerangTimer = 0.0f;
    }
    // Update is called once per frame
    void Update()
    {
        if (playertrans != null)
        {
            boomerangTimer += Time.deltaTime;

            if (boomerangTimer >= 1f)
            {
                returning = true;
            }

            if (!returning)
            {

                transform.Translate(Vector2.right * speed * Time.deltaTime);
            }
            else
            {
                transform.right = playertrans.position - transform.position;
                transform.Translate(Vector2.right * speed * Time.deltaTime);
            }
        }
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "john_idle_0")
        {
            speed = 0;
        }
        if (other.tag == "Enemy")
        {
            returning = true;
        }
    }
}