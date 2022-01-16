using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SubwayController : MonoBehaviour
{
    public float speed = 20f;
    private float rightBoundary = -10.0f;
    private float leftBoundary = 5.0f;
    public bool gameover=false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.D))
        {
            if (transform.position.z > rightBoundary)
            {          
                transform.Translate(Vector3.right * speed * Time.deltaTime);
            }
            
        }
        else if (Input.GetKey(KeyCode.A))
        {
            if(transform.position.z < leftBoundary)
            {
                transform.Translate(Vector3.left * speed * Time.deltaTime);

            }
        

        }
    }
    private void OnTriggerEnter(Collider other)
    {
        
        gameover = true;
    }
}
