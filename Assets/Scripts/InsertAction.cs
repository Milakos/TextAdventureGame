using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface InsertAction
{
    /// <summary>
    /// GameObject.name
    /// </summary>
    string ActionName
    {
        set;
        get;
    }

    /// <summary>
    /// The Gameobject refering to the current Action in Unity
    /// This implements the core of unity's scenegraph.
    /// </summary>
    GameObject ActionNode
    {
        set;
        get;
    }

    /// <summary>
    /// Go to Next Action
    /// Completes the current Action by finilizing and cleaning it
    /// Destroys prefabs, holograms
    /// Also plays animations to set the next one
    /// </summary>
    void Perform();

    /// <summary>
    /// Go to Previous Action
    /// Resets current Action by finilizing and cleaning it
    /// Destroys prefabs, holograms
    /// Plays Undo animations
    /// </summary>
    void Undo();

    /// <summary>
    /// Initialize current Action by spawning the necessary prefabs
    /// Sets each Action properties to run correctly
    /// </summary>
    void Initialize();

    /// <summary>
    /// Sets Holograms for current Action depending on the difficulty
    /// </summary>
    void InitializeHolograms();

    /// <summary>
    /// Sest the difficulty/error colliders for the current Action depending on the difficulty
    /// </summary>
    void DifficultyRestrictions();

    /// <summary>
    /// Destroys the current Action, what is spawned from the Action it gets destroyed
    /// </summary>
    void DestroyAction();

    /// <summary>
    /// Used only for Combined Actions
    /// Sets the next sub-Action to run after Performing the current one
    /// </summary>
    /// <param name="action">The next Action to run</param>
    void SetNextModule(Action action);
}