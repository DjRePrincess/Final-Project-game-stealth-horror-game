using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkillTree : MonoBehaviour
{
    public TreeNode<GameObject> root;

    public GameObject extendReach1;
    public GameObject extendReach2;

    public GameObject fasterSpeed1;
    public GameObject fasterSpeed2;
    // Start is called before the first frame update
    void Start()
    {
        root.AddChild(extendReach1);
        root.AddChild(fasterSpeed1);
        
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
