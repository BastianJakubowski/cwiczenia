using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    [SerializeField] float vectorX;
    [SerializeField] float vectorY = 0;
    [SerializeField] float vectorZ; 
    [SerializeField] float speed = 5;

    // 
    void Start()
    {
    
    }

    // Update is called once per frame
    void Update()
    {
        vectorX = Input.GetAxis("Horizontal");
        vectorZ = Input.GetAxis("Vertical");
        transform.Translate(vectorX  * Time.deltaTime * speed, vectorY, vectorZ * Time.deltaTime * speed);  
    }
}
