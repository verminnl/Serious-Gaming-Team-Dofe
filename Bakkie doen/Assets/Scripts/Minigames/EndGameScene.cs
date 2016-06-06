﻿using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// Manages the data on the scene that appears at the end of the game
/// </summary>
public class EndGameScene : MonoBehaviour {
    //Farewell text box of screen
    public Text textBox;
    //Name box of the NPC
    public Text npcNameBox;
    //Sprite of the NPC
    public Image npcSprite;
    //Skills box of the NPC
    public Text npcSkillsBox;
    //Card image
    public GameObject card;
    //Check if the screen is active
    private bool isActive;
    //Local avatardata to set endgame screen
    private AvatarData foundPlayer;

	// Use this for initialization
	void Start () {
        foundPlayer = DataTracking.currentNPC == null ? DataTracking.randomNPC : DataTracking.currentNPC;
        npcNameBox.text = foundPlayer.FullName;
        npcSprite.sprite = foundPlayer.NPCSprite;
        textBox.text = textBox.text + DataTracking.playerData.FirstName;
        if(foundPlayer.Element == "blue")
        {
            card.GetComponent<Image>().sprite = Resources.Load<Sprite>("cardW basis");
        }
        npcSkillsBox.text = foundPlayer.Skill1 + "\n" + foundPlayer.Skill2 + "\n";
        if (foundPlayer.Skill3 != null)
        {
            npcSkillsBox.text = npcSkillsBox.text + foundPlayer.Skill3 + "\n";
        }
	}
	
	// Update is called once per frame
	void Update () {
        if (isActive)
        {
            if (Input.GetKeyUp(KeyCode.Space))
            {
                BackEndCommunicator.Instance.EndGameSave(DataTracking.playerData.PlayerID, foundPlayer.PlayerID, DataTracking.playerData.SessionID, DataTracking.playerData.SpawnPoint, DataTracking.playerData.Tutorial);
                DataTracking.resetGame();
            }
        }
	}

    /// <summary>
    /// Activates this screen
    /// </summary>
    public void ActivateScreen()
    {
        gameObject.SetActive(true);
        isActive = true;
    }
}
