using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using System.Linq;
using Nova;
using UnityEngine.InputSystem;

public class gamemaster : MonoBehaviour
{

	private const uint LeftMouseButtonID = 0;

	// In Unity's legacy input system, '0' is the button ID for the left mouse button.
	private const int LeftMouseButton = 0;

	// Start is called once before the first execution of Update after the MonoBehaviour is created
	void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

		ForwardInputToNova();
	}

    void ForwardInputToNova()
    {
		if (!Input.mousePresent)
		{
			// No mouse present, exit early.
			return;
		}

		/*** Create Interaction.Update from mouse event ***/

		// Convert the mouse position to a world-space ray.
		Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

		// Create a new Interaction.Update from the ray, and give it a control ID.
		Interaction.Update update = new Interaction.Update(ray, controlID: LeftMouseButtonID);

		// Is the left mouse button pressed?
		bool mousePressed = Input.GetMouseButton(LeftMouseButton);

		/*** Pass along to Nova's interaction system ***/

		// Call Nova's Interaction.Point method with the interaction update and button state.
		Interaction.Point(update, mousePressed);
	}
}
