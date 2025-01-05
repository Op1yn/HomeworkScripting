using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCubeTwo : MonoBehaviour
{
    private float _speed = 1f;
    private float _increaseSpeed = 0.1f;
    private float _rotationSpeed = 0.01f;

    private void Update()
    {
        transform.Translate(Vector3.forward * _speed * Time.deltaTime);

        transform.rotation *= Quaternion.Euler(0, _rotationSpeed, 0);

        Vector3 nextScale = transform.localScale;
        nextScale.x += _increaseSpeed * Time.deltaTime;
        nextScale.y += _increaseSpeed * Time.deltaTime;
        nextScale.z += _increaseSpeed * Time.deltaTime;
        transform.localScale = nextScale;
    }
}
