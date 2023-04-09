```java
import java.util.Scanner;

public class Main {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        System.out.println("Enter two numbers: ");
        int num1 = scanner.nextInt();
        int num2 = scanner.nextInt();
        System.out.println("GCD of " + num1 +" and " + num2 + " is " + gcd(num1, num2));
        System.out.println("LCM of " + num1 +" and " + num2 + " is " + lcm(num1, num2));
    }

    static int gcd(int num1, int num2) {
        if (num2 == 0) {
            return num1;
        }
        return gcd(num2, num1 % num2);
    }

    static int lcm(int num1, int num2) {
        return (num1 * num2) / gcd(num1, num2);
    }
}
```