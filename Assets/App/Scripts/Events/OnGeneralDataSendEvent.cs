using DataFl.EventManagement;
using System.Collections.Generic;

namespace DataFl.Events
{
  public class OnGeneralDataSendEvent : GameEvent
  {
    public readonly List<string> DataValues = new List<string>();

    public OnGeneralDataSendEvent(List<string> dataValues)
    {
      DataValues = dataValues;
    }
  }
}