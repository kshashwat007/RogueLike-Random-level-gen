using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnRooms : MonoBehaviour {

    public LayerMask whatIsMask;
    public LevelGeneration levelGen;

	void Update () {
        Collider2D roomDetection = Physics2D.OverlapCircle(transform.position, 1, whatIsMask);
        if(roomDetection == null && levelGen.stopGeneration == true)
        {
            int rand = Random.Range(0, levelGen.rooms.Length);
            Instantiate(levelGen.rooms[rand], transform.position, Quaternion.identity);
            Destroy(gameObject);
        }
	}
}
