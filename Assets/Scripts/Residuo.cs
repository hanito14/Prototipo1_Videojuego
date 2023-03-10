using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

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
        if (other.CompareTag("contenedor_aluminio") && this.CompareTag("aluminio"))
        {
            datos.score += 1;
            Destroy(gameObject);
        }

        if (other.CompareTag("contendor_organico") && this.CompareTag("organico"))
        {
            datos.score += 1;
            Destroy(gameObject);
        }

        if (other.CompareTag("contenedor_pet") && this.CompareTag("pet"))
        {
            datos.score += 1;
            Destroy(gameObject);
        }

        if (other.CompareTag("contenedor_PapelCarton") && this.CompareTag("papel_carton"))
        {
            datos.score += 1;
            Destroy(gameObject);
        }

    }
}
