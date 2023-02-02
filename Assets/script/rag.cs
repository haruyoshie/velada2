using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rag : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject ragdoll;
    public BoxCollider box;
    public Rigidbody rb;
    void Start()
    {
        
    }
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "ball")
        {
            ragdoll.SetActive(true);
            box.enabled = false;
            rb.AddForce(0, 100f, 0);
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
