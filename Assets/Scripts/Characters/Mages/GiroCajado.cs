using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GiroCajado : MonoBehaviour
{
    protected Joystick joystick;
    protected Joybutton joybutton;

    Target target;

    void Awake()
    {
        joystick = FindObjectOfType<Joystick>();
        joybutton = FindObjectOfType<Joybutton>();

        target = GetComponentInParent<Target>();
    }

    void Update()
    {
        MovimentarArma();
    }

    public void MovimentarArma()
    {
        if (!target.mirando)
        {
            transform.up = joystick.Direction * 360;
        }
        else
        {
            transform.up = target.target;
        }
    }
}
