using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class skill_up : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        gameObject.transform.Translate(Vector3.up * 5 * Time.deltaTime, Space.World);
    }
}
