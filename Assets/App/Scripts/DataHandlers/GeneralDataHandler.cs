using DataFl.DataContainers;
using DataFl.Events;
using DataFl.EventManagement;
using System.Collections.Generic;
using UnityEngine;

namespace DataFl.DataHandlers
{
  public class GeneralDataHandler : MonoBehaviour
  {
    private void Start()
    {
      HandleData();
    }
    public void HandleData()
    {
      CloudData cloudData = new CloudData();

      List<string> dataCollection = new List<string>();

      string stationName = cloudData.docID;
      string stationActivity = cloudData.activity ? "Active" : "Deactive";
      string stationCoordinates = $"{cloudData.coordinates[0]}, {cloudData.coordinates[1]}";
      string stationCoveredArea = $"{cloudData.coveredArea}";

      dataCollection.Add(stationName);
      dataCollection.Add(stationActivity);
      dataCollection.Add(stationCoordinates);
      dataCollection.Add(stationCoveredArea);

      EventManager.Instance.Raise(new OnGeneralDataSendEvent(dataCollection));
    }
  }
}