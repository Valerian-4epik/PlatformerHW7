using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class Patroller : MonoBehaviour
{
    [SerializeField] private float _speed;
    private float _stepValue = 3.0f;

    private void Start()
    {
        transform.DOMove(new Vector3(transform.position.x+_stepValue, transform.position.y), _speed).SetLoops(-1, LoopType.Yoyo);
    }
}
