using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;
using Photon.Realtime;

public class Connection : MonoBehaviourPunCallbacks
{
    public GameObject ConnectedPanel;
    public GameObject DisconnectedPanel;
    public GameObject ConnectedButton;
    public GameObject LoadingButton;

    public void OnClick_ConnectButton()
    {
        PhotonNetwork.ConnectUsingSettings();
        ConnectedButton.SetActive(false);
        LoadingButton.SetActive(true);
    }

    public override void OnConnectedToMaster()
    {
        PhotonNetwork.JoinLobby(TypedLobby.Default);
    }

    public override void OnDisconnected(DisconnectCause cause)
    {
        DisconnectedPanel.SetActive(true);
    }

    public override void OnJoinedLobby()
    {
        if(DisconnectedPanel.activeSelf)
            DisconnectedPanel.SetActive(false);

        ConnectedPanel.SetActive(true);
    }
    
}
