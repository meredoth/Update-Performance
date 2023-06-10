using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

namespace UpdatePerformance
{
public class SceneChanger : MonoBehaviour
{
   [SerializeField] public SceneValues sceneValues;
   [SerializeField] private Toggle getComponentsToggle;
   [SerializeField] private Toggle forLoopsToggle;
   [SerializeField] private Toggle findObjectToggle;
   [SerializeField] private Toggle nullCheckToggle;
   [SerializeField] private Slider getComponentsSlider;
   [SerializeField] private Slider forLoopsSlider;
   [SerializeField] private Slider findObjectSlider;
   [SerializeField] private Slider nullChecksSlider;
   [SerializeField] private Slider numberOfUpdatesSlider;

   private void OnEnable()
   {
      getComponentsToggle.isOn = sceneValues.calculateWithGetComponent;
      forLoopsToggle.isOn = sceneValues.calculateWithForLoop;
      findObjectToggle.isOn = sceneValues.calculateWithFindObject;
      nullCheckToggle.isOn = sceneValues.calculateWithNullCheck;
      getComponentsSlider.value = sceneValues.numberOfGetComponents;
      forLoopsSlider.value = sceneValues.numberOfForLoops;
      findObjectSlider.value = sceneValues.numberOfFindObject;
      nullChecksSlider.value = sceneValues.numberOfNullChecks;
      numberOfUpdatesSlider.value = sceneValues.numberOfUpdates;
   }

   public void ChangeScene()
   {
      sceneValues.calculateWithGetComponent = getComponentsToggle.isOn;
      sceneValues.calculateWithForLoop = forLoopsToggle.isOn;
      sceneValues.calculateWithFindObject = findObjectToggle.isOn;
      sceneValues.calculateWithNullCheck = nullCheckToggle.isOn;
      sceneValues.numberOfGetComponents = getComponentsSlider.value;
      sceneValues.numberOfForLoops = forLoopsSlider.value;
      sceneValues.numberOfFindObject = findObjectSlider.value;
      sceneValues.numberOfNullChecks = nullChecksSlider.value;
      sceneValues.numberOfUpdates = numberOfUpdatesSlider.value;

      SceneManager.LoadScene((SceneManager.GetActiveScene().buildIndex + 1) %
                             SceneManager.sceneCountInBuildSettings);
   }
}
}