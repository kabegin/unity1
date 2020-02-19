using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestMove : MonoBehaviour
{
    public float speedX=1;
    public float speedY=0;
    public float speedZ=0;
    private void FixedUpdate()
    {
        this.transform.Translate(speedX/50,speedY/50,speedZ/50);
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
