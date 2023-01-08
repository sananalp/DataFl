using DataFl.Events;
using DataFl.UI.Views;
using DynamicBox.EventManagement;
using UnityEngine;

namespace DataFl.UI.Controllers
{
  public class PumpPanelViewController : MonoBehaviour
  {
    [Header("Links")]
    [SerializeField] private PumpPanelView view;

    #region Unity Methods

    void OnEnable()
    {
      EventManager.Instance.AddListener<OnGeneralDataSendEvent>(OnGeneralDataSendHandler);
    }

    void OnDisable()
    {
      EventManager.Instance.RemoveListener<OnGeneralDataSendEvent>(OnGeneralDataSendHandler);
    }

    #endregion


    #region Event Handlers

    private void OnGeneralDataSendHandler(OnGeneralDataSendEvent eventDetails)
    {
      view.UpdateView(eventDetails.DataValues);
    }

    #endregion
  }
}