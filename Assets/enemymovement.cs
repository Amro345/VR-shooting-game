using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemymovement : MonoBehaviour
{
    public Transform player;
    public float movementSpeed = 3f;

    void Update()
    {
        Vector3 direction = player.position - transform.position;
        direction.Normalize();
        transform.Translate(direction * movementSpeed * Time.deltaTime);
    }
}
