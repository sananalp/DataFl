using System;
using UnityEngine;

namespace DataFl.Styles
{
  [Serializable]
  public class TextbarHeaderStyle : TextStyle
  {
    [Header("Value parameters")]
    [SerializeField] private string value;
  }
}