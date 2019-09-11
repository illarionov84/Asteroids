using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputController
{
    private Action<int> OnHorizontalAxisMovement;

    public InputController(Action<int> onHorizontalAxisMovement)
    {
        OnHorizontalAxisMovement = onHorizontalAxisMovement;
    }
    
    public void Update()
    {
        float xAxis = Input.GetAxisRaw("Horizontal");
        if (xAxis == 1)
        {
            OnHorizontalAxisMovement?.Invoke(1);
        } 
        else if (xAxis == -1)
        {
            OnHorizontalAxisMovement?.Invoke(-1);
        }
        else if (xAxis == 0)
        {
            OnHorizontalAxisMovement?.Invoke(0);
        }
    }
}
