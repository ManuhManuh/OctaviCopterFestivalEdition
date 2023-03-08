using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelManager : MonoBehaviour
{
    public enum LevelState
    {
        SelectingMission,
        SeekingNote,
        CheckingNote,
        MissionComplete
    }

    private LevelState currentState;
    public LevelState CurrentState
    {
        get { return currentState;  }
    }

    private bool firstNoteFound = false;
    private bool secondNoteFound = false;
    private bool thirdNoteFound = false;
    private string latestNoteCollected;

    public void OnNoteCollected(string noteName)
    {
        // update state to CheckingNote
        // update latestNoteCollected
    }
    public void OnStateEntered(LevelState state)
    {
        switch (state)
        {
            case LevelState.SelectingMission:
                // Select the new mission
                // Display the mission in the UI
                // Play the mission notes and display the mission note hints
                break;
            case LevelState.SeekingNote:
                // Display the scale column (move in front of the player)
                break;
            case LevelState.CheckingNote:
                // Hide the scale column 
                break;
            case LevelState.MissionComplete:
                // Display mission complete message
                // Reset if required
                break;
        }
    }

    public void Update()
    {
        switch (currentState)
        {
            case LevelState.SelectingMission:
                break;
            case LevelState.SeekingNote:
                break;
            case LevelState.CheckingNote:
                break;
            case LevelState.MissionComplete:
                break;
        }

    }

    public void OnStateExited(LevelState state)
    {
        switch (state)
        {
            case LevelState.SelectingMission:
                break;
            case LevelState.SeekingNote:
                break;
            case LevelState.CheckingNote:
                break;
            case LevelState.MissionComplete:
                break;
        }
    }
}
