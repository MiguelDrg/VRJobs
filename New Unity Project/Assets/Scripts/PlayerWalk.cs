using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerWalk : MonoBehaviour
{

    //public float playerSpeed;
    public float speed;
    //public float rotationSpeed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        /*float translation = Input.GetAxis("Vertical") * speed;
        translation *= Time.deltaTime;
        transform.Translate(0, 0, translation);*/

        if(Input.GetButton("z") || Input.GetButton("s")) 
        {
            //transform.position = transform.position + Camera.main.transform.forward * playerSpeed * Time.deltaTime;
            float translation = Input.GetAxis("Vertical") * speed;
            translation *= Time.deltaTime;
            transform.Translate(0, 0, translation);
        }

        if(Input.GetButton("q") || Input.GetButton("d"))
        {
            float translation = Input.GetAxis("Horizontal") * speed;
            translation *= Time.deltaTime;
            transform.Translate(0, 0, translation);
        }


        // Make it move 10 meters per second instead of 10 meters per frame...
        //rotation *= Time.deltaTime;

        // Rotate around our y-axis
        //transform.Rotate(0, rotation, 0);
    }
}
