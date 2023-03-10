using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SonidosBote : MonoBehaviour
{
    public AudioSource sonidoBotes;
    public AudioClip sonido;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("aluminio") && this.CompareTag("contenedor_aluminio"))
        {
            sonidoBotes.PlayOneShot(sonido, 1f);
        }

        if (other.CompareTag("organico") && this.CompareTag("contendor_organico"))
        {
            sonidoBotes.PlayOneShot(sonido, 1f);
        }

        if (other.CompareTag("pet") && this.CompareTag("contenedor_pet"))
        {
            sonidoBotes.PlayOneShot(sonido, 1f);
        }

        if (other.CompareTag("papel_carton") && this.CompareTag("contenedor_PapelCarton"))
        {
            sonidoBotes.PlayOneShot(sonido, 1f);
        }

    }
}
