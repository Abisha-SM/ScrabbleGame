using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class Loginmanager : MonoBehaviour
{
   
    public Button logoutBtn;

   
    private void OnEnable()
    {
        logoutBtn.onClick.AddListener(LogOutButtonClk);
    }

    private void Start()
    {
       
        if (FaceBookLogin.Instance.FBLoginbool == true)
        {
            FBSignIn();
        }
    }

   

    void FBSignIn()
    {
       // fProfilepic.gameObject.SetActive(true);
        //gProfilepic.gameObject.SetActive(false);
       // guestProfilepic.gameObject.SetActive(false);
       // Name = FaceBookLogin.Instance.Name;
       // userName.text = Name;
        //UserProfile2 = FaceBookLogin.Instance.fbProfilepicTexture;
       // fProfilepic.texture = UserProfile2;
    }

    

    public void LogOutButtonClk()
    {
       
        if (FaceBookLogin.Instance.FBLoginbool == true)
        {
            FaceBookLogin.Instance.LogOut();
        }
        
    }
}
