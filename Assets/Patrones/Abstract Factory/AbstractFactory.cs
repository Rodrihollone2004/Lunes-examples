using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AbstractFactory : MonoBehaviour
{
    [SerializeField] Factory factory;

    //HAY QUE ACTIVAR EL FACTORY NORMAL EN LA JERARQUÍA PARA QUE FUNCIONEN LOS OBJETOS AL INSTANCIARSE

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            factory.Create("ammo");
        }
        if (Input.GetKeyDown(KeyCode.H))
        {
            factory.Create("health");
        }
        if (Input.GetKeyDown(KeyCode.S))
        {
            factory.Create("speed");
        }
    }
}
