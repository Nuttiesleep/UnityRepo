using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEditor.SearchService;
using UnityEngine;
using UnityEngine.SceneManagement;
public class NewBehaviourScript : MonoBehaviour
{
    // Start is called before the first frame update
    public float speed;

    Rigidbody rb;

    float xInput;
    float yInput;
    int score = 0;
    public int winScore;
    public GameObject winText;
    public GameObject looseText;
    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.y < -5f) {
            //SceneManager.LoadScene("Game");
            looseText.SetActive(true);
        }
        if (Input.GetKey(KeyCode.P)) {
            SceneManager.LoadScene("Game");
        }
    }
    private void FixedUpdate(){
        xInput = 0;
        yInput = 0;
    if (Input.GetKey(KeyCode.W))
    {
        yInput = 1;
    }
    if (Input.GetKey(KeyCode.S))
    {
        yInput = -1;
    }
    if (Input.GetKey(KeyCode.D))
    {
        xInput = 1;
    }
    if (Input.GetKey(KeyCode.A))
    {
        xInput = -1;
    }
        rb.AddForce(xInput * speed, 0, yInput * speed);
    } 

    private void OnTriggerEnter(Collider other) {
        if(other.gameObject.tag == "Collectable") {
            other.gameObject.SetActive(false);
            score++;
            if (score >= winScore) {
                winText.SetActive(true);
            }

        }
    }
}
 