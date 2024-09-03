using Nova;
using UnityEngine;

public class popup : MonoBehaviour
{
	public UIBlock Root = null;
	UIBlock2D uiblock;

	// Start is called once before the first execution of Update after the MonoBehaviour is created
	void Start()
    {
		Root.AddGestureHandler<Gesture.OnClick>(Click);
		Root.AddGestureHandler<Gesture.OnHover>(OnHover);
		Root.AddGestureHandler<Gesture.OnUnhover>(OnUnhover);

		uiblock = GetComponent<UIBlock2D>();
	}

    // Update is called once per frame
    void Update()
    {
        
    }


	private void Click(Gesture.OnClick evt)
	{
		Debug.Log("Clicked popup!");
		uiblock.Size = new Length3(80, 80, 80);
	}

	private void OnHover(Gesture.OnHover evt)
	{
		
	}

	private void OnUnhover(Gesture.OnUnhover evt)
	{
		
	}
}
