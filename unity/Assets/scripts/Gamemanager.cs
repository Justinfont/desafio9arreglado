using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gamemanager : MonoBehaviour
{
    private static int score;
    public static int Score { get => score; set => score = value;}

    public Gamemanager instance;
    // Start is called before the first frame update
    void Start()
    {
    Awake();    
    }

    // Update is called once per frame
    void Update()
    {
    
    }

      private void Awake()

  {

    if (instance == null)
    {
      instance = this;
      Debug.Log(instance);
      DontDestroyOnLoad(gameObject);
      score = 0;
    }
  }
  
}
