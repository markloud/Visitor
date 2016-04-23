using System;
using VisitorPattern;
using VisitorPattern.Elements;
using VisitorPattern.Visitors;

namespace DoFactory.GangOfFour.Visitor.RealWorld
{
    /// <summary>
    /// MainApp startup class for Real-World
    /// Visitor Design Pattern.
    /// </summary>
    internal class MainApp
    {
        /// <summary>
        /// Entry point into console application.
        /// </summary>
        private static void Main()
        {
            // Setup employee collection
            Employees e = new Employees();
            e.Attach(new Clerk());
            e.Attach(new Director());
            e.Attach(new President());

            // Employees are 'visited'
            e.Accept(new IncomeVisitor());
            e.Accept(new VacationVisitor());

            // Wait for user
            Console.ReadKey();
        }
    }
}