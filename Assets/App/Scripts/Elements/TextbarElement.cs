using TMPro;
using UnityEngine;

namespace DataFl.Elements
{
  public class TextbarElement : MonoBehaviour
  {
    [SerializeField] private TMP_Text headerText;
    [SerializeField] private TMP_Text bodyText;

    public void SetElementValue(string header, string body)
    {
      headerText.text = header;
      bodyText.text = body;
    }
    public void SetHeaderStyle(Color color, float size)
    {
      headerText.color = color;
      headerText.fontSize = size;
    }
    public void SetBodyStyle(Color color, float size)
    {
      bodyText.color = color;
      bodyText.fontSize = size;
    }
  }
}