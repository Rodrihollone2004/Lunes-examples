using UnityEngine;

public class PlayerMemento : MonoBehaviour
{
    int health;

    private void Awake()
    {
        health = Random.Range(0, 300);
    }

    public Memento SavedStates()
    {
        return new Memento(transform.position, health);
    }

    public void RestoreStates(Memento memento)
    {
        transform.position = memento.Position;
        this.health = memento.Health;
    }
}

