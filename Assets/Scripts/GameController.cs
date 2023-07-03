using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{
    [SerializeField] private MyRobot testRobot;
    [SerializeField] private Button InstructionButtonl1;
    [SerializeField] private Button InstructionButtonl2;

    private List<Icommand> instructions1 = new List<Icommand>();
    private List<Icommand> instructions2 = new List<Icommand>();

    // Start is called before the first frame update
    private void Start()
    { 
        InstructionButtonl1.onClick.AddListener(RunInstruction1);
        InstructionButtonl2.onClick.AddListener(RunInstruction2);

        //cashe instructions
        RegisterButtonsForInstruction1();
        RegisterButtonsForInstruction2();
    }


    private void RunInstruction1()
    {
        testRobot.ClearCommands();
        testRobot.RegisterCommands(instructions1);
        testRobot.StartActions();
    }   
    
    private void RunInstruction2()
    {
        testRobot.ClearCommands();
        testRobot.RegisterCommands(instructions2);
        testRobot.StartActions();
    }


    private void RegisterButtonsForInstruction1()
    {
        MoveCommand moveCommandRight = new MoveCommand(testRobot.transform, Vector3.forward, 1);
        RotateCommand rotateCommandRight = new RotateCommand(testRobot.transform, new Vector3(90, 0, 0), 1);
        MoveCommand moveCommand = new MoveCommand(testRobot.transform, new Vector3(1, 1, 0), 1);

        instructions1.Add(moveCommandRight);
        instructions1.Add(rotateCommandRight);
        instructions1.Add(moveCommand);
    } 
    
    private void RegisterButtonsForInstruction2()
    {
        RotateCommand moveCommandRight = new RotateCommand(testRobot.transform, new Vector3(45,45,45), 1);
        ColorChangeCommand rotateCommandRight = new ColorChangeCommand(testRobot.RendererComponent, Color.black, 0.1f);
        MoveCommand moveCommand = new MoveCommand(testRobot.transform, new Vector3(1, 1, 0), 1);

        instructions2.Add(moveCommandRight);
        instructions2.Add(rotateCommandRight);
        instructions2.Add(moveCommand);
    }

    private void OnDestroy()
    {
        InstructionButtonl1.onClick.RemoveAllListeners();
        InstructionButtonl2.onClick.RemoveAllListeners();
    }

}
