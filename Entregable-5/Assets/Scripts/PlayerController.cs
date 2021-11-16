using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Vector3 initialPos = Vector3.zero;
    public float speed = 30f;
    public float turnSpeed = 30f;
    public float verticalInput;
    private float zMax = 450f;

   
    void Start()
    {
        transform.position = initialPos;
    }

   
    void Update()
    {
        transform.Translate(Vector3.forward * Time.deltaTime * speed); //velocidad constante de player


        verticalInput = Input.GetAxis("Vertical");
        transform.Rotate(Vector3.right * Time.deltaTime * turnSpeed * verticalInput); //Movimiento del player

        if (transform.position.z >= zMax) 
        {
            Debug.Log("THE END");
            Time.timeScale = 0; //Congelar el juego
        }


    }
}
