using UnityEngine;
using UnityEngine.InputSystem;

[RequireComponent( typeof( Rigidbody ))]
public class PlayerController : MonoBehaviour
{
    private Rigidbody _rb;
    private Vector2 _moveInput;
    
    [SerializeField] private float speed = 8f;

    private void Awake()
    {
        _rb = GetComponent<Rigidbody>();
    }
    
    

    #region  Inputs

    public void OnMove(InputValue value)
    {
        // Just store the value when it changes
        _moveInput = value.Get<Vector2>();
    }

    public void OnJump()
    {
        Debug.Log("Jump");
    }
    
    #endregion
    
    private void FixedUpdate()
    {
        // control movements
        _rb.linearVelocity = new Vector3(
            _moveInput.x * speed, _rb.linearVelocity.y, _moveInput.y * speed);
        
    }
}
