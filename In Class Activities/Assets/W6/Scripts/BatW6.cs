using UnityEngine;

// Write the BatW6 class here.
public class BatW6 : MonoBehaviour
{
[SerializeField] private float _speed;
[SerializeField] private Transform _cat;

private bool _isChasing = false;

void Update()
{
    if (_isChasing)
    {
       transform.position= Vector3.MoveTowards
       (transform.position, _cat.position, _speed * Time.deltaTime);
    }
}

public void StopChasing()
{
    _isChasing = false;
}

public void StartChasing()
{
    _isChasing = true;
}
}


