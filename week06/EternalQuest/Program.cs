using System;

// =======================================================================================
// CREATIVITY AND EXCEEDING REQUIREMENTS REPORT:
// 1. Added a Dynamic Leveling/RPG Rank System inside GoalManager.cs. The user levels up 
//    for every 1000 points earned and unlocks custom titles (e.g., Level 13 Ninja Unicorn).
// 2. Implemented an entirely new Goal Subclass called "NegativeGoal" to track and penalize 
//    bad habits. When a user records a negative goal event, points are safely subtracted 
//    from their score, adding a high stakes risk/reward balance to the gamification.
// =======================================================================================

class Program
{
    static void Main(string[] args)
    {
        GoalManager manager = new GoalManager();
        manager.Start();
    }
}