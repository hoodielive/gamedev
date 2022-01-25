using UnityEngine;

public Collector : MonoBehaviour
{
  private string _ENEMY_TAG = "Enemy";
  private string _PLAYER_TAG = "Player";

  private void OnTriggerEnter2D(Collision col)
  {
    if (col.CompareTag(_ENEMY_TAG) || col.CompareTag(_PLAYER_TAG))
      Destroy(col.gameObject);
  }
}
