using HoloToolkitExtensions.Audio;
using HoloToolkitExtensions.Messaging;
using UnityEngine;

public class SpeechCommandExecuter : MonoBehaviour
{
    public void ExecuteTestCommand()
    {
        Messenger.Instance.Broadcast(new ConfirmSoundMessage());
    }
}
