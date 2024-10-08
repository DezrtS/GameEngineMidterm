using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Subject : MonoBehaviour
{
    protected readonly List<Observer> observers = new();

    public void Subscribe(Observer observer)
    {
        observers.Add(observer);
    }

    public void Unsubscribe(Observer observer)
    {
        observers.Remove(observer);
    }
}
