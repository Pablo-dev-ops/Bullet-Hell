using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float moveSpeed;
    public GameObject bulletPrefab;
    public Transform shootingPoint;
    public float bulletSpeed;
    private Vector2 targetPosition; // Posición a la que se mueve el jugador

    void Update()
    {
       // Control táctil para el movimiento
        if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0); // Obtener el primer toque en la pantalla
            Vector2 touchPosition = Camera.main.ScreenToWorldPoint(touch.position); // Convertir la posición del toque a coordenadas del mundo

            // Actualizar la posición de destino (táctil)
            targetPosition = touchPosition;
        }

        // Movimiento del jugador hacia la posición del toque
        Vector2 currentPosition = Vector2.MoveTowards(transform.position, targetPosition, moveSpeed * Time.deltaTime);
        transform.position = currentPosition;

        // Control para disparar
        if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Began)
        {
            ShootBullet();
        }

        // // Disparo
        // if (Input.GetKeyDown(KeyCode.Space))
        // {
        //     ShootBullet();
        // }
    }

    void ShootBullet()
    {
        GameObject bullet = Instantiate(bulletPrefab, shootingPoint.position, Quaternion.identity);
        Rigidbody2D rb = bullet.GetComponent<Rigidbody2D>();
        rb.velocity = new Vector2(0, bulletSpeed);
    }
}
