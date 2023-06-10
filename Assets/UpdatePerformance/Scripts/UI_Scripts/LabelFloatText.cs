using System.Globalization;
using TMPro;
using UnityEngine;

namespace UpdatePerformance.UI_Scripts
{
public class LabelFloatText : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI self;

    public void SetNumber(float number) => self.text = number.ToString(CultureInfo.InvariantCulture);
}
}
