using Unity.Entities;
using Unity.NetCode;
using UnityEngine;

[GenerateAuthoringComponent]

public struct MoveableCubeComponet : IComponentData
{
    [GhostDefaultField] 
    public int PlayerID;
}
