using System.Collections;
using System.Collections.Generic;
using Photon.Pun;
using UnityEngine;
using UnityEngine.UI;

public class ColorTest : MonoBehaviourPunCallbacks
{
    private PhotonView PV;

    private GameObject[] cubes;

    public List<Button> botones;
    // Start is called before the first frame update
    void Start()
    {
        cubes = GameObject.FindGameObjectsWithTag("cube");
        PV = GetComponent<PhotonView>();
    }
    

    public void changecolor1()
    {
        if (PV.IsMine)
        {
            PV.RPC("ChangeColorazul", RpcTarget.All);
        }
    }
    public void changecolor2()
    {
        if (PV.IsMine)
        {
            PV.RPC("ChangeColorRojo", RpcTarget.All);
        }
    }
    public void changecolor3()
    {
        if (PV.IsMine)
        {
            PV.RPC("ChangeColorverde", RpcTarget.All);
        }
    }
    public void changecolor4()
    {
        if (PV.IsMine)
        {
            PV.RPC("ChangeColoramarillo", RpcTarget.All);
        }
    }

    [PunRPC]
    void ChangeColorazul()
    {
        foreach (GameObject cube in cubes)
        {
            cube.gameObject.GetComponent<Renderer>().material.color = Color.blue;
        }
    }

    [PunRPC]
    void ChangeColorRojo()
    {
        foreach (GameObject cube in cubes)
        {
            cube.gameObject.GetComponent<Renderer>().material.color = Color.red;
        }
    }

    [PunRPC]
    void ChangeColorverde()
    {
        foreach (GameObject cube in cubes)
        {
            cube.gameObject.GetComponent<Renderer>().material.color = Color.green;
        }
    }

    [PunRPC]
    void ChangeColoramarillo()
    {
        foreach (GameObject cube in cubes)
        {
            cube.gameObject.GetComponent<Renderer>().material.color = Color.yellow;
        }
    }

}
