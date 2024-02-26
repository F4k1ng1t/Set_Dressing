using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using UnityEngine;

public class GunAnims : MonoBehaviour
{
    private Animator _anim;
    // Start is called before the first frame update
    void Start()
    {
        _anim = GetComponent<Animator>();
        
    }
    public void Shoot()
    {
        if (_anim != null)
        {
            
            _anim.PlayInFixedTime("Recoil");
            Debug.Log("Played animation");
           
        }
    }
    public void Stop()
    {
        if (_anim != null)
        {
            _anim.StopPlayback();
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
