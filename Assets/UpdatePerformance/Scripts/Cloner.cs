using UnityEngine;

namespace UpdatePerformance
{
public class Cloner : MonoBehaviour 
{
    [SerializeField] private MonoBehaviour script;
    [SerializeField] private SceneValues sceneValues;
    
    private int _total;
    
    private void Awake() 
    {
        _total = (int)sceneValues.numberOfUpdates;

        for (var i = 0; i < _total - 1; i++)
        {
            gameObject.AddComponent(script.GetType());
        }
    }
}
}
