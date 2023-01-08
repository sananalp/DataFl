using DataFl.Styles;
using System;
using UnityEngine;

namespace DataFl.Elements
{
  [Serializable]
  public class TextbarElement
  {
    [SerializeField] private TextbarHeaderStyle headerStyle;
    [SerializeField] private TextbarBodyStyle bodyStyle;
  }
}