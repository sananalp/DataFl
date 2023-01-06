using UnityEngine;

namespace DataFl.ScriptableObjects
{
  [CreateAssetMenu(fileName = "PanelPattern", menuName = "ScriptableObjects/CreatePanelPattern")]
  public class PanelPatternScriptableObject : ScriptableObject
  {
    [SerializeField] private GameObject patternObject;

  }
}