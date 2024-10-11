using System.Collections.Generic;
using UnityEngine;

public class GameMementoManager : MonoBehaviour
{
    private Stack<Memento> savedStates = new Stack<Memento>();
    [SerializeField] private PlayerMemento playerMemento;

    private void Update()
    {
        if (Input.GetKeyDown("p"))
        {
            savedStates.Push(playerMemento.SavedStates());
        }
        if (Input.GetKeyDown("r") && savedStates.Count > 0)
        {
            Memento lastMemento = savedStates.Pop();
            playerMemento.RestoreStates(lastMemento);
        }
    }
}