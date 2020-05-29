using UnityEngine;

public class DNA : MonoBehaviour
{
    // Gene for color.
    public float r;
    public float g;
    public float b;
    bool dead = false;
    public float timeToDie = 0f;
    private SpriteRenderer _sRenderer;
    private Collider2D _sCollider;

    private void OnMouseDown()
    {
        dead = true;
        timeToDie = PopulationManager.elapsed;
        Debug.Log("Dead At: " + timeToDie);
        _sRenderer.enabled = false;
        _sCollider.enabled = false;
    }

    void Start()
    {
        _sRenderer = GetComponent<SpriteRenderer>();
        _sCollider = GetComponent<Collider2D>();
    }

    void Update()
    {
        
    }
}
