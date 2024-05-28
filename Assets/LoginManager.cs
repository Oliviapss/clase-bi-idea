using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class LoginManager : MonoBehaviour
{
    public string contraseña;
    public InputField imputContraseña;

    public void ComoDesees()
    {
        if (imputContraseña.text == contraseña)
        {
            Debug.Log("Access granted");
        }
        else
        {
            Debug.Log("Access denied");
        }
    }
}
