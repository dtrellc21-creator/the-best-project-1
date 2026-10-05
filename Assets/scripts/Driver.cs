using TMPro;
using UnityEngine;
using UnityEngine.InputSystem;

public class Driver : MonoBehaviour
{
    [SerializeField] float steerspeed = 0.2f;
    [SerializeField] float CurrentSpeed = 0.1f;
    [SerializeField] float BoostSpeed = 0.4f;
    [SerializeField] float RegularSpeed = 0.1f;


    [SerializeField] TMP_Text BoostText;


    void Start()
    {
        BoostText.gameObject.SetActive(false);
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Boost"))
        {
            CurrentSpeed = BoostSpeed;
            Debug.Log("Boost Activated");
            Destroy(collision.gameObject);
            BoostText.gameObject.SetActive(true);
            BoostText.text = "Boost Activated!";
        }
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        CurrentSpeed = RegularSpeed;
        Debug.Log("Boost Deactivated");
        BoostText.gameObject.SetActive(false);
    }


    void Update()
    {
        float steer = 0f;
        float move = 0f;


        if (Keyboard.current.sKey.isPressed)
        {
            move = 1f;
        }

        else if (Keyboard.current.wKey.isPressed)
        {
            move = -1f;
        }

        if (Keyboard.current.dKey.isPressed)
        {
            steer = -1f;
        }

        else if (Keyboard.current.aKey.isPressed)
        {
            steer = 1f;
        }

        float MoveAmount = move * CurrentSpeed * Time.deltaTime;
        float SteerAmount = steer * steerspeed * Time.deltaTime;

        transform.Rotate(0, 0, steer * steerspeed);
        transform.Translate(0, move * CurrentSpeed, 0);
    }
}



