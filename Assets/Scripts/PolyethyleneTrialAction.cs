using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class PolyethyleneTrialAction : MonoBehaviour, InsertAction
{
    public string ActionName { get; set; }
    public GameObject ActionNode { get; set; }

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
        // SetInsertPrefab("Lesson7/Stage2/Action0/Polyethylene",
        //                 "Lesson7/Stage2/Action0/PolyethyleneFinal");
        // SetHoloObject(""Lesson7/Stage2/Action0/Hologram/HologramL7S2A0");

        //  base.Initialize();
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
        throw new System.NotImplementedException();
    }
}

