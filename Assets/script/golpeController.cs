using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class golpeController : MonoBehaviour
{
    int damage = 5;
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag.Equals("player"))
        {
            other.GetComponent<vidaController>().GetDamage(damage);
            other.GetComponent<vidaController>().sangre.Play();
        }
    }
    private void OnTriggerStay(Collider other)
    {
        return;
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
