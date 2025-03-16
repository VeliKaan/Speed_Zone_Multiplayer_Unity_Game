using Unity.Netcode;
using UnityEngine;
using UnityEngine.UI;

public class NetcodeUI : MonoBehaviour
{
    [SerializeField] private Button StartServerButton;
    [SerializeField] private Button StartClientButton;
    [SerializeField] public GameObject Menu;
    [SerializeField] public Camera MainCamera;


    private void Awake()
    {
        StartServerButton.onClick.AddListener(() =>
        {
            NetworkManager.Singleton.StartHost();
            Menu.SetActive(false);
            MainCamera.gameObject.SetActive(false);
        });

        StartClientButton.onClick.AddListener(() =>
        {
            NetworkManager.Singleton.StartClient();
            Menu.SetActive(false);
            MainCamera.gameObject.SetActive(false);
        });
    }
} 

