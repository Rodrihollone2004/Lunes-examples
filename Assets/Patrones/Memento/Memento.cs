using System.Collections;
using UnityEngine;

public class Memento 
{
    public Vector3 Position { get; set; }
    public int Health {  get; set; }

    public Memento(Vector3 position, int health) 
    { 
        this.Position = position;
        this.Health = health;
    }    
}
