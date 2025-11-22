using System.Collections;
using UnityEngine;

public class KuleSpawner : MonoBehaviour
{
    public GameObject kulePrefab;
    private Player _playerScript;

    private void Start()
    {
        StartCoroutine(Wake(5f));
        StartCoroutine(FindPlayer());
    }

    private IEnumerator Wake(float time)
    {
        Instantiate(kulePrefab, transform.position, Quaternion.identity);
        yield return new WaitForSeconds(time);
    }

    private IEnumerator FindPlayer()
    {
        while (!_playerScript)
        {
            GameObject player = GameObject.FindWithTag("Player");
            if (player)
            {
                _playerScript = player.GetComponent<Player>();
            }
            else
            {
                Debug.LogError("No player found");
            }
            
            yield return new WaitForSeconds(1f);
        }
    }
}
