using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bom_roi : MonoBehaviour
{
    [SerializeField]
    private GameObject bullet;
    public Transform lauchc;
    public int A, B;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(Attack());
    }

    // Update is called once per frame
    void Update()
    {

    }

    IEnumerator Attack()
    {
        yield return new WaitForSeconds(Random.Range(A, B));
        Instantiate(bullet, lauchc.position, Quaternion.identity);
        StartCoroutine(Attack());
    }
}

