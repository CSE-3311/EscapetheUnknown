using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Pathfinding;

//removes the need for AI Path and Destination setter components
// add a rigid body 2d 
public class enemyAI : MonoBehaviour
{
    // reference to target
    public Transform target;

    //speed variable
    public float speed = 200f;

    //next waypoint distance
    public float nextWaypointD = 3f;

    //current path
    Path path;
    int currentWaypoint = 0;
    bool reachedEndPath = false;

    //reference seeker script and rigid body 2d
    Seeker seeker;
    Rigidbody2D rb;

    // Start is called before the first frame update
    void Start()
    {
        //finds the components on object
        seeker = GetComponent<Seeker>();
        rb = GetComponent<Rigidbody2D>();

        //generate the path
        //pass our start point, end path, function for path calculation
        InvokeRepeating("UpdatePath", 0f, 0.5f);
        

    }
    //updates path
    void UpdatePath()
    {
        //makes sure path is not updating while updating
        if(seeker.IsDone())
            seeker.StartPath(rb.position, target.position, OnPathComplete); 
    }

    //takes in a path
    void OnPathComplete(Path p)
    {
        //check for errors
        if(!p.error)
        {
            //current path is new path
            path = p;
            //reset our path
            currentWaypoint = 0;
        }
    }
    // Update is called once per frame
    void Update()
    {
        //check if there is a path
        if(path == null)
        return;

        //check for waypoints and if end is reached
        //if current # of waypoints is >= to # of waypoints 
        //on path then we reached the end
        if(currentWaypoint >= path.vectorPath.Count)
        {
            reachedEndPath = true;
            return;
        }
        else
        {
            reachedEndPath = false;
        }

        //get directions to next waypoint
        //current waypoint - current position 
        Vector2 direction = ((Vector2)path.vectorPath[currentWaypoint] - rb.position).normalized;

        //force to move enemy in the direction
        Vector2 force = direction * speed * Time.deltaTime;

        //force for our enemy
        rb.AddForce(force);

        //distance to next waypoint
        float distance = Vector2.Distance(rb.position, path.vectorPath[currentWaypoint]);

        //checks to see if we have reached the waypoint
        if(distance < nextWaypointD)
        {
            currentWaypoint++;
        }

    }   
}
