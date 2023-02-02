using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class vidaController : MonoBehaviour
{
    public int vida;
    public ParticleSystem sangre;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void GetDamage(int damage)
    {
        vida -= damage;
    }
}
