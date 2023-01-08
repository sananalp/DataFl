using DataFl.PanelPatterns;
using DataFl.UI.Controllers;
using System.Collections.Generic;
using UnityEngine;

namespace DataFl.UI.Views
{
  public class PumpPanelView : MonoBehaviour
  {
    [Header("Parameters")]
    [SerializeField] private GeneralPattern panelPattern;

    [Header("Links")]
    [SerializeField] private PumpPanelViewController controller;

    public void UpdateView(List<string> dataValues)
    {
      panelPattern.UpdateContainer(dataValues);
    }
  }
}