using UnityEngine;

public class CollisionHandler : MonoBehaviour
{
    [SerializeField] private ParticleSystem _particleSystem;

    private void OnCollisionEnter(Collision collision)
    {
        _particleSystem.Play();
    }
}
