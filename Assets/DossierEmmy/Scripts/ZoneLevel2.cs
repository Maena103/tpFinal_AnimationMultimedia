using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZoneLevel2 : MonoBehaviour
{
    private LevelManager _levelManager;
  [SerializeField] private AudioSource _sonTeleportation;

    // Start is called before the first frame update
    void Start()
    {
        
        _levelManager = LevelManager.Instance;
    }


 private void OnTriggerEnter(Collider other)

 { 
    
  _sonTeleportation.Play();
    _levelManager.LoadAsyncScene(LevelManager.Scene.Salle2);
 }
}
