using Photon.Pun;
using UnityEngine;

namespace GameplayLayer.Game.Views
{
    public class PlayerView : MonoBehaviour
    {
        [SerializeField] Camera _camera;
        [SerializeField] PhotonView _photonView;
        
        public Camera Camera => _camera;
        public PhotonView PhotonView => _photonView;
        public Transform Transform => transform;

        public void SetLocal(bool isLocal)
        {
            if(_camera != null)
                _camera.gameObject.SetActive(isLocal);
        }
    }
}