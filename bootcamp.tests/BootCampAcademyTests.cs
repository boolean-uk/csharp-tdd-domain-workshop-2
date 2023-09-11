using bootcamp.console;

namespace bootcamp.tests;

public class Tests
{


    //1. As a student of the Academy I want to be able to add a specific course to my Learning Plan.
    [Test]
    public void AddCourseToLearningPlan()
    {
        //arrange
        BootCampAcademy academy = new BootCampAcademy();

        //act
        academy.LearningPlans.Add("C#");

        //assert
        Assert.IsTrue(1==academy.LearningPlans.Count);
    }

    //2. As a student of the Academy if I change my mind I want to be able to remove a course from my Learning Plan.
    [Test]
    public void RemoveCourseFromLearningPlan()
    {
        //arrange
        BootCampAcademy academy = new BootCampAcademy();        
        academy.LearningPlans.Add("C#");

        //act
        academy.LearningPlans.Remove("C#");

        //assert
        Assert.IsTrue(academy.LearningPlans.Any(lp => lp == "C#")==false);
    }
    //3. As a student of the Academy I'd like to know when my Learning plan is full, when I try to add another item (Course, Tutorial, Certification) to it.
    [Test]
    public void TestIfLearningPlanIsFull()
    {

        BootCampAcademy academy = new BootCampAcademy();
        
        Assert.IsTrue(academy.AddLearningPlan("C# Course"));
        academy.AddLearningPlan("C# Tutorial");
        academy.AddLearningPlan("C# Certification");



        Assert.IsTrue(academy.AddLearningPlan("C# Certification") == false);
);
   }
}