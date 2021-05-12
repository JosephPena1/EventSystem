using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Event", menuName = "EventSystem/Event")]
public class Event : ScriptableObject
{
    private List<IListener> _listeners = new List<IListener>();

    /// <summary>
    /// Add a listener to the event's list of listeners
    /// </summary>
    /// <param name="newListener"></param>
    public void AddListener(IListener newListener)
    {
        _listeners.Add(newListener);
    }

    /// <summary>
    /// Calls invoke for every listener in the list
    /// </summary>
    /// <param name="sender">the object that raised the event</param>
    public void Raise(GameObject sender = null)
    {
        foreach (IListener listener in _listeners)
            listener.Invoke(sender);
    }
}
