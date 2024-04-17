using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeModel : MonoBehaviour
{
    [SerializeField]
    public int designNumber;

    // get text mesh pro's text component
    [SerializeField]
    public TMPro.TextMeshProUGUI DesignTextComponent;
    
    private string DesignIndicatorText;

    // create a game object reference on the first design
    [SerializeField]
    public GameObject Design0;
    [SerializeField]
    public GameObject Design1;
    [SerializeField]
    public GameObject Design2;
    [SerializeField]
    public GameObject Design3;
    [SerializeField]
    public GameObject Design4;
    [SerializeField]
    public GameObject Design5_1;
    [SerializeField]
    public GameObject Design5_2;
    [SerializeField]
    public GameObject Design5_3;
    [SerializeField]
    public GameObject Design6;
    [SerializeField]
    public GameObject Design7;
    [SerializeField]
    public GameObject Design8;
    [SerializeField]
    public GameObject Design9;

    // Start is called before the first frame update
    void Start()
    {
        HideAllDesigns();
        designNumber = 0;
    }

    // Update is called once per frame
    void Update()
    {
        DisplayDesign(designNumber);
    }

    public void NextDesign()
    {
        HideAllDesigns();
        designNumber++;
        if (designNumber > 9)
        {
            designNumber = 0;
        }
    }

    public void PreviousDesign()
    {
        HideAllDesigns();
        designNumber--;
        if (designNumber < 0)
        {
            designNumber = 9;
        }
    }

    public void ChooseDesign(int design)
    {
        HideAllDesigns();
        designNumber = design;
    }

    public void DisplayDesign(int design)
    {
        // Design Numbers and their corresponding designs:
        // 0) Baseline
        // 1) Eye Socket
        // 2) Near-Eye Blocks
        // 3) Glasses
        // 4) Near-Eye Hands
        // 5) Extended Blocks
        // 6) Blocks at Task
        // 7) Projected Lines
        // 8) Diminished Environment
        // 9) Dim Environment
        switch (designNumber)
        {
            case 0:
                DesignIndicatorText = "Design: 0 (Baseline)";
                Design0.SetActive(ToggleDesign(designNumber, 0));
                break;
            case 1:
                DesignIndicatorText = "Design: 1 (Eye Socket)";
                Design1.SetActive(ToggleDesign(designNumber, 1));
                break;
            case 2:
                DesignIndicatorText = "Design: 2 (Near-Eye Blocks)";
                Design2.SetActive(ToggleDesign(designNumber, 2));
                break;
            case 3:
                DesignIndicatorText = "Design: 3 (Glasses)";
                Design3.SetActive(ToggleDesign(designNumber, 3));
                break;
            case 4:
                DesignIndicatorText = "Design: 4 (Near-Eye Hands)";
                Design4.SetActive(ToggleDesign(designNumber, 4));
                break;
            case 5:
                DesignIndicatorText = "Design: 5 (Extended Blocks)";
                Design5_1.SetActive(ToggleDesign(designNumber, 5));
                Design5_2.SetActive(ToggleDesign(designNumber, 5));
                Design5_3.SetActive(ToggleDesign(designNumber, 5));
                break;
            case 6:
                DesignIndicatorText = "Design: 6 (Blocks at Task)";
                Design6.SetActive(ToggleDesign(designNumber, 6));
                break;
            case 7:
                DesignIndicatorText = "Design: 7 (Projected Lines)";
                Design7.SetActive(ToggleDesign(designNumber, 7));
                break;
            case 8:
                DesignIndicatorText = "Design: 8 (Diminished Environment)";
                Design8.SetActive(ToggleDesign(designNumber, 8));
                break;
            case 9:
                DesignIndicatorText = "Design: 9 (Dim Environment)";
                Design9.SetActive(ToggleDesign(designNumber, 9));
                break;
        }
        DesignTextComponent.text = DesignIndicatorText;
    }

    // if their number is the design number, return true, else return false
    public bool ToggleDesign(int CurrentDesign, int DesignToShow)
    {
        return CurrentDesign == DesignToShow;
    }

    // Hide all designs
    public void HideAllDesigns()
    {
        // Hide all designs first
        Design0.SetActive(false);
        Design1.SetActive(false);
        Design2.SetActive(false);
        Design3.SetActive(false);
        Design4.SetActive(false);
        Design5_1.SetActive(false);
        Design5_2.SetActive(false);
        Design5_3.SetActive(false);
        Design6.SetActive(false);
        Design7.SetActive(false);
        Design8.SetActive(false);
        Design9.SetActive(false);
    }
}