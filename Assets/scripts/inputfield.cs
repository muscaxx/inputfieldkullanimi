using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class inputfield : MonoBehaviour
{
    public TMP_InputField username;
    public TMP_InputField password;
    string username_st;
    string password_st;

    public void Ifield()
    {
        username_st = username.text;
        password_st = password.text;

        Debug.Log(username_st);
        Debug.Log(password_st);
    }
}
