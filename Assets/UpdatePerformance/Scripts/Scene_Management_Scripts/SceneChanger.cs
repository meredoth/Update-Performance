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
   [SerializeField] private Toggle findAnyObjectToggle;
   [SerializeField] private Toggle findFirstObjectToggle;
   [SerializeField] private Toggle nullCheckToggle;
   [SerializeField] private Slider getComponentsSlider;
   [SerializeField] private Slider forLoopsSlider;
   [SerializeField] private Slider findAnyObjectSlider;
   [SerializeField] private Slider findFirstObjectSlider;
   [SerializeField] private Slider nullChecksSlider;
   [SerializeField] private Slider numberOfUpdatesSlider;

   private void OnEnable()
   {
      getComponentsToggle.isOn = sceneValues.calculateWithGetComponent;
      forLoopsToggle.isOn = sceneValues.calculateWithForLoop;
      findAnyObjectToggle.isOn = sceneValues.calculateWithFindAnyObject;
      findFirstObjectToggle.isOn = sceneValues.calculateWithFindFirstObject;
      nullCheckToggle.isOn = sceneValues.calculateWithNullCheck;
      getComponentsSlider.value = sceneValues.numberOfGetComponents;
      forLoopsSlider.value = sceneValues.numberOfForLoops;
      findAnyObjectSlider.value = sceneValues.numberOfFindAnyObject;
      findFirstObjectSlider.value = sceneValues.numberOfFindFirstObject;
      nullChecksSlider.value = sceneValues.numberOfNullChecks;
      numberOfUpdatesSlider.value = sceneValues.numberOfUpdates;
   }

   public void ChangeScene()
   {
      sceneValues.calculateWithGetComponent = getComponentsToggle.isOn;
      sceneValues.calculateWithForLoop = forLoopsToggle.isOn;
      sceneValues.calculateWithFindAnyObject = findAnyObjectToggle.isOn;
      sceneValues.calculateWithFindFirstObject = findFirstObjectToggle.isOn;
      sceneValues.calculateWithNullCheck = nullCheckToggle.isOn;
      sceneValues.numberOfGetComponents = getComponentsSlider.value;
      sceneValues.numberOfForLoops = forLoopsSlider.value;
      sceneValues.numberOfFindAnyObject = findAnyObjectSlider.value;
      sceneValues.numberOfFindFirstObject = findFirstObjectSlider.value;
      sceneValues.numberOfNullChecks = nullChecksSlider.value;
      sceneValues.numberOfUpdates = numberOfUpdatesSlider.value;

      SceneManager.LoadScene((SceneManager.GetActiveScene().buildIndex + 1) %
                             SceneManager.sceneCountInBuildSettings);
   }
}
}