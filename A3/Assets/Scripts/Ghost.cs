using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ghost : MonoBehaviour
{
    public RuntimeAnimatorController dogUp;
    public RuntimeAnimatorController dogDown;
    public RuntimeAnimatorController dogLeft;
    public RuntimeAnimatorController dogRight;
    // Start is called before the first frame update
    void Start()
    {
        UpdateAnimatorController();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void UpdateAnimatorController()
    {

    }
}
