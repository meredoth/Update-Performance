using UnityEngine;

namespace UpdatePerformance
{
public class WithMyUpdate : MonoBehaviour, IMyUpdate
{
    [SerializeField] private UpdateManager updateManager;
    
    private bool _calculateWithGetComponent;
    private bool _calculateWithForLoop;
    private bool _calculateWithFindObject;
    private bool _calculateWithNullCheck;
    private int _noOfGetComponent;
    private int _noOfForLoops;
    private int _noOfFindObjects;
    private int _noOfNullChecks;

    private void OnEnable() => updateManager.AddUpdatable(this);

    void IMyUpdate.MyUpdate()
    {
        if (_calculateWithNullCheck)
        {
            for (var j = 0; j < _noOfNullChecks; j++)
                if (gameObject != null) ;
        }
        if (_calculateWithFindObject)
        {
            for (var j = 0; j < _noOfFindObjects; j++)
                FindObjectOfType<WithMyUpdate>();
        }
        if (_calculateWithGetComponent)
        {
            for (var j = 0; j < _noOfGetComponent; j++)
                GetComponent<WithMyUpdate>();
        }
        if(_calculateWithForLoop)
        {
            for (var j = 0; j < _noOfForLoops * 1000; j++) ;
        }
    }

    public void ToggleGetComponent() => _calculateWithGetComponent = !_calculateWithGetComponent;
    public void ToggleForLoop() => _calculateWithForLoop = !_calculateWithForLoop;
    public void ToggleFindObject() => _calculateWithFindObject = !_calculateWithFindObject;
    public void ToggleNullCheck() => _calculateWithNullCheck = !_calculateWithNullCheck;
    public void SetGetComponentLoops(float amount) => _noOfGetComponent = (int)amount;
    public void SetForLoops(float amount) => _noOfForLoops = (int)amount;
    public void SetFindObjectLoops(float amount) => _noOfFindObjects = (int)amount;
    public void SetNullCheckLoops(float amount) => _noOfNullChecks = (int)amount;
    private void OnDisable() => updateManager.RemoveUpdatable(this);
}
}
