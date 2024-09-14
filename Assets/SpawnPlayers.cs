using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;

public class SpawnPlayers : MonoBehaviour
{
 public GameObject playerPrefab;

 public float minX;
 public float maxX;
 public float minY;
 public float minZ;
 public float maxZ;

 void Start()
 {
 	Vector3 position = new Vector3(Random.Range(minX,maxX), minY,Random.Range(minZ,maxZ));
 	PhotonNetwork.Instantiate(playerPrefab.name,position,Quaternion.identity);
 }
 
}
