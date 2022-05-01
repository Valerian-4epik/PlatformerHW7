using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Coin : MonoBehaviour
{
    [SerializeField] private UnityEvent _contactWithPlayer;

    private float _delay = 0.3f;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.TryGetComponent<PlayerController>(out PlayerController player))
        {
            _contactWithPlayer.Invoke();
            Destroy(gameObject, _delay);
        }
    }
}
