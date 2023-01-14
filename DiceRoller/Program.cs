// See https://aka.ms/new-console-template for more information

using System;
using DiceRoller;

var simulator = new Roll();

Console.WriteLine("Welcome to the dice throwing simulator!");
Console.WriteLine("How many dice rolls would you like to simulate?");
var rollNum = Convert.ToInt32(Console.ReadLine());

simulator.SimulateRolls(rollNum);