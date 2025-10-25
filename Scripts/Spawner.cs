using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject emre;
    
    private void Start()
    {
        Vector3 pos = new Vector3(0, 0, 0);
        for (int i = 0; i < 5; i++)
        {
            Instantiate(emre, pos, Quaternion.identity);
            pos.y += i;
        }
    }
}
