using UnityEngine;

public class VisibilidadBotones : MonoBehaviour
{ void Start()
    {
        gameObject.SetActive(Application.platform == RuntimePlatform.Android || Application.platform == RuntimePlatform.IPhonePlayer);
        
    }

   
}
