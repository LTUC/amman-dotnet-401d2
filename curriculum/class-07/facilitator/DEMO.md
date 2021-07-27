# Demos: Interfaces

Note: Demos as they exist in the `/demo` folder are provided in their **completed** state.

This demo feels like a lecture and is a lot of the "Resource" material repeated. It's important to use this sequence to solidify the core OOP concepts in an organized fashion, by building it out during lecture.

## Interfaces

1. Start Demo by creating the Person Class
2. Then create the Student and Employee. Use this opportunity to review the OOP principles

3. Create an Interface named IDrive. Implement it onto the Employee class. This will require that the employee implement all of the method signatures that live in the interface. This is our "contract" that the interface makes with the compiler.

4. Now implement the IDrive interface onto the Robot class..because Robots can drive now.

5. There is no relationship between Robot and Employee..but now both can drive!

6. Create a method in the Program class that accepts IDrive as a parameter. Now Employee and Robot can be accepted into it.

7. Create a new interface named IDrivable that make it implemented onto another few classes such as Boat and Airplane

8. Now both a boat and an airplane are drivable....

9. Let's make Robot Drivable too...to show that we can make a class have more than one interface attached to it...

10. Finally, make a new method in Employee to allow for anything that is IDrivable
