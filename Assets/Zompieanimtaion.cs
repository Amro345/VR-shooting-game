using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Zompieanimtaion : MonoBehaviour
{
    private Animator animator;
    public float velocity = 0;

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();

    }

    // Update is called once per frame
    void Update()
    {
        if (OVRInput.Get(OVRInput.Button.Two))
        {
            velocity += 0.05f;
            if (velocity > 1)
            {
                velocity = 1;
            }
            animator.SetFloat("velocity", velocity);
        }
    }
}
        
    
