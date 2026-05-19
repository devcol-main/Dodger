using System;
using UnityEngine;

[RequireComponent( typeof( Rigidbody ))]
public class Bullet : MonoBehaviour
{
    [SerializeField] private float speed = 10f;
    private Rigidbody _rb;

    public float BulletSpeed { get => speed; set => speed = value; }

    private void Awake()
    {
        _rb = GetComponent<Rigidbody>();
    }
    
    // OnEnable
    private void Start()
    {
        Fire();
    }

    private void Fire()
    {
        _rb.linearVelocity = transform.forward * speed;
    }
    
    public void OnDestroy()
    {
        Debug.Log("Bullet Destroyed");
        Destroy(gameObject);
    }


    void OnTriggerEnter(Collider other)
    {
        
        //if (other.CompareTag("Player"))
        if (other.TryGetComponent(out Player player))
        {
            
        }
    }
}
