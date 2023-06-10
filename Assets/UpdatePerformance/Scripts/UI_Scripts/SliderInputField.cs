using System;
using System.Globalization;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace UpdatePerformance.UI_Scripts
{
public class SliderInputField : MonoBehaviour
{
    [SerializeField] private Slider slider;
    [SerializeField] private TMP_InputField inputField;

    private void Start() => inputField.text = slider.value.ToString(CultureInfo.InvariantCulture);

    private void OnEnable()
    {
        slider.onValueChanged.AddListener(OnSliderChanged);
        inputField.onValueChanged.AddListener(OnInputFieldChanged);
    }

    private void OnDisable()
    {
        slider.onValueChanged.RemoveListener(OnSliderChanged);
        inputField.onValueChanged.RemoveListener(OnInputFieldChanged);
    }

    private void OnSliderChanged(float number)
    {
        if (inputField.text != number.ToString(CultureInfo.InvariantCulture))
            inputField.text = number.ToString(CultureInfo.InvariantCulture);
    }
 
    private void OnInputFieldChanged(string text)
    {
        if (slider.value.ToString(CultureInfo.InvariantCulture) != text)
        {
            if (!int.TryParse(text, out var number)) return;

            slider.value = Mathf.Clamp(number, (int)slider.minValue, (int)slider.maxValue);
        }
    }
}
}
