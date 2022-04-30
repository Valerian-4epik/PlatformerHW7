using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] private Coin _coin;
    [SerializeField] private Transform[] _spawns;
    
    private void Start()
    {
        StartCoroutine(Spawn());
    }

    private IEnumerator Spawn()
    {
        var waitForFiveSeconds = new WaitForSeconds(5);

        while (true)
        {
            for (int i = 0; i < _spawns.Length; i++)
            {
                Coin newCoin = Instantiate(_coin, _spawns[i].position, Quaternion.identity);

                yield return waitForFiveSeconds;
            }

            yield return waitForFiveSeconds;
        }
    }
}
