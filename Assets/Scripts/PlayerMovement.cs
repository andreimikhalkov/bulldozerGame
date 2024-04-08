using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField]
    private float _rotationSpeed;
    [SerializeField]
    private float currentSpeed;
    public Rigidbody rb;
    private float horInput;
    private float verInput;
    public float maxSpeed = 10f;
    public float acceleration = 2f;
    public float deceleration = 2f;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        horInput = Input.GetAxis("Horizontal");
        verInput = Input.GetAxis("Vertical");
        
        rb.AddRelativeForce(Vector3.forward * verInput * currentSpeed, ForceMode.Force);
        
        transform.Rotate(Vector3.up * _rotationSpeed * Time.deltaTime * horInput);
    }

    void ManageSpeed()
    {
        // Ускоряем бульдозер
        if (horInput > 0)
        {
            currentSpeed = Mathf.MoveTowards(currentSpeed, maxSpeed, acceleration * Time.deltaTime);
        }
        // Замедляем бульдозер
        else if (horInput < 0)
        {
            currentSpeed = Mathf.MoveTowards(currentSpeed, -maxSpeed / 2, deceleration * Time.deltaTime);
        }
        // Если нет ввода, замедляем до полной остановки
        else
        {
            currentSpeed = Mathf.MoveTowards(currentSpeed, 0f, deceleration * Time.deltaTime);
        }
    }
}
