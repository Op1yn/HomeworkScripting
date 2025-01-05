using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SphereForward : MonoBehaviour
{
    private float _speed = 1f;

    private void Update()
    {
        Vector3 nextPosition = transform.position;
        nextPosition.x += _speed * Time.deltaTime;
        transform.position = nextPosition;
    }
}
