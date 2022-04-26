using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class StoreHighScore : MonoBehaviour
{
    public TextMeshProUGUI highScore;
    public static StoreHighScore Instance;
    // Start is called before the first frame update
    void Awake()
    {
        Instance = this;
        if(Instance != null)
        {
            Destroy(gameObject);
            return;
        }
        DontDestroyOnLoad(gameObject);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
