public static class Priority {
    public static void Test() {
        // TODO Problem 2 - Write and run test cases and fix the code to match requirements
        // Example of creating and using the priority queue
        var priorityQueue = new PriorityQueue();
        Console.WriteLine(priorityQueue);

        // Test Cases

        // Test 1
        // Scenario: 
        // Expected Result: 
        Console.WriteLine("Test 1");
            Console.WriteLine("Test 1");
        priorityQueue.Enqueue("Low", 1);
        priorityQueue.Enqueue("Medium", 2);
        priorityQueue.Enqueue("High", 3);
        Console.WriteLine(priorityQueue.Dequeue() == "High" ? "Pass" : "Fail"); // Should return "High"
        Console.WriteLine(priorityQueue.Dequeue() == "Medium" ? "Pass" : "Fail"); // Should return "Medium"
        Console.WriteLine(priorityQueue.Dequeue() == "Low" ? "Pass" : "Fail"); // Should return "Low"
        Console.WriteLine("---------");
        // Defect(s) Found: 

        Console.WriteLine("---------");

        // Test 2
        // Scenario: 
        // Expected Result: 
        Console.WriteLine("Test 2");
        // Scenario: Enqueue items with the same priority and dequeue them
        // Expected Result: Dequeue should return items in FIFO order when priorities are the same
        Console.WriteLine("Test 2");
        priorityQueue.Enqueue("First", 1);
        priorityQueue.Enqueue("Second", 1);
        priorityQueue.Enqueue("Third", 1);
        Console.WriteLine(priorityQueue.Dequeue() == "First" ? "Pass" : "Fail"); // Should return "First"
        Console.WriteLine(priorityQueue.Dequeue() == "Second" ? "Pass" : "Fail"); // Should return "Second"
        Console.WriteLine(priorityQueue.Dequeue() == "Third" ? "Pass" : "Fail"); // Should return "Third"
        Console.WriteLine("---------");

        // Defect(s) Found: 

        Console.WriteLine("---------");

        // Add more Test Cases As Needed Below
    }
}