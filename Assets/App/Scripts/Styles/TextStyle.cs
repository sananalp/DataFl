using System;
using UnityEngine;

namespace DataFl.Styles
{
  [Serializable]
  public class TextStyle
  {
    [Header("Visual parameters")]
    [SerializeField] private Color color = Color.black;
    [SerializeField] private float size = 30.0f;

    public Color Color { get { return color; } }
    public float Size { get { return size; } }
  }
}