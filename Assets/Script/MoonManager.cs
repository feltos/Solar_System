using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoonManager : MonoBehaviour 
{

    [SerializeField]
    Vector3 direction;

	void Start ()
    {
		
	}
	

	void Update ()
	{
		
	}
    void FixedUpdate()
    {
        transform.position = transform.position + direction;
    }
}
