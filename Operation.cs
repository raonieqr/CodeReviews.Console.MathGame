using System.ComponentModel;

public enum Operation
{
    [Description("Addition")]
    Addition = 1,

    [Description("Subtraction")]
    Subtraction = 2,

    [Description("Division")]
    Division = 3,

    [Description("Multiplication")]
    Multiplication = 4
}