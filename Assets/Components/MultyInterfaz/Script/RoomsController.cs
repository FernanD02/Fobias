using System.Collections;
using System.Collections.Generic;
using Photon.Pun;
using Photon.Realtime;
using UnityEngine;
using UnityEngine.UI;

public class RoomsController : MonoBehaviourPunCallbacks
{
    public InputField CreateRoom;
    public InputField JoinRoom;

    public void OnClick_JoinRoom()
    {
        PhotonNetwork.JoinRoom(JoinRoom.text, null);
    }

    public void OnClick_CreateRoom()
    {
        PhotonNetwork.CreateRoom(CreateRoom.text, new RoomOptions {MaxPlayers = 2}, null);
        
    }

    public override void OnJoinedRoom()
    {
        Debug.Log("Room Joined Sucess");
        PhotonNetwork.LoadLevel(1);
    }

    public override void OnJoinRoomFailed(short returnCode, string message)
    {
        Debug.Log("RoomFailed " + returnCode + " Message " + message);
    }
    
}
