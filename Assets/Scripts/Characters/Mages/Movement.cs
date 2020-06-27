using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{

    int moveSpeed = 20;
    float movementHorizontal;
    float movementVertical;

    public float speed;

    protected Joystick joystick;
    protected Joybutton joybutton;

    void Awake()
    {
        enabled = false;
        joystick = FindObjectOfType<Joystick>();
        joybutton = FindObjectOfType<Joybutton>();
    }

    private void Update()
    {
        movementHorizontal = Input.GetAxis("Horizontal");
        movementVertical = Input.GetAxis("Vertical");
        Move();
    }
    private void FixedUpdate()
    {
        GetComponent<Rigidbody2D>().velocity = new Vector2(movementHorizontal * moveSpeed * Time.deltaTime, movementVertical * moveSpeed * Time.deltaTime);
    }

    public void Move()
    {
        movementHorizontal = joystick.Horizontal * speed;
        movementVertical = joystick.Vertical * speed;
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.name == "Stair")
        {
            MainSceneController.LoadLevel(1);        }
    }

}
