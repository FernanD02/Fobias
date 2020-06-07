using System.Collections;
using System.Collections.Generic;
using Photon.Pun;
using UnityEngine;

public class NetworkSpawnManager : MonoBehaviour
{
    public GameObject playerPrefab;
    public CheckDevice device;
    public GameObject control;
    // Start is called before the first frame update
    void Start()
    {
        SpawnPlayer();
    }

    void SpawnPlayer()
    {
        if (device.window == true)
        {
            PhotonNetwork.Instantiate(playerPrefab.name, Vector3.zero, Quaternion.identity);
        }
        else if (device.andr == true)
        {
            PhotonNetwork.Instantiate(control.name, Vector3.zero, Quaternion.identity);
        }
        //if (Application.platform == RuntimePlatform.WindowsEditor)
        //{
        //    PhotonNetwork.Instantiate(playerPrefab.name, Vector3.zero, Quaternion.identity);
        //}
        //if (Application.platform == RuntimePlatform.WindowsPlayer)
        //{
        //    PhotonNetwork.Instantiate(control.name, Vector3.zero, Quaternion.identity);
        //}
    }
    
}
