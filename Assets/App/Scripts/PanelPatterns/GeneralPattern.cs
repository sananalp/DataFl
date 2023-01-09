using DataFl.ElementContainers;
using DataFl.Enums;
using System.Collections.Generic;
using UnityEngine;

namespace DataFl.PanelPatterns
{
  public class GeneralPattern : MonoBehaviour
  {
    [SerializeField] private List<ElementContainer> containers;


    public void SetElementContainers()
    {
      containers = new List<ElementContainer>();

      foreach(Transform child in transform)
      {
        var container = child.GetComponent<ElementContainer>();

        if(container is ElementContainer)
        {
          containers.Add(container);
        }
      }
    }

    public void UpdateContainer(List<string> list)
    {
      foreach (var container in containers)
      {
        if (container.ContainerType == ContainerType.TextbarContainer)
        {
          container.GenerateElements(list);
        }
      }
    }
  }
}