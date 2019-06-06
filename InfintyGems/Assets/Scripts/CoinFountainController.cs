using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinFountainController : MonoBehaviour
{
    [SerializeField]
    private GameObject[] objectToSpawn;

    private float minForce = 8f;
    private float maxForce = 12f;

    private float minRotation = -45;
    private float maxRotation = 45;

    private bool isActive;

    void Start()
    {
        //StartCoroutine(ISpawnCoin());
    }

    public void EnableCoinFountain() {
        isActive = true;
        StartCoroutine(ISpawnCoin());
    }

    public void DisableCoinFountain()
    {
        isActive = false;
        StopCoroutine(ISpawnCoin());
    }


    private IEnumerator ISpawnCoin()
    {
        while (isActive)
        {
            yield return new WaitForSeconds(0.1f);

            int objectIndex = Random.Range(0, objectToSpawn.Length);

            GameObject g = objectToSpawn[objectIndex];

            Vector3 currentPos = transform.position;
            float randomZ = Random.Range(minRotation, maxRotation);
            transform.rotation = Quaternion.Euler(0, 0, randomZ);

            g.transform.position = currentPos;

            GameObject spawnedObject = Instantiate(g);
            spawnedObject.GetComponent<Rigidbody>().AddForce(transform.up * Random.Range(minForce, maxForce), ForceMode.Impulse);
            Destroy(spawnedObject, 3f);
        }
    }



}
