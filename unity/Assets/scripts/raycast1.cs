using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class raycast1 : MonoBehaviour
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

            transform.position = new Vector3(Random.Range(-3f,3f), 1 , Random.Range(-3f,3f));
            Gamemanager.Score++;
            Debug.Log("el enemigo se movio " + Gamemanager.Score + " veces");
            }
        } 
    }


    private void OnDrawGizmos()
    {
    Gizmos.color = Color.red;
    Vector3 direction = enemyview.transform.TransformDirection(Vector3.forward) * raydistance;
    Gizmos.DrawLine(enemyview.position, direction);        
    }

}


