using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZoneLevel3 : MonoBehaviour
{
    private LevelManager _levelManager;


    // Start is called before the first frame update
    void Start()
    {
        _levelManager = LevelManager.Instance;
    }


 private void OnTriggerEnter(Collider other)
 {
   _levelManager.LoadAsyncScene(LevelManager.Scene.Salle3);
 }
}
