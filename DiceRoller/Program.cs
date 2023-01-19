// Author: Alexander Black
// Description: A program that simulates a user-defined number of rolls of 2 dice.

using System;
using DiceRoller;

var simulator = new Roll();

// Gets initial user input 
Console.WriteLine("Welcome to the dice throwing simulator!");
Console.Write("How many dice rolls would you like to simulate? ");
var rollNum = Convert.ToInt32(Console.ReadLine());

simulator.SimulateRolls(rollNum);