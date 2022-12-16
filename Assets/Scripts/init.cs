using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class init : MonoBehaviour, InsertAction
{
    public string ActionName { get => throw new System.NotImplementedException(); set => throw new System.NotImplementedException(); }
    public GameObject ActionNode { get => throw new System.NotImplementedException(); set => throw new System.NotImplementedException(); }

    public void DestroyAction()
    {
        throw new System.NotImplementedException();
    }

    public void DifficultyRestrictions()
    {
        throw new System.NotImplementedException();
    }

    public void Initialize()
    {
        print("hello");
    }

    public void InitializeHolograms()
    {
        throw new System.NotImplementedException();
    }

    public void Perform()
    {
        throw new System.NotImplementedException();
    }

    public void SetNextModule(Action action)
    {
        throw new System.NotImplementedException();
    }

    public void Undo()
    {
        print("indo");
    }

    // Start is called before the first frame update
    void Start()
    {
        Initialize();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            Undo();
        }
    }
}
