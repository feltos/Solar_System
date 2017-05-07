using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// //////////////NE MARCHE QUE SUR LE PREMIER QUART DE ROTATION/////////////////////
/// </summary>

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
        ////////////////demandé a phillipe car complétement bloqué sans///////////////////
        Velocity = Distance * (PlanetMass * Mass) / Mathf.Pow((transform.position - Planet.transform.position).magnitude,2.0f);
        //////////////////////////////////////////////////////////////////////////////////     
        transform.position += Velocity * Time.deltaTime + Direction;  
    }
}
