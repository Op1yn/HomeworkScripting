using UnityEngine;

public class SizeChanger : MonoBehaviour
{
    [SerializeField] private float _increaseSpeed = 0.1f;

    private void Update()
    {
        transform.localScale += Vector3.one * _increaseSpeed * Time.deltaTime;
    }
}
