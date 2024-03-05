public static class Priority {
    public static void Test() {
        // TODO Problem 2 - Write and run test cases and fix the code to match requirements
        // Example of creating and using the priority queue
        var priorityQueue = new PriorityQueue();
        Console.WriteLine(priorityQueue);

        // Test Cases

        // Test 1
        // Scenario: 
        Console.WriteLine("Test 1");
        priorityQueue.Enqueue("D", 23);
        priorityQueue.Enqueue("A", 26);
        priorityQueue.Enqueue("W", 4);
        Console.WriteLine(priorityQueue.Dequeue());
        Console.WriteLine(priorityQueue.Dequeue());
        priorityQueue.Enqueue("G", 20);
        priorityQueue.Enqueue("B", 25);
        Console.WriteLine(priorityQueue.Dequeue());
        priorityQueue.Enqueue("H", 19);
        Console.WriteLine(priorityQueue.Dequeue());
        Console.WriteLine(priorityQueue.Dequeue());
        Console.WriteLine(priorityQueue.Dequeue());
        // Expected Result: A D B G H W 

        // Defect(s) Found: 
        // does not remove elements
        // does not always dequeue element with highest priority

        Console.WriteLine("---------");

        // Test 2
        // Scenario: 
        Console.WriteLine("Test 2");
        priorityQueue.Enqueue("D", 23);
        priorityQueue.Enqueue("E", 22);
        priorityQueue.Enqueue("A", 26);
        priorityQueue.Enqueue("D2", 23);
        priorityQueue.Enqueue("E2", 22);
        Console.WriteLine(priorityQueue.Dequeue());
        priorityQueue.Enqueue("E3", 22);
        Console.WriteLine(priorityQueue.Dequeue());
        priorityQueue.Enqueue("B", 25);
        Console.WriteLine(priorityQueue.Dequeue());
        Console.WriteLine(priorityQueue.Dequeue());
        Console.WriteLine(priorityQueue.Dequeue());
        Console.WriteLine(priorityQueue.Dequeue());
        Console.WriteLine(priorityQueue.Dequeue());
        // Expected Result: A D B D2 E E2 E3

        // Defect(s) Found: 
        // searches for first equalivent element in reverse order
        //  - solution: the >= was carrying the equalivent result to that at the end of the array, instead of the first

        Console.WriteLine("---------");

        // Add more Test Cases As Needed Below

        Console.WriteLine("Test 3");
        // should print error
        Console.WriteLine(priorityQueue.Dequeue());
        Console.WriteLine("---------");
    }
}