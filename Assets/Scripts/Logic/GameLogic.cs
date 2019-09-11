using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameLogic : MonoBehaviour
{
    [SerializeField] private PlayerController _playerController;
    private PlayerModel _playerModel;
    private InputController _inputController;
    
    private void Awake()
    {
        StartCoroutine(Init());
    }

    private void OnHorizontalAxisMovement(int direction)
    {
        if (direction == 1)
        {
            _playerModel.Direction = 1;
        } 
        else if (direction == -1)
        {
            _playerModel.Direction = -1;
        }
        else if (direction == 0)
        {
            _playerModel.Direction = 0;
        }
    }

    private IEnumerator Init()
    {
        _inputController = new InputController(OnHorizontalAxisMovement);
        _playerModel = new PlayerModel();
        _playerController.Init(_playerModel);
        StartCoroutine(GameProcess());
        yield return null;
    }

    private IEnumerator GameProcess()
    {
        while (true)
        {
            _inputController.Update();
            yield return null;
        }
    }
}
