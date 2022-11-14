using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movementReaper : MonoBehaviour
{
    public Transform top;
    public Transform bottom;

    public float speed = 5.00f;
    private float leftEdge;

    private void Start()
    {
        leftEdge = Camera.main.ScreenToWorldPoint(Vector3.zero).x - 1f;
    }

    private void Update()
    {
        transform.position += Vector3.left * speed * Time.deltaTime;

        if (transform.position.x < leftEdge || Time.timeScale == 0f) {
            Destroy(gameObject);
        }
        speed+=.01f;
    }
}
