using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Driver : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    [SerializeField] float steerSpeed = 100f;
    [SerializeField] float movementSpeed = 100f;

    public float getMovementSpeed() {
        return movementSpeed;
    }

    public void setMovementSpeed(float value) {
        movementSpeed = value;
    }

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float steerAmount = -Input.GetAxis("Horizontal") * steerSpeed * Time.deltaTime;
        float movementAmount = Input.GetAxis("Vertical") * movementSpeed * Time.deltaTime;
        transform.Rotate(0, 0, steerAmount);
        transform.Translate(0, movementAmount, 0);
    }
}
