using DataFl.Enums;
using DataFl.ScriptableObjects;
using UnityEngine;

namespace DataFl.ElementContainers
{
  public class ElementContainer : MonoBehaviour
  {
    [SerializeField] private ContainerType containerType;
    [SerializeField] private TextbarContainerStyle containerStyle;

    public ContainerType ContainerType { get { return containerType; } }
  }
}