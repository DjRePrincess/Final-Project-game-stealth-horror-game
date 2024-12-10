using System.Collections;
using System.Collections.Generic;
using System.Threading;
using Unity.VisualScripting;
using UnityEngine;

public class BatteryParent : MonoBehaviour
{
    
    public Queue<GameObject> batteriesOnFlashlight;
    private GameObject initialBattery;

    private int timer = 0;
    private float timeToConsume1Battery = 5f;
    private int seconds;


    [SerializeField] private NewFlashlight flashlight; // enabling and disabling when the stack has a battery 
    // Start is called before the first frame update
    void Start()
    {
        batteriesOnFlashlight = new Queue<GameObject>();
        batteriesOnFlashlight.Enqueue(initialBattery);

    }

    // Update is called once per frame
    void Update()
    {
        //Debug.Log(batteriesOnFlashlight.Count);
        //timer += (int)Time.deltaTime;
        //seconds = timer % 60; // seconds have to be float so that it is compared only once? hopefully // seconds is being made on this Update() function, need to be a global var to change to 0
        //Debug.Log(seconds);

        //if (seconds == timeToConsume1Battery) // will get triggered multiple times 
        //{
        //    ConsumeOneBattery();

        //}
        //Debug.Log(batteriesOnFlashlight.Count);
    }
    private void ConsumeOneBattery()
    {
        batteriesOnFlashlight.Dequeue();
        //Debug.Log(batteriesOnFlashlight.Count);
    }
}
// destroying the gameobejct and adding it onto the queue, done --

// timer thing is actually working perfectly --

// i cant make timer work so i need to have a workaround 
// condition to remove the battery 

// just need to remove battery from queue when it seconds hit 45 
// reset seconds to 0 

// still need to consume battery 
// 45 seconds that the light is on 
// dequeue a battery from the qeueue 

// when there is no batteries on queue 
// flashlight object or reference will be disabled 
// NO MATTER HOW U PRESS E ; maybe go into newflashlight script and add an if statement 
    // if queue is 0 then light disabled 
    // reference to the battery parent. queue 