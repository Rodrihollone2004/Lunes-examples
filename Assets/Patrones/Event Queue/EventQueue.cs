using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventQueue : MonoBehaviour
{
    private Queue<IEvent> events = new Queue<IEvent>();
    private bool isProcessingEvents = false;

    public void AddEvent(IEvent gameEvent)
    {
        events.Enqueue(gameEvent);
    }

    public void Execute()
    {
        if (!isProcessingEvents)
        {
            StartCoroutine(ProcessEvents());
        }
    }

    private IEnumerator ProcessEvents()
    {
        isProcessingEvents = true;

        while (events.Count > 0)
        {
            IEvent gameEvent = events.Dequeue();
            gameEvent.Execute();

            yield return new WaitForSeconds(1f);
        }

        isProcessingEvents = false;
    }
}

