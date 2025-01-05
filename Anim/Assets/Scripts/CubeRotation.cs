using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeRotation : MonoBehaviour
{
    [SerializeField] private float _rotationSpeed = 0.1f;

    private void Update()
    {
        transform.rotation *= Quaternion.Euler(0, _rotationSpeed, 0);
    }
}
