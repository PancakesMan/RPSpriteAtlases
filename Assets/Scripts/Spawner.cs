using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Spawner : MonoBehaviour
{
    
    public GameObject[] Prefabs; // List of prefabs that can be spawned
    public Text EntityCounter; // Text object to display the number of enemies spawned
    public int SpawnsPerClick = 100; // Number of enemies spawned when mouse is clicked. Changed via inspector to 50 for android builds

    private int EntityCount; // Integer keeping track of the number of enemies spawned

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Checks if left mouse button was clicked or screen was tapped
        if(Input.GetMouseButtonDown(0))
        {
            // Uses a loop to spawn the number of enemies specified by the SpawnsPerClick variable
            for (int i = 0; i < SpawnsPerClick; i++)
            {
                // Randomly selects a prefab from the Prefabs GameObject array
                Spawn(Prefabs[Random.Range(0, Prefabs.Length)], Camera.main.ScreenToWorldPoint(Input.mousePosition));

                // Sets the text value of the EntityCounter Text object to the EntityCount variable
                EntityCounter.text = "Entities: " + EntityCount;
            }
        }
    }

    // Spawned a GameObject prefab at the specified position
    // Also increments the EntityCount variable
    public void Spawn(GameObject go, Vector2 pos)
    {
        GameObject obj = Instantiate(go);
        obj.transform.position = pos;

        EntityCount++;
    }
}
