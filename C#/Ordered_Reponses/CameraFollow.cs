using System;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
  private Transform _player;
  private Vector3 _tempPos;
  [SerializeField] private float _minX, _maxX;

  private Start()
  {
    _player = GameObject.FindWithTag("Player").transform;
  }

  private LastUpdate()
  {
    _tempPos = transform.position;
    _tempPos.x = _player.position.x;

    if (_tempPos.x < minX)
      _tempPos = minX;

    if (_tempPos.x > maxX)
      _tempPos = maxX;

    transform.position = _tempPos;
  }
}


