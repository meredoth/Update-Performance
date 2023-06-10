using UnityEngine;

namespace UpdatePerformance
{
[CreateAssetMenu(fileName = "SceneValues")]
public class SceneValues : ScriptableObject
{
   public bool calculateWithGetComponent;
   public bool calculateWithForLoop;
   public bool calculateWithFindObject;
   public bool calculateWithNullCheck;
   public float numberOfGetComponents;
   public float numberOfForLoops;
   public float numberOfFindObject;
   public float numberOfUpdates;
   public float numberOfNullChecks;
}
}