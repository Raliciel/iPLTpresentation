using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomSpawn : MonoBehaviour
{
    public GameObject spawning;
    public Transform spawnArea;
    float Xmax, Xmin, Ymax, Ymin;
    private void Start()
    {
        Xmax = spawnArea.position.x + spawnArea.localScale.x/2;
        Xmin = spawnArea.position.x - spawnArea.localScale.x/2;
        Ymax = spawnArea.position.y + spawnArea.localScale.y/2;
        Ymin = spawnArea.position.y - spawnArea.localScale.y/2;
    }

    public void RandomInArea()
    {
        GameObject spawn = Instantiate(spawning) as GameObject;
        spawn.transform.parent = spawnArea;
        spawn.transform.position = new Vector2(Random.Range(Xmin, Xmax), Random.Range(Ymin, Ymax));
    }

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.blue;
        Gizmos.DrawWireCube(spawnArea.position, spawnArea.lossyScale);
    }
}
