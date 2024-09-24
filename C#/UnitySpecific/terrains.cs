using UnityEngine;

public class MouseOverSwap : MonoBehaviour
{
  public Material mouseOverMaterial; 
  private Material _originalMaterial;
  private MeshRenderer _meshRenderer;

  void Start()
  {
    _meshRenderer = GetComponent<MeshRenderer>();
    _originalMaterial = _meshRenderer.sharedMaterial;
  }

  void OnMouseOver()
  {
    _meshRenderer.sharedMaterial = mouseOverMaterial;
  }

  void onMouseExit()
  {
    _meshRenderer.sharedMaterial = _originalMaterial;
  }
}
