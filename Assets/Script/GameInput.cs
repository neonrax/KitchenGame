using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor.Build.Player;
using UnityEngine;

public class GameInput : MonoBehaviour

{
    public static GameInput Instance { get; private set;} 
    
    private PlayerInputActions playerInputActions;
    private void Awake()
    {
        Instance = this;

        playerInputActions = new PlayerInputActions();

        playerInputActions.Player.Enable();

    }


    public Vector2 GetMovemetVectorNormalized()
    {
        Vector2 InputVector = playerInputActions.Player.Move.ReadValue<Vector2>();

       return InputVector;
    }
}
