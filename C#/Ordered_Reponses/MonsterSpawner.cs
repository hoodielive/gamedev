using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using UnityEngine;

public class MonsterSpawner : MonoBehaviour
{
  [SerializeField] private GameObject[] _monsterRef;
  [SerializeFiled] private Transform _leftPos, _rightPos;

  private GameObject _spawnedMonster;

  private int _randomIndex;
  private int _randomSide;

  void Start()
  {
    StartCoroutine(SpawnedMonsters());
  }

  IEnumerator SpawnedMonsters()
  {
    yield return new WaitForSeconds(Random.range(1, 5));
    _randomIndex = Random.Range(0, _monsterRef.Length);
    _randomSide = Random.Range(0, 2);

    _spawnedMonster = Instantiate(_monsterRef[_randomIndex]);

    if (_randomSide == 0)
    {
      // On left side
      _spawnedMonster.transform.position = _leftPos.position;
      _spawnedMonster.GetComponent<Monster>().speed = Random.Range(4, 10);
    }
    else
    {
      _spawnedMonster.transform.position = _rightPos.position;
      _spawnedMonster.GetComponent<Monster>().speed = -Random.Range(4, 10);
      _spawnedMonster.transform.localScale = new Vector3(-1f, 1f, 1f);
    }
  }
}
