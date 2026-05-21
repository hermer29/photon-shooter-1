using System.Collections.Generic;
using ExitGames.Client.Photon;
using Photon.Realtime;

namespace LobbyLayer
{
    public partial class Matchmaking
    {
        public void OnPlayerEnteredRoom(Player newPlayer)
        {
            
        }

        public void OnPlayerLeftRoom(Player otherPlayer)
        {
        }

        public void OnRoomPropertiesUpdate(Hashtable propertiesThatChanged)
        {
        }

        public void OnPlayerPropertiesUpdate(Player targetPlayer, Hashtable changedProps)
        {
        }

        public void OnMasterClientSwitched(Player newMasterClient)
        {
        }

        public void OnFriendListUpdate(List<FriendInfo> friendList)
        {
        }

        public void OnCreatedRoom()
        {
        }

        public void OnCreateRoomFailed(short returnCode, string message)
        {
        }

        public void OnJoinRoomFailed(short returnCode, string message)
        {
        }

        public void OnJoinRandomFailed(short returnCode, string message)
        {
        }

        public void OnLeftRoom()
        {
        }
    }
}