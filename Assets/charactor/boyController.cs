using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class boyController : MonoBehaviour
{
    public Vector3 target;
    float speed = 0.3f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 direction = target - transform.position;
        transform.Translate(direction*speed*Time.deltaTime,Space.World);
    }
}
