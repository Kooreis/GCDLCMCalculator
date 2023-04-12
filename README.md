# Python Documentation

# Python GCD and LCM Calculator

This Python script provides a simple command-line interface for calculating the Greatest Common Divisor (GCD) and Least Common Multiple (LCM) of two numbers.

## Script Description

The script contains two main functions: `gcd(a,b)` and `lcm(a,b)`. 

- `gcd(a,b)` calculates the greatest common divisor of two numbers using the Euclidean algorithm. This is a recursive function that uses the modulo operation to find the GCD.

- `lcm(a,b)` calculates the least common multiple of two numbers using the formula `lcm(a, b) = abs(a*b) / gcd(a, b)`. The GCD is calculated using the `gcd(a,b)` function.

The script runs in an infinite loop, presenting the user with three options:

1. Calculate the GCD of two numbers.
2. Calculate the LCM of two numbers.
3. Exit the program.

The user is prompted to enter their choice, and if they choose to calculate the GCD or LCM, they are then prompted to enter the two numbers. The result is then printed to the console.

## Libraries Used

This script does not import any external libraries. It only uses built-in Python functions and operators.

## How to Run

To run this script, simply execute it in a Python environment. You will be prompted to enter your choice of operation and the numbers to operate on. To exit the program, enter `3` when prompted for your choice.

## Example

Here is an example of how to use the script:

```
1. GCD
2. LCM
3. Exit
Enter your choice: 1
Enter first number: 36
Enter second number: 24
GCD of 36 and 24 is 12
```

This example calculates the GCD of 36 and 24, which is 12.

---

# C# Documentation

# CSharp GCD and LCM Calculator

This C# script is a simple console application that calculates the Greatest Common Divisor (GCD) and the Least Common Multiple (LCM) of two numbers entered by the user.

## Script Description

The script starts by asking the user to input two numbers. It then calculates the GCD and LCM of these numbers using the Euclidean algorithm and a simple formula, respectively. The results are then displayed on the console.

Here is a brief explanation of the main components of the script:

- `Main` method: This is the entry point of the application. It handles user input and output, and calls the GCD and LCM calculation methods.

- `GCD` method: This method calculates the GCD of two numbers using the Euclidean algorithm. It is a recursive method that keeps calling itself until the second number becomes 0, at which point it returns the first number as the GCD.

- `LCM` method: This method calculates the LCM of two numbers using the formula `a * b = GCD(a, b) * LCM(a, b)`. It calls the `GCD` method to perform the calculation.

## Imported Libraries

The script uses the following library:

- `System`: This is a built-in .NET library that provides fundamental classes and base classes that define commonly-used value and reference data types, events and event handlers, interfaces, attributes, and processing exceptions. In this script, it is used for console input/output and parsing integers.

## Usage

To run the script, you need a C# compiler such as the one provided by .NET SDK. Once you have it installed, you can compile the script using the `csc` command and then run the resulting executable:

```bash
csc Program.cs
./Program.exe
```

You will then be prompted to enter two numbers, and the script will display their GCD and LCM.

---

# Java Documentation

# Java GCD and LCM Calculator

This Java script is a simple console-based application that calculates the Greatest Common Divisor (GCD) and the Least Common Multiple (LCM) of two numbers entered by the user.

## Script Description

The script first prompts the user to enter two numbers. It then calculates and displays the GCD and LCM of the entered numbers.

The GCD of two numbers is the largest number that divides both of them without leaving a remainder. The LCM of two numbers is the smallest number that is a multiple of both.

## Code Breakdown

The script is composed of a main method and two helper methods: `gcd()` and `lcm()`.

### Main Method

The main method is the entry point of the script. It creates a `Scanner` object to read the user's input, prompts the user to enter two numbers, and then calls the `gcd()` and `lcm()` methods to calculate and display the GCD and LCM of the entered numbers.

### gcd() Method

The `gcd()` method calculates the GCD of two numbers using the Euclidean algorithm. The Euclidean algorithm is a way to find the greatest common divisor of two numbers by dividing the larger number by the smaller number and then replacing the larger number with the remainder until the remainder is zero. The GCD is the last non-zero remainder.

### lcm() Method

The `lcm()` method calculates the LCM of two numbers using the formula `lcm(a, b) = (a * b) / gcd(a, b)`. This formula works because the product of two numbers is equal to the product of their LCM and GCD.

## Imported Libraries

The script imports the `java.util.Scanner` class from the Java Standard Library. The `Scanner` class is a simple text scanner which can parse primitive types and strings. It is used in this script to read the user's input from the console.

---
