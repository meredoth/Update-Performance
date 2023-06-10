using System.Globalization;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace UpdatePerformance.UI_Scripts
{
public class ShowMilliSeconds : MonoBehaviour
{
   [SerializeField] private TextMeshProUGUI msLabel;
   [SerializeField] private SceneValues sceneValues;
   
   private float _averageMs;
   private float _duration;
   private float _updateCounter;

   private void Update()
   {
      _duration += Time.deltaTime;
      _updateCounter++;
      if (_duration >= 1f)
      {
         _averageMs = _duration * 1000f/ _updateCounter;
         _duration = 0f;
         _updateCounter = 0f;
         msLabel.text =  sceneValues.numberOfUpdates + " updates in: " + SceneManager.GetActiveScene().name + " take: " + _averageMs.ToString("0.##",CultureInfo.InvariantCulture) + "ms";
      }
   }
}
}
