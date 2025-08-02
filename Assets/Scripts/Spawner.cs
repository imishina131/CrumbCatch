using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public static Spawner instance;
    public List<GameObject> crumbPrefabs = null;
    public Vector3 center;
    public Vector3 size;
    // Start is called before the first frame update
    void Start()
    {
        SpawnCrumbs();
    }

    void Awake()
    {
        SingletonPattern();
    }

    void SpawnCrumbs()
    {
        for(int i = 0; i<3; i++)
        {
            Instantiate(GetRandomObject(), GetSpawnPosition(), Quaternion.identity);
        }
    }

    Vector3 GetSpawnPosition()
    {
        return center + new Vector3(Random.Range(-size.x/2, size.x/2), Random.Range(-size.y/2, size.y/2), 0f);
    }
    GameObject GetRandomObject()
    {
        return crumbPrefabs[Random.Range(0,crumbPrefabs.Count)];
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void SingletonPattern()
    {
        if(instance == null)
        {
            instance = this;
        }
        else if(instance != this)
        {
            Destroy(gameObject);
        }
    }

    void OnDrawGizmosSelected()
    {
        Gizmos.color = new Color(1,0,0,0.5f);
        Gizmos.DrawCube(center, size);
    }
}
