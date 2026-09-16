using UnityEngine;
using UnityEngine.InputSystem;

public class Driver : MonoBehaviour
{
    [SerializeField] float startspeed = 2f;
    [SerializeField] float movespeed = .1f;

    void Update()
    {
        float steer = 0f;
        float move = 0f;


        if (Keyboard.current.wKey.isPressed)
        {
            move = 1f;
        }

        else if (Keyboard.current.sKey.isPressed)
        {
            move = -1f;
        }

        if (Keyboard.current.aKey.isPressed)
        {
            steer = -1f;
        }

        else if (Keyboard.current.dKey.isPressed)
        {
            steer = 1f;
        }

        transform.Rotate(0, 0, steer * startspeed);
        transform.Translate(0, move * movespeed, 0);
    }
}



