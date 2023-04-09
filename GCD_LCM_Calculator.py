def gcd(a,b):
    if b==0:
        return a
    else:
        return gcd(b,a%b)

def lcm(a,b):
    return a*b//gcd(a,b)

while True:
    print("1. GCD")
    print("2. LCM")
    print("3. Exit")
    choice = int(input("Enter your choice: "))
    if choice == 1:
        num1 = int(input("Enter first number: "))
        num2 = int(input("Enter second number: "))
        print("GCD of", num1, "and", num2, "is", gcd(num1, num2))
    elif choice == 2:
        num1 = int(input("Enter first number: "))
        num2 = int(input("Enter second number: "))
        print("LCM of", num1, "and", num2, "is", lcm(num1, num2))
    elif choice == 3:
        break
    else:
        print("Invalid choice!!")