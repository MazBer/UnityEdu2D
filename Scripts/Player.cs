using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public static Player Instance;
    
    // string int float bool
    public bool isActive = true;
    public string name = "Mark";
    private int _id = 42;
    
    public float speed = 5.0f;
    
    public string[] namesArray = {"Alice", "Bob", "Charlie"};
    public List<string> namesList = new List<string>();

    private void Awake()
    {
        if (Instance != null && Instance != this)
        {
            Destroy(gameObject);
        }
        else
        {
            DontDestroyOnLoad(gameObject);
            Instance = this;
        }
    }
    
    private void PrintInfo()
    {
        Debug.Log($"Player Name: {name}, Player ID: {_id}");
    }

    private string FullName()
    {
        return name + "_" + _id; // Steven_42
    }

    private void Start()
    {
        if (isActive)
        {
            PrintInfo();
            Debug.Log("Full Name: " + FullName());
        }
        
        //Ders3();
    }

    private void Update()
    {
        //Movement();
        //Ders3();
    }

    private void Ders3()
    {
        float num1 = 15f;
        float num2 = 5f;
        string metin = "Hello";
        if (metin == "Merhaba")
        {
            Debug.Log("Koşul çalıştı.");
        }
        else if (num1 < num2)
        {
            Debug.Log("İkinci koşul çalıştı.");
        }
        else
        {
            Debug.Log("Hiçbiri çalışmadı.");
        }

        switch (num1)
        {
            case 1:
                Debug.Log("Numara 1");
                break;
            case 5:
                Debug.Log("Numara 5");
                break;
            case 10:
                Debug.Log("Numara 10");
                break;
            default:
                Debug.Log("Hiçbiri değil");
                break;
        }

        while (num1 > 10f)
        {
            num1 -= 1f;
            Debug.Log("WHILE: " + num1);
        }
        
        for (int i = 0; i < 8; i++)
        {
            Debug.Log("FOR: " + i);
        }

        foreach (var name in namesArray)
        {
            Debug.Log(name);
        }

        for (int i = 0; i < namesArray.Length; i++)
        {
            Debug.Log(namesArray[i]);
        }
    }

    private void Movement()
    {
        float x = Input.GetAxis("Horizontal") * speed * Time.deltaTime;
        float y = Input.GetAxis("Vertical") * speed * Time.deltaTime;
        
        transform.position += new Vector3(x, y, 0);
    }
}
