using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private PlayerModel _model;
    
    public void Init(PlayerModel model)
    {
        _model = model;
        _model.Speed = 5;
        StartCoroutine(Movement());
    }

    private IEnumerator Movement()
    {
        while (true)
        {
            Vector3 pos = gameObject.transform.position;
            pos.x += _model.Direction * _model.Speed * Time.deltaTime;
            gameObject.transform.position = pos;
            yield return null;
        }
    }
}
