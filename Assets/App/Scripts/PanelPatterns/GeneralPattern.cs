using DataFl.ElementContainers;
using System.Collections.Generic;
using UnityEngine;

namespace DataFl.PanelPatterns
{
  public class GeneralPattern : MonoBehaviour
  {
    [SerializeField] private Dictionary<string, ElementContainer> containers;


    private void SetElementContainers()
    {
      containers = new Dictionary<string, ElementContainer>();

      for (int i = 0; i < transform.childCount; i++)
      {
        var containerObject = transform.GetChild(i);
        var container = containerObject.GetComponent<ElementContainer>();

        string containerKey = $"{container.ContainerType}{i}";
        
        containers.Add(containerKey, container);
      }
    }

    public void UpdateContainer<T>(List<T> list)
    {
      foreach (T value in list)
      {

      }
    }
  }
}