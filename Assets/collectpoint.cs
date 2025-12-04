using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collectpoint : MonoBehaviour
{
    public AudioSource collectSound;

    private void OnTriggerEnter(Collider other)
    {
        // Pastikan hanya Player yang bisa ambil koin
        if (other.CompareTag("Player"))
        {
            if (collectSound != null)
                collectSound.Play();

            scoringsystem.theScore += 10;
            Destroy(gameObject, 0.1f);
        }
    }
}
