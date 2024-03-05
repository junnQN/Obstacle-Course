using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dropper : MonoBehaviour
{
    private MeshRenderer renderer;
    private Rigidbody _rigidbody;
    [SerializeField]private float timeToWait = 5f;
    // Start is called before the first frame update
    void Start()
    {
        renderer = GetComponent<MeshRenderer>();
        _rigidbody = GetComponent<Rigidbody>();
        renderer.enabled = false;
        _rigidbody.useGravity = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time > timeToWait)
        {
            renderer.enabled = true;
            _rigidbody.useGravity = true;
        }
    }
}
