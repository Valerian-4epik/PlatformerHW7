using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class Patroller : MonoBehaviour
{
    [SerializeField] private float _speed;

    private void Start()
    {
        transform.DOMove(new Vector3(transform.position.x+3, transform.position.y), _speed).SetLoops(-1, LoopType.Yoyo);
    }
}
