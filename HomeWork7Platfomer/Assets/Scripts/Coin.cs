using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Coin : MonoBehaviour
{
    [SerializeField] private UnityEvent _reached;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.TryGetComponent<PlayerControllerV2>(out PlayerControllerV2 player))
        {
            _reached.Invoke();
            Destroy(gameObject, 0.3f);
        }
    }
}
