using DataFl.ElementModels;
using System.Collections.Generic;
using UnityEngine;

namespace DataFl.ScriptableObjects
{
  [CreateAssetMenu(fileName = "TextbarContainerStyle", menuName = "ContainerStyles/TextbarContainerStyle")]
  public class TextbarContainerStyle : ScriptableObject
  {
    [SerializeField] private List<TextbarElementModel> textbarElementModels = new List<TextbarElementModel>();

    public List<TextbarElementModel> TextbarElementModels { get { return textbarElementModels; } }
  }
}