using UnityEngine;

public class PilotView 
{
    private const float FORCE = 270.0f;
    private GameObject _prefab;
    private Rigidbody _physics;
    public GameObject Prefab => _prefab;
    public Rigidbody Physics => _physics;
    public PilotView(GameObject prefab, Rigidbody physics)
    {
        _prefab = prefab;
        _physics = physics;
    }
    public void TakeOff()
    {
        _physics.AddForce(0.0f,FORCE,0.0f);
    }
}
