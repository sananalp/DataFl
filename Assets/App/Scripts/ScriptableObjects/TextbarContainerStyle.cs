using DataFl.Elements;
using System.Collections.Generic;
using UnityEngine;

namespace DataFl.ScriptableObjects
{
  [CreateAssetMenu(fileName = "TextbarContainerStyle", menuName = "ContainerStyles/TextbarContainerStyle")]
  public class TextbarContainerStyle : ScriptableObject
  {
    [SerializeField] private List<TextbarElement> textbarElements = new List<TextbarElement>();
  }
}