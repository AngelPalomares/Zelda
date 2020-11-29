using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class SignalListener : MonoBehaviour
{
    public SignalE monto;
    public UnityEvent signalEvent;

    public void onSignalRaised()
    {
        signalEvent.Invoke();
    }
    private void OnEnable()
    {
        monto.RegisterListener(this);
    }
    private void OnDisable()
    {
        monto.DeRegisterListener(this);
    }

}
