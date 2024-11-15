using System.Collections;
using System.Collections.Generic;
using System.Security;
using Unity.VisualScripting;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    // Start is called before the first frame update

    // static 
    public static int clicks = 0;
    [SerializeField]    
    private float speed;
    public float GetSpeed() {
        return speed;
    }
    public void SetSpeed(int a) {
        speed = a;
    }
    void Start()
    {
        speed = 0;
        Debug.Log($"Game started. Initial Speed: {speed}");
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))  // Left mouse button
        {
            clicks++;
            speed += 2;  
            Debug.Log($"Clicked! Total Clicks: {clicks}, Speed: {speed}");
        }
    }
}
