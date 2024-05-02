public static class Priority
{
    public static void Test()
    {
        // TODO Problem 2 - Write and run test cases and fix the code to match requirements
        // Example of creating and using the priority queue
        var priorityQueue = new PriorityQueue();
        Console.WriteLine(priorityQueue);

        // Test Cases

        // Test 1
        // Scenario: Enqueue multiple items with same priority and dequeue
        // Expected Result: Bob, Tim, Sue
        Console.WriteLine("Test 1");
        priorityQueue.Enqueue("Bob", 5);
        priorityQueue.Enqueue("Tim", 5);
        priorityQueue.Enqueue("Sue", 5);
        Console.WriteLine(priorityQueue.Dequeue());
        Console.WriteLine(priorityQueue.Dequeue());
        Console.WriteLine(priorityQueue.Dequeue());


        // Defect(s) Found: 

        Console.WriteLine("---------");

        // Test 2
        // Scenario: Enqueue multiple names with diffrent priorities and dequeue them.
        //            Tim(2), Sue(3), Sam(1), Will(4)
        // Expected Result: Sam, Tim, Sue, Will.
        Console.WriteLine("Test 2");
        priorityQueue.Enqueue("Tim", 2);
        priorityQueue.Enqueue("Sue", 3);
        priorityQueue.Enqueue("Sam", 1);
        priorityQueue.Enqueue("Will", 4);
        Console.WriteLine(priorityQueue.Dequeue());
        Console.WriteLine(priorityQueue.Dequeue());
        Console.WriteLine(priorityQueue.Dequeue());
        Console.WriteLine(priorityQueue.Dequeue());

        // Defect(s) Found: 

        Console.WriteLine("---------");

        // Test 3
        // Scenario: Enqueue multiple names with diffrent and the same priorities and dequeue them.
        //           Tim(2), Sue(3), Sam(1), Will(4), Bob(1), Luke(3)
        // Expected Result: Sam, Bob, Tim, Sue, Will, Luke.
        Console.WriteLine("Test 3");
        priorityQueue.Enqueue("Tim", 2);
        priorityQueue.Enqueue("Sue", 3);
        priorityQueue.Enqueue("Sam", 1);
        priorityQueue.Enqueue("Will", 3);
        priorityQueue.Enqueue("Bob", 1);
        priorityQueue.Enqueue("Luke", 4);

        Console.WriteLine(priorityQueue.Dequeue());
        Console.WriteLine(priorityQueue.Dequeue());
        Console.WriteLine(priorityQueue.Dequeue());
        Console.WriteLine(priorityQueue.Dequeue());
        Console.WriteLine(priorityQueue.Dequeue());
        Console.WriteLine(priorityQueue.Dequeue());


        Console.WriteLine("---------");

        // Test 4
        // Scenario: Try to get the next person from a empty queue
        // Expected Result: Error message should display
        Console.WriteLine("Test 4");

        Console.WriteLine(priorityQueue.Dequeue());

        Console.WriteLine("---------");

        // Add more Test Cases As Needed Below
    }
}