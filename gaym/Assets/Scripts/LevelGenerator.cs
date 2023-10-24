using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class LevelGenerator : MonoBehaviour
{
    #region SerializeFields
    [Header("Cylinder Attributes")]
    [Tooltip("Default Cylinder Prefab For Instantiate")]
    [SerializeField]
    private GameObject cylinder;

    [Tooltip("Minimum radius for cylinder size")]
    [SerializeField]
    private float minRadius;

    [Tooltip("Maximum radius for cylinder size")]
    [SerializeField]
    private float maxRadius;

    [Header("Enemy Cylinder Attributes")]

    [SerializeField]
    private Color enemy_cylinder;

 
    #endregion

    #region Private Variables
    private GameObject previous_cylinder;
    #endregion

   

    #region Functions
    private float FindRadius(float minR,float maxR)
    {
        float radius = Random.Range(minR, maxR);

        if (previous_cylinder != null) { 

            while (Mathf.Abs(radius - previous_cylinder.transform.localScale.x) < 0.4f)
        { 
            radius = Random.Range(minR, maxR);
        }
       }
       return radius; 

        
    }
    public void SpawnCylinder()
        {
        //FIND A RANDOM RADIUS A HEIGHT


        float radius = FindRadius(minRadius, maxRadius);
        float height = Random.Range(2f, 6f);

        //Apply radius and height to prefab
        cylinder.transform.localScale = new Vector3(radius, height, radius);



        //INSTANTIATE First Cylinder
        if (previous_cylinder == null)
        {
            previous_cylinder = Instantiate(cylinder, Vector3.zero, Quaternion.identity);

        }
        //All other Cylinders
        else
        {



            float spawnPoint = previous_cylinder.transform.position.z + previous_cylinder.transform.localScale.y + cylinder.transform.localScale.y;


            previous_cylinder = Instantiate(cylinder, new Vector3(0, 0, spawnPoint), Quaternion.identity);

            if (Random.value < 0.1f)
            {
                previous_cylinder.GetComponent<Renderer>().material.color = enemy_cylinder;
                previous_cylinder.tag = "Enemy";
            }

        }

        //ROTATE
        previous_cylinder.transform.Rotate(90, 0, 0);
    }
    #endregion
}
