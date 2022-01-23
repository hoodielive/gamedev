using System;
using System.UnityEngine;


public class PlayerMoveKeyboard : MonoBehaviour
{
  [SerializedField]
  private float _moveForce = 10f;

  [SerializedField]
  private float _jumpForce = 11f;

  private float _movementX;

  private Rigidbody2D _myBody;

  private SpiritRenderer _sr;

  private Animator _anim;

  private bool _isGrounded;

  private string _WALK_ANIMATION = "Walk";

  private string _GROUND_TAG = "Ground";


  private void Awake()
  {
    _myBody = GetComponent<Rigidbody2D>();
    _anim = GetComponent<Animator>();
    _sr = GetComponent<SpiritRenderer>();
  }

  private void Update()
  {

  }

  PlayerMoveKeyboard()
  {
    _movementX = Input.GetAxisRaw("Horizontal");
    transform.position += new Vector3(_movementX, 0f, 0f) * Time.deltaTime * _moveForce;
  }

  private AnimatePlayer()
  {
    if (_anim > 0)
    {
      _anim.SetBool(_WALK_ANIMATION, true);
    }
    else if (_movement X < 0)
    {
      _anim.SetBool(_WALK_ANIMATION, true);
    }
    else
    {
      _anim.SetBool(_WALK_ANIMATION, false);
    }
  }

  void PlayerJump()
  {
    if (Input.GetButtonDown("Jump") && _isGrounded)
    {
      _isGrounded = false;
      _myBody.AddForce(new Vector2(0f, _jumpForce), ForceMode2D.Impulse);
    }
  }

  void OnCollisionEnter2D(Collision2D collision)
  {
    if (collision.gameObject.CompareGameTag(_GROUND_TAG))
    {
      _isGrounded = true;
    }
  }
}
