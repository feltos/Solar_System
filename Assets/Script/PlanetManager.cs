using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PlanetManager : MonoBehaviour 
{
    [SerializeField]GameObject Planet;
    [SerializeField]
    Vector3 Direction;
    Vector3 Distance;
    Vector3 Velocity;
    [SerializeField]
    float Mass;
    [SerializeField]float PlanetMass;

    void Awake()
    {
        
    }

    void Start ()
	{
       
    }
	
	void Update () 
	{
        
    }
    void FixedUpdate()
    {
        Distance = (Planet.transform.position - transform.position).normalized;
        Velocity = Distance * (PlanetMass * Mass) / Mathf.Pow((transform.position - Planet.transform.position).magnitude,2.0f);
        transform.position += Velocity * Time.deltaTime + Direction;  
    }
}
