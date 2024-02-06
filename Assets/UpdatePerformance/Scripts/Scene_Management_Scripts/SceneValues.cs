using UnityEngine;

namespace UpdatePerformance
{
[CreateAssetMenu(fileName = "SceneValues")]
public class SceneValues : ScriptableObject
{
   public bool calculateWithGetComponent;
   public bool calculateWithForLoop;
   public bool calculateWithFindAnyObject;
   public bool calculateWithFindFirstObject;
   public bool calculateWithNullCheck;
   public float numberOfGetComponents;
   public float numberOfForLoops;
   public float numberOfFindAnyObject;
   public float numberOfFindFirstObject;
   public float numberOfUpdates;
   public float numberOfNullChecks;
}
}