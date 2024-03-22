using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;


public class Wire : MonoBehaviour
{
    public Transform player;

    public LineRenderer rope;
    public LayerMask collMask;

    private bool CanUseWire = false;
    private bool IsWire = false;

    public List<Vector3> ropePositions { get; set; } = new List<Vector3>();

    private void Awake() => AddPosToRope(Vector3.zero);

    private void Update()
    {      
        if (CanUseWire == true)
        {
            UpdateRopePositions();
            LastSegmentGoToPlayerPos();

            DetectCollisionEnter();
            if (ropePositions.Count > 2) DetectCollisionExits();
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "PointA")
        {
            if (IsWire == false)
            {
                IsWire = true;
                if (CanUseWire == false)
                {
                    CanUseWire = true;
                }
                return;
            }
        } 
        if (collision.gameObject.tag == "PointB")
        {
            if (CanUseWire == true)
            {
                IsWire = false;
                if (CanUseWire == true)
                {
                    CanUseWire = false;
                }
                return;
            }
        }
    }

    private void DetectCollisionEnter()
    {
        RaycastHit hit;
        if (Physics.Linecast(player.position, rope.GetPosition(ropePositions.Count - 2), out hit, collMask))
        {
            ropePositions.RemoveAt(ropePositions.Count - 1);
            AddPosToRope(hit.point);
        }
    }

    private void DetectCollisionExits()
    {
        RaycastHit hit;
        if (!Physics.Linecast(player.position, rope.GetPosition(ropePositions.Count - 3), out hit, collMask))
        {
            ropePositions.RemoveAt(ropePositions.Count - 2);
        }
    }

    private void AddPosToRope(Vector3 _pos)
    {
        ropePositions.Add(_pos);
        ropePositions.Add(player.position); //Always the last pos must be the player
    }

    private void UpdateRopePositions()
    {
        rope.positionCount = ropePositions.Count;
        rope.SetPositions(ropePositions.ToArray());
        
    }

    private void LastSegmentGoToPlayerPos()
    {
        rope.SetPosition(rope.positionCount - 1,new Vector3 (Mathf.RoundToInt(player.position.x), Mathf.RoundToInt(player.position.y), Mathf.RoundToInt(player.position.z)));
    } 
}
