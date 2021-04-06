using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PParticleSystem : MonoBehaviour
{
    
    public GameObject particleObject;
    // Start is called before the first frame update
    void Start()
    {
        particleObject.SetActive(false);
        
    }
   public void ParticleStart()
    {
        particleObject.SetActive(true);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
