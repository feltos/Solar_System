using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PlanetManager : MonoBehaviour 
{
    [SerializeField]GameObject Planet;
    Vector3 Gravity;
    [SerializeField]
    Vector3 Direction;
    Vector3 Distance;
    Vector3 ConstanteG = new Vector3(6,0,0);
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
        Distance = (Planet.transform.position - transform.position);
        Gravity = (Distance * (PlanetMass * Mass) / Mathf.Pow(
            (transform.position - Planet.transform.position).magnitude, 2.0f));
        transform.position += Direction + Gravity * Time.deltaTime;
    }
}
