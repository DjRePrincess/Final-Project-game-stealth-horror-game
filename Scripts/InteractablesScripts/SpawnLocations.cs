using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnLocations : MonoBehaviour
{
    // we can have a hashtable for the Transform possibleLocations 
    // count variable can itereate thru the string, transform hashtable 

    // original keycard 1 2 3 
    private Dictionary<int, Transform> spawnLocations; // dict not hashtable bc the latter converts the stuff into objects? 
    public Transform spawnLocation1;
    public GameObject batteryPrefab;
    // Start is called before the first frame update
    void Start()
    {
        spawnLocations = new Dictionary<int, Transform>();
        spawnLocations.Add(1, spawnLocation1); // wehre we add all the spawn locations 

        // where we call SpawnObject()
        //SpawnObject(batteryPrefab); // problem code 


    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void SpawnObject(GameObject objectToSpawn)
    {
        // need to create the hashtable first 
        GameObject obj = Instantiate(objectToSpawn, spawnLocation1.position, Quaternion.identity);
        Debug.Log("Object spawned");
        //Instantiate(objectToSpawn, spawnLocation1);
    }
}
