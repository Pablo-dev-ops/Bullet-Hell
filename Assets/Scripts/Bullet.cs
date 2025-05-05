using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
   public float lifeTime = 2f;

    void Start()
    {
        Destroy(gameObject, lifeTime);  // Destruye la bala después de un tiempo
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Enemy"))
        {
            // Aquí puedes manejar la colisión con los enemigos
            Destroy(other.gameObject); // Destruye el enemigo
            Destroy(gameObject);       // Destruye la bala
        }
    }
}
