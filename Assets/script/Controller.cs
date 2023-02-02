using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using StarterAssets;

public class Controller : MonoBehaviour
{
    public StarterAssetsInputs starterAssetsInputs;
    public Animator animator;

    private void Awake()
    {
        starterAssetsInputs = GetComponent<StarterAssetsInputs>();
        animator = GetComponent<Animator>();
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Debug.Log(starterAssetsInputs.punch);
        //if (starterAssetsInputs.punch)
        //{
        //    animator.SetLayerWeight(
        //        1,
        //        Mathf.Lerp(animator.GetLayerWeight(1), 1f, Time.deltaTime * 10f)
        //    );
        //}
        //else
        //{
        //    animator.SetLayerWeight(
        //        1,
        //        Mathf.Lerp(animator.GetLayerWeight(1), 0f, Time.deltaTime * 10f)
        //    );
        //}
    }
}
