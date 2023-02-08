using UnityEngine;

public class Residuo : MonoBehaviour
{

    GameManager datos;
   
    void Start()
    {
        datos = FindObjectOfType<GameManager>();
    }

    void Update()
    {
        Transform transform = GetComponent<Transform>();
        if (transform.position.y < -5.5 || transform.position.x > 3.5 || transform.position.x < -3.5)
        {
            Destroy(gameObject);
            datos.vidas -= 1;
        }

        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("contenedor1") && this.CompareTag("residuo"))
        {
            datos.score += 1;
            Destroy(gameObject);
        }

        if (other.CompareTag("contenedor2") && this.CompareTag("residuo2"))
        {
            datos.score += 1;
            Destroy(gameObject);
        }

        if (other.CompareTag("contenedor3") && this.CompareTag("residuo3"))
        {
            datos.score += 1;
            Destroy(gameObject);
        }

        if (other.CompareTag("contenedor4") && this.CompareTag("residuo4"))
        {
            datos.score += 1;
            Destroy(gameObject);
        }

    }
}
