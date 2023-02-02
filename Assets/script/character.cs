using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class character : MonoBehaviour
{
    public CharacterController controller;
    public Animator animaciones;
    public float speed = 6;
    public float turnSmoothTime = 0.1f;
    float turnSmoothVelocity;
    
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        float horizontal = Input.GetAxisRaw("Horizontal");
        float vertical = Input.GetAxisRaw("Vertical");

        Vector3 direction = new Vector3(horizontal, 0f, vertical).normalized;

        if(direction.magnitude >= 0.1f)
        {
            float targetAngle = Mathf.Atan2(direction.x, direction.z) * Mathf.Rad2Deg;
            float angle = Mathf.SmoothDampAngle(transform.eulerAngles.y, targetAngle, ref turnSmoothVelocity, turnSmoothTime);
            transform.rotation = Quaternion.Euler(0f, angle, 0f);
            controller.Move(direction * speed * Time.deltaTime);
            animaciones.SetBool("walk", true);
        }
        else
        {
            animaciones.SetBool("walk", false);
        }

        if (Input.GetKeyDown(KeyCode.E))
        {
            animaciones.SetBool("punch", true);
        }
        else if(Input.GetKeyUp(KeyCode.E))
        {
            animaciones.SetBool("punch", false);
        }

        if (Input.GetKeyDown(KeyCode.Q))
        {
            animaciones.SetBool("esquivar", true);
        }
        else if (Input.GetKeyUp(KeyCode.Q))
        {
            animaciones.SetBool("esquivar", false);
        }
        if (Input.GetKeyDown(KeyCode.C))
        {
            animaciones.SetBool("punchDos", true);
        }
        else if (Input.GetKeyUp(KeyCode.C))
        {
            animaciones.SetBool("punchDos", false);
        }
    }
    
}
