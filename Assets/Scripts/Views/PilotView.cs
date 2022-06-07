using UnityEngine;

public class PilotView 
{
    private const float FORCE = 400.0f;
    private GameObject _prefab;
    private Rigidbody _physics;
    public GameObject Prefab => _prefab;
    public Rigidbody Physics => _physics;
    public PilotView(GameObject prefab)
    {
        _prefab = prefab;
        _physics = prefab.GetComponent<Rigidbody>();
    }
    public void TakeOff()
    {        
        _physics.AddForce(0.0f,FORCE,0.0f);
    }
}
