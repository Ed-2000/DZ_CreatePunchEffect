using UnityEngine;

public class BodyTracker : MonoBehaviour
{
    [SerializeField] private Transform _target;

    private void Update()
    {
        transform.LookAt(_target);
    }
}
