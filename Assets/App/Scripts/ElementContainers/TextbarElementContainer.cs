using DataFl.Elements;
using DataFl.ScriptableObjects;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

namespace DataFl.ElementContainers
{
  public class TextbarElementContainer : ElementContainer
  {
    [SerializeField] private TMP_Text headerText;
    [SerializeField] private TextbarElement textbarElementPrefab;
    [SerializeField] private TextbarContainerStyle containerStyle;

    public override void GenerateElements(List<string> list)
    {
      headerText.text = list[0];

      for (int i = 1; i < list.Count; i++)
      {
        TextbarElement textbarElement = Instantiate(textbarElementPrefab, Content);
        var headerStyle = containerStyle.TextbarElementModels[i].HeaderStyle;
        var bodyStyle = containerStyle.TextbarElementModels[i].BodyStyle;

        textbarElement.SetElementValue(headerStyle.Value, list[i]);
        textbarElement.SetHeaderStyle(headerStyle.Color, headerStyle.Size);
        textbarElement.SetBodyStyle(bodyStyle.Color, bodyStyle.Size);
      }
    }
  }
}