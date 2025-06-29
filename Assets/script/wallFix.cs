using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class wallFix : MonoBehaviour
{
    public GameObject[] cubes;
    public GameObject[] sideCubes;
    void Start()
    {
        if(gameObject.tag == "type2")
        {
            foreach(GameObject cube in cubes)
            {
                cube.SetActive(false);
            }
            Vector3 scale = gameObject.transform.localScale;
            scale.x -= 0.2f;
            gameObject.transform.localScale = scale;
        }
        else
        {
            Vector3 scale = gameObject.transform.localScale;
            scale.x -= 0.2f;
            gameObject.transform.localScale = scale;


            foreach (GameObject cube in cubes)
            {
                cube.SetActive(true);
                
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
