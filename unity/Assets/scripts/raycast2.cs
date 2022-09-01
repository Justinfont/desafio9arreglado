using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class raycast2 : MonoBehaviour
{
    [SerializeField] private Transform enemyview;
    

    [SerializeField]
    [Range(1f,30f)]
    private float raydistance = 10f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
     raycastlight();   
    }

    private void raycastlight()
    {
        RaycastHit hit;
        if (Physics.Raycast(enemyview.position,enemyview.transform.TransformDirection(Vector3.forward) * raydistance,  out hit))
        {
            if(hit.transform.CompareTag("playertag"))
            {
            Debug.Log("enemy dissapeared");
            Destroy(gameObject);
            }
        } 
    }


    private void OnDrawGizmos()
    {
    Gizmos.color = Color.green;
    Vector3 direction = enemyview.transform.TransformDirection(Vector3.forward) * raydistance;
    Gizmos.DrawLine(enemyview.position, direction);        
    }




}
