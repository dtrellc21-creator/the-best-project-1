using UnityEngine;

public class collision : MonoBehaviour
{
   void OnCollisionEnter2D(Collision2D collision)
   {
        Debug.Log("Why are youcolliding with my gril");
   }


   void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("why are you in my gril");
    }
}
