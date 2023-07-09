using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnitiEngine.SceneManagement;

public class ScriptMenu : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Jugar()
    {
        SceneManager.loadScene("SampleScene");
    }

    public void CreditosOn()
    {
        Creditos.SetActive(true);
    }

    public void CreditosOff()
    {
        Creditos.SetActive(false);
    }

    public void Salir()
    {
        Application.Quit();
    }
