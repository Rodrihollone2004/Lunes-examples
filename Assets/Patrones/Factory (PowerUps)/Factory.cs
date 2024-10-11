using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Factory : MonoBehaviour
{
    [SerializeField] PowerUp[] powerUps;
    Dictionary<string, PowerUp> powerUpDict;

    private void Awake()
    {
        powerUpDict = new Dictionary<string, PowerUp>();

        foreach (var powerUp in powerUps)
        {
            powerUpDict.Add(powerUp.Id, powerUp);
        }
    }

    public PowerUp Create(string id)
    {
        if(!powerUpDict.TryGetValue(id, out PowerUp powerUp))
        {
            return null;
        }
        return Instantiate(powerUp);
    }

}
