using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UI.Text;
using System;
using System.Text.RegularExpressions;



public class FirebaseLogin : MonoBehaviour
{
   public GameObject loginPanel, signupPanel, profilePanel,forgetPasswordPanel, loginOnePanel, notificationPanel;

   public InputField loginEmail;
    public InputField loginPassword;
    public InputField signupEmail;
    public InputField signupPassword;
    public InputField signupCPassword;
    public InputField signupUserName;
    public InputField forgetPassEmail;
   

    public Text notif_Title_Text, show_notif_message;


   public void OpenLoginPanel()
   {
    loginPanel.SetActive(true);
    signupPanel.SetActive(false);
    profilePanel.SetActive(false);
    forgetPasswordPanel.SetActive(false);
    loginOnePanel.SetActive(false);

   }

    public void OpensignupLoginPanel()
    {
    loginPanel.SetActive(false);
    signupPanel.SetActive(true);
    profilePanel.SetActive(false);
    forgetPasswordPanel.SetActive(false);
    loginOnePanel.SetActive(false);
   }


    public void OpenprofileLoginPanel()
    {
    loginPanel.SetActive(false);
    signupPanel.SetActive(false);
    profilePanel.SetActive(true);
    forgetPasswordPanel.SetActive(false);
    loginOnePanel.SetActive(false);
   }

   
    public void OpenproForgetPassPanel()
    {
    loginPanel.SetActive(false);
    signupPanel.SetActive(false);
    profilePanel.SetActive(false);
    forgetPasswordPanel.SetActive(true);
    loginOnePanel.SetActive(false);
   }

    public void loginOne()
    {
    loginPanel.SetActive(false);
    signupPanel.SetActive(false);
    profilePanel.SetActive(false);
    forgetPasswordPanel.SetActive(false);
    loginOnePanel.SetActive(true);
   }


   

   public void LoginUser()
   {
    if(string.IsNullOrEmpty(loginEmail.text) && string.IsNullOrEmpty(loginPassword.text))
    {
         showNotificationMessage ("Error", "Field not be Empty");
        return;
    }
   }

    public void SignupUser()
    {
    if(string.IsNullOrEmpty(signupEmail.text) && string.IsNullOrEmpty(signupPassword.text) && string.IsNullOrEmpty(signupCPassword.text) && string.IsNullOrEmpty(signupUserName.text))
    {
         showNotificationMessage ("Error", "Field not be Empty");
        return;
    }
    }
    
    public void forgetPass()
   {
    if(string.IsNullOrEmpty(forgetPassEmail.text))
    {
        showNotificationMessage ("Error", "Forget Email Empty");
        return;
    }
    }

    private void showNotificationMessage(string title, string message)
   {
       notif_Title_Text = "" + title;
       notif_Message_Text = "" + message;

       notificationPanel.SetActive(true);

   }
   
   public void Close_NotifPanel(){
     notif_Title_Text = "";
       notif_Message_Text = "";

       notificationPanel.SetActive(false);

   }

  


}
