using Unity.Netcode;
using UnityEngine;

public class CameraController : NetworkBehaviour
{
    public GameObject playerCamera; 

    public override void OnNetworkSpawn()
    {
        if (IsOwner)
        {
            playerCamera.SetActive(true); 
        }
        else
        {
            playerCamera.SetActive(false);
        }
    }
}
