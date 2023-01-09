using DataFl.Enums;
using System.Collections.Generic;
using UnityEngine;

namespace DataFl.ElementContainers
{
  public class ElementContainer : MonoBehaviour
  {
    [SerializeField] private ContainerType containerType;
    [SerializeField] private Transform content;

    public ContainerType ContainerType { get { return containerType; } }
    public Transform Content { get { return content; } }

    public virtual void GenerateElements(List<string> list)
    {

    }

    public virtual void GenerateElements(List<int> list)
    {

    }
  }
}