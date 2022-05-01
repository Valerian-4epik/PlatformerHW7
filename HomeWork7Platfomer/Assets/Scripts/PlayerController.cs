using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private float _speed;
    [SerializeField] private float _jumpForce;
    [SerializeField] private Transform _groundChecker;
    [SerializeField] private float _radiusChecker;
    [SerializeField] private LayerMask _whatIsGround;
    private int _jumpsValue = 1;
    private float _moveInput;
    private Rigidbody2D _rigidbodyPlayer;
    private bool _isFacingRight = true;
    private bool _isGrounded;
    private int _jumpsCount;
    private int _flipValue = -1;



    private void Start()
    {
        _rigidbodyPlayer = GetComponent<Rigidbody2D>();
    }

    private void FixedUpdate()
    {
        _isGrounded = Physics2D.OverlapCircle(_groundChecker.position, _radiusChecker, _whatIsGround);
        _moveInput = Input.GetAxis("Horizontal");
        _rigidbodyPlayer.velocity = new Vector2(_moveInput * _speed, _rigidbodyPlayer.velocity.y);

        if (_isFacingRight == false && _moveInput > 0)
        {
            Flip();
        }
        else if (_isFacingRight == true && _moveInput < 0)
        {
            Flip();
        }
    }

    private void Update()
    {       
        if(_isGrounded == true)
        {
            _jumpsCount = _jumpsValue;
        }

        if(Input.GetKeyDown(KeyCode.Space) && _jumpsCount > 0)
        {
            _rigidbodyPlayer.velocity = Vector2.up * _jumpForce;
            _jumpsCount--;
        }
    }

    private void Flip()
    {
        _isFacingRight = !_isFacingRight;
        Vector3 Scaler = transform.localScale;
        Scaler.x *= _flipValue;
        transform.localScale = Scaler;
    }
}
