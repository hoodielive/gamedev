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
    _movementX = new Vector3();
  }


}
