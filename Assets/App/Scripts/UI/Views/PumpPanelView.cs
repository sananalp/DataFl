using DataFl.PanelPatterns;
using DataFl.UI.Controllers;
using System.Collections.Generic;
using UnityEngine;

namespace DataFl.UI.Views
{
  public class PumpPanelView : MonoBehaviour
  {
    [Header("Parameters")]
    [SerializeField] private GeneralPattern generalPattern;

    [Header("Links")]
    [SerializeField] private PumpPanelViewController controller;

    public void GeneralPatternViewUpdate(List<string> dataValues)
    {
      generalPattern.SetElementContainers();
      generalPattern.UpdateContainer(dataValues);
    }
  }
}