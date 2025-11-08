using System;
using System.Collections;
using UnityEngine;

public class Kule : MonoBehaviour
{
    // Vector2(x, y) Vector3(x, y, z)
    private Vector3 currentPosition;
    public GameObject target;
    private Vector3 targetPosition;
    public float delay;
    private float speed = 5f;

    private void Start()
    {
        StartCoroutine(UpdateTransform());
    }

    private void FixedUpdate()
    {
        targetPosition = target.transform.position;
        transform.position = Vector3.Lerp(currentPosition, targetPosition, Time.deltaTime * speed);
        transform.up = (targetPosition - currentPosition).normalized;
    }

    private IEnumerator UpdateTransform()
    {
        while (true)
        {
            currentPosition = transform.position;
            Debug.Log("Kule Pozisyonu: " + currentPosition);
            yield return new WaitForSeconds(delay); // Her 1 saniyede bir pozisyonu yazdır
        }
    }
}
