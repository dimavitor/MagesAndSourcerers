using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickToUseCharacter : MonoBehaviour
{

    Joystick joystick;
    Joybutton joybutton;

    BoxCollider2D _objectCollider;

    private GameObject[] players;

    private void Awake()
    {
        joystick = FindObjectOfType<Joystick>();
        joybutton = FindObjectOfType<Joybutton>();

        _objectCollider = GetComponent<BoxCollider2D>();
        _objectCollider.isTrigger = true;

        players = GameObject.FindGameObjectsWithTag("Player");
    }

    private void Start()
    {
        
    }

    private void OnMouseDown()
    {
       
        joystick.SetActive(true);
        joybutton.SetActive(true);

        foreach (GameObject go in players)
        {
            go.GetComponent<Movement>().enabled = false;
            go.GetComponent<BoxCollider2D>().isTrigger = true;
        }
        GetComponent<Movement>().enabled = true;
        _objectCollider.isTrigger = false;

    }
}
