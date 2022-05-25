using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject rabbit;
    public GameObject fox;
    public GameObject[] trees = new GameObject[4];

    // Start is called before the first frame update
    void Start()
    {
        spawnTrees(200);
        StartCoroutine(SpawnRabbit(5, 3));
        StartCoroutine(SpawnFox(5, 3));
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Spawn()
    {

            var pos = new Vector3(Random.Range(-10.0f, 10.0f), 0, Random.Range(-10.0f, 10.0f));
            GameObject rabbitSpawn = (GameObject)Instantiate(rabbit, pos, transform.rotation);    
    }
    public IEnumerator waiter(float sec)
    {
        yield return new WaitForSecondsRealtime(sec);
    }
    IEnumerator Text()  //  <-  its a standalone method
    {
        Debug.Log("Hello");
        yield return new WaitForSeconds(3);
        Debug.Log("ByeBye");
       }

    IEnumerator SpawnRabbit(int count, float delay)
    {
        for (int i = 0; i < count; i++)
        {
            var pos = new Vector3(Random.Range(-10.0f, 10.0f), 0.5f, Random.Range(-10.0f, 10.0f));
            var prefab = rabbit;
            Instantiate(prefab, pos, prefab.transform.rotation);
            yield return new WaitForSeconds(delay);
        }
    }
    IEnumerator SpawnFox(int count, float delay)
    {
        for (int i = 0; i < count; i++)
        {
            var pos = new Vector3(Random.Range(-10.0f, 10.0f), 0.5f, Random.Range(-10.0f, 10.0f));
            var prefab = fox;
            Instantiate(prefab, pos, prefab.transform.rotation);
            yield return new WaitForSeconds(delay);
        }
    }
    public void spawnTrees(int count)
    {
        for (int i = 0; i < count; i++)
        {
            var pos = new Vector3(Random.Range(-60.0f, 220.0f), 0, Random.Range(-120.0f,120.0f));
            var prefab = trees;
            Instantiate(prefab[Random.Range(0, 3)], pos, prefab[Random.Range(0, 3)].transform.rotation);
        }
    }
}
