using UnityEngine;
using UnityEngine.InputSystem;

public class Driver : MonoBehaviour
{
    [SerializeField] float startspeed = 2f;
    [SerializeField] float movespeed = .1f;
    
    void Update()
    {
        if (Keyboard.current.wKey.isPressed)
        {
          Debug.Log("We are up");
        }
        
        else if (Keyboard.current.sKey.isPressed)
        {
          Debug.Log("We are down");
        }
        
        if (Keyboard.current.aKey.isPressed)
        {
          Debug.Log("We are left ");
        }
        
        else if (Keyboard.current.dKey.isPressed)
        {
          Debug.Log("We are right");
        }
       
        transform.Rotate(0, 0, startspeed);
        transform.Translate(0, movespeed, 0);
    }
}



