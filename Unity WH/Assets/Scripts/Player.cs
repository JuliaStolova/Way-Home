using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public Vector3 position;
    public Vector3 rotation;
    // Method to save player data
    public void SavePlayer()
    {
        SaveSystem.SavePlayer(this);
    }

    // Method to load player data
    public void LoadPlayer()
    {
        PlayerData data = SaveSystem.LoadPLayer();
        if (data != null)
        {
            position = new Vector3(data.position[0], data.position[1], data.position[2]);
            rotation = new Vector3(data.rotation[0], data.rotation[1], data.rotation[2]);
            transform.position = position;
            transform.rotation = Quaternion.Euler(rotation);
        }
        else
        {
            Debug.LogError("No player data found to load.");
        }
    }
}
