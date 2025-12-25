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
        InvokeRepeating("SpawnCrumbs", 0.0f, Random.Range(1.0f, 5.0f));
        //SpawnCrumbs();
    }

    void Awake()
    {
        SingletonPattern();
    }

    void SpawnCrumbs()
    {
        for(int i = 0; i<1; i++)
        {
            Instantiate(GetRandomObject(), GetSpawnPosition(), Quaternion.identity);
        }
    }

    Vector3 GetSpawnPosition()
    {
        return center + new Vector3(Random.Range(-8.0f, 8.0f), 6.0f, 25.0f);
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
