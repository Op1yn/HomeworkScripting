using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CapsuleIncrease : MonoBehaviour
{
    [SerializeField] private float _increaseSpeed = 0.1f;

    void Update()
    {
        Vector3 nextScale = transform.localScale;
        nextScale.x += _increaseSpeed * Time.deltaTime;
        nextScale.y += _increaseSpeed * Time.deltaTime;
        nextScale.z += _increaseSpeed * Time.deltaTime;
        transform.localScale = nextScale;
    }
}
