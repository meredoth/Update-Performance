using UnityEngine;

namespace UpdatePerformance
{
public class WithUpdate : MonoBehaviour
{
   private bool _calculateWithGetComponent;
   private bool _calculateWithForLoop;
   private bool _calculateWithFindAnyObject;
   private bool _calculateWithFindFirstObject;
   private bool _calculateWithNullCheck;
   private int _noOfGetComponent;
   private int _noOfForLoops;
   private int _noOfFindAnyObjects;
   private int _noOfFindFirstObjects;
   private int _noOfNullChecks;

   private void Update()
   {
      if (_calculateWithNullCheck)
      {
         for (var j = 0; j < _noOfNullChecks; j++)
            if (gameObject != null) ;
      }
      if (_calculateWithFindAnyObject)
      {
         for (var j = 0; j < _noOfFindAnyObjects; j++)
            FindAnyObjectByType<WithUpdate>();
      }
      if (_calculateWithFindFirstObject)
      {
         for (var j = 0; j < _noOfFindFirstObjects; j++)
            FindFirstObjectByType<WithUpdate>();
      }
      if (_calculateWithGetComponent)
      {
         for (var j = 0; j < _noOfGetComponent; j++)
            GetComponent<WithUpdate>();
      }
      if (_calculateWithForLoop)
      {
         for (var j = 0; j < _noOfForLoops * 1000; j++) ;
      }
   }

   public void ToggleGetComponent() => _calculateWithGetComponent = !_calculateWithGetComponent;
   public void ToggleForLoop() => _calculateWithForLoop = !_calculateWithForLoop;
   public void ToggleFindAnyObject() => _calculateWithFindAnyObject = !_calculateWithFindAnyObject;
   public void ToggleFindFirstObject() => _calculateWithFindFirstObject = !_calculateWithFindFirstObject;

   public void ToggleNullCheck() => _calculateWithNullCheck = !_calculateWithNullCheck;
   public void SetGetComponentLoops(float amount) => _noOfGetComponent = (int)amount;
   public void SetForLoops(float amount) => _noOfForLoops = (int)amount;
   public void SetFindFirstObjectLoops(float amount) => _noOfFindFirstObjects = (int)amount;
   public void SetFindAnyObjectLoops(float amount) => _noOfFindAnyObjects = (int)amount;
   public void SetNullCheckLoops(float amount) => _noOfNullChecks = (int)amount;
}
}