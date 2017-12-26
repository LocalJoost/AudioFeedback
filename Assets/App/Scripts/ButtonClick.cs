using System.Collections;
using System.Collections.Generic;
using HoloToolkit.Unity.InputModule;
using HoloToolkitExtensions.Audio;
using HoloToolkitExtensions.Messaging;
using UnityEngine;

public class ButtonClick : MonoBehaviour, IInputClickHandler
{
    public void OnInputClicked(InputClickedEventData eventData)
    {
        Messenger.Instance.Broadcast(
            new SpokenFeedbackMessage { Message = "Thank you for pressing this button"});
    }
}
