using DataFl.Styles;
using System;
using UnityEngine;

namespace DataFl.ElementModels
{
  [Serializable]
  public class TextbarElementModel
  {
    [SerializeField] private TextbarHeaderStyle headerStyle;
    [SerializeField] private TextbarBodyStyle bodyStyle;
    
    public TextbarHeaderStyle HeaderStyle { get { return headerStyle; } }
    public TextbarBodyStyle BodyStyle { get { return bodyStyle; } }
  }
}