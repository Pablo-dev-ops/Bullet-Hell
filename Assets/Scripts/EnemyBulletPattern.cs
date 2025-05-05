using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBulletPattern : MonoBehaviour
{
    public GameObject bulletPrefab;
    public Transform shootingPoint;
    public float shootInterval = 0.5f;
    private float timeSinceLastShot = 0f;

    void Update()
    {
        timeSinceLastShot += Time.deltaTime;
        if (timeSinceLastShot >= shootInterval)
        {
            ShootMultipleBullets();
            timeSinceLastShot = 0f;
        }
    }

    void ShootMultipleBullets()
    {
        // Disparar 3 balas en direcciones diferentes
        InstantiateBullet(Vector2.up);    // Arriba
        InstantiateBullet(Vector2.right); // Derecha
        InstantiateBullet(Vector2.left);  // Izquierda
    }

    void InstantiateBullet(Vector2 direction)
    {
        GameObject bullet = Instantiate(bulletPrefab, shootingPoint.position, Quaternion.identity);
        Rigidbody2D rb = bullet.GetComponent<Rigidbody2D>();
        rb.velocity = direction * 5f;  // Velocidad de la bala
    }
}
