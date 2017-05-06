using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PlanetManager : MonoBehaviour 
{
	[SerializeField]List<GameObject>Planets;
    Vector3 Gravity = new Vector3(0, 0, 0);
    double ConstanteG = 6.67 * Mathf.Pow(10,-11);
    [SerializeField]
    float SunMass;
    [SerializeField]
    float EarthMass;
    [SerializeField]
    float MoonMass;
    void Start ()
	{
		
	}
	

	void Update () 
	{
        foreach(GameObject planet in Planets)
        {
            transform.position = (ConstanteG * (SunMass * EarthMass)) / Vector3.Distance();
        }
	}
}
