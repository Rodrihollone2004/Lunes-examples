using System.Collections.Generic;
using UnityEngine;

public class InputController : MonoBehaviour
{
    private Stack<ICommand> commands = new Stack<ICommand>();
    [SerializeField] private PlayerCommand player;

    private void Update()
    {
        if (Input.GetKeyDown("w"))
        {
            ICommand moveForward = new MoveForwardCommand(player);
            moveForward.Execute();
            commands.Push(moveForward);
        }
        if (Input.GetKeyDown("s"))
        {
            ICommand moveBacward = new MoveBacwardCommand(player);
            moveBacward.Execute();
            commands.Push(moveBacward);
        }
        if (Input.GetKeyDown("d"))
        {
            ICommand moveRight = new MoveRightCommand(player);
            moveRight.Execute();
            commands.Push(moveRight);
        }
        if (Input.GetKeyDown("a"))
        {
            ICommand moveLeft = new MoveLeftCommand(player);
            moveLeft.Execute();
            commands.Push(moveLeft);
        }

        if (Input.GetKeyDown("r") && commands.Count > 0)
        {
            ICommand lastCommand = commands.Pop();
            lastCommand.Undo();
        }
    }
}
