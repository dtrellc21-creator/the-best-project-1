using UnityEngine;

public class Delivery : MonoBehaviour
{
    bool hasPackage;

    [SerializeField] float delay = 1f;


    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Package") && !hasPackage)
        {
            Debug.Log(hasPackage);
            Debug.Log("Package has been grabbed.");
            hasPackage = true;
            GetComponent<ParticleSystem>().Play();
            Destroy(collision.gameObject, delay);
        }



        if (collision.CompareTag("Custy") && hasPackage)
        {
            Debug.Log("Custy has grabbed the package.");
            hasPackage = false;
            GetComponent<ParticleSystem>().Stop();
        }

    }
}