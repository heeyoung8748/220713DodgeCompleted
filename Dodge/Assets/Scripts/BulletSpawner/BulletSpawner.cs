using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletSpawner : MonoBehaviour
{
    public GameObject BulletPrefab;
    public Transform Player;
    public float scriptOutput = 0.0f;
    public float randomTime = 0.0f;
    // Start is called before the first frame update
    public float randomCount = 0.5f;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        scriptOutput += Time.deltaTime;
        if(scriptOutput >= randomCount)
        {
            scriptOutput = 0.0f;
            randomCount = Random.Range(0.5f, 3f);
            // Vector3 spawnPosition = transform.position + new Vector3(0f, 0f, 2f);
            GameObject bullet = Instantiate(BulletPrefab, transform);
            bullet.transform.LookAt(Player);

        }
        
        
    }
}
