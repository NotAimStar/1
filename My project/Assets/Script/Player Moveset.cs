using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMoveset : MonoBehaviour
{

    public float speed = 1;


    public Rigidbody rigidbody;

    public Transform MiejsceStart;




    // Start is called before the first frame update
    void Start()
    {

        rigidbody = GetComponent<Rigidbody>();




    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetAxis("Horizontal") != 0)
        {

            float directionHorizontal = Input.GetAxis("Horizontal");
            rigidbody.AddForce(directionHorizontal * Time.deltaTime * speed, 0, 0, ForceMode.Impulse);

        }


        if (Input.GetAxis("Vertical") != 0)
        {

            float directionVertical = Input.GetAxis("Vertical");
            rigidbody.AddForce(0, 0, directionVertical * Time.deltaTime * speed, ForceMode.Force);

        }
    }
}        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        