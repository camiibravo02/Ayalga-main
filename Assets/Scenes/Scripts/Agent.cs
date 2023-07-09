using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Agent : MonoBehaviour
{
    [SerializeField] NavMeshAgent _agent;
    
    [SerializeField] GameObject [] _wayPoints;
    [SerializeField] GameObject _destination;
    [SerializeField] int wayPoint = 0;
    [SerializeField] NavMeshAgent agent;
    LayerMask _layer;

    // Start is called before the first frame update
    void Awake()
    {
        _agent = GetComponent<NavMeshAgent>();
    }

    private void Start()
    {
        
        _destination = GameObject.FindGameObjectWithTag("Destination");
        
        
    }

    // Update is called once per frame
    void Update()
    {


        _agent.destination = _wayPoints[wayPoint].transform.position;
        
        
       
        

    }

    private void OnTriggerEnter(Collider other)
    {
        
        if (other.gameObject.CompareTag("WayPoint"))
        {
            wayPoint = 1;

        }

        if (other.gameObject.CompareTag("WayPoint1"))
        {
            wayPoint = 2;

        }

        if (other.gameObject.CompareTag("WayPoint2"))
        {
            wayPoint = 3;

        }

        if (other.gameObject.CompareTag("WayPoint3"))
        {
            Debug.Log("PERDISTE... ENTREGÁ A LA AYALGA");

        }


    }
}
