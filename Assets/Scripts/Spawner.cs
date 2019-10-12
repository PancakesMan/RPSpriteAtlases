using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Spawner : MonoBehaviour
{
    public GameObject[] Prefabs;
    public Text EntityCounter;
    public int SpawnsPerClick = 100;

    private int EntityCount;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            for (int i = 0; i < SpawnsPerClick; i++)
            {
                Spawn(Prefabs[Random.Range(0, Prefabs.Length)], Camera.main.ScreenToWorldPoint(Input.mousePosition));
                EntityCounter.text = "Entities: " + EntityCount;
            }
        }
    }

    public void Spawn(GameObject go, Vector2 pos)
    {
        GameObject obj = Instantiate(go);
        obj.transform.position = pos;

        EntityCount++;
    }
}
