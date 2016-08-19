//: Playground - noun: a place where people can play

import UIKit

var str1 = "Hello, playground"
var num = 20

for(var i = 0; i < 10; i += 1){
    num += 10 * i
}

//constant
//"let" is used to define a constant, cannot be changed
let a = 3
//a += 3 
//fails

//Variable, can be modified
var b = 5
b += 3
//once the compiler associates a certain type with a variable, it's can't be changed later
// b = "text example"
//fails, because b is a integer

//Explict Typing
//Variable explictly typed as String, store the value later
var c : String

                                                //String
let myString = "part1" + "part2"

var str2 = "string"
str2 += " more"

let constant1 = "test1"
let constant2 = "test2"

let constant = constant1 + constant2

var numDays = 5
let stringNumDays = "5"

let toPrint = "There are \(numDays) days until the weekend"
//                       \(numbers)
let alternateToPrint = "There are " + stringNumDays + " days until the weekend"

//explict it is a string
//1. ""
let numString = "\(numDays)"
//2. 
let numString2 = String(numDays)

                                                //Array
//1. specify the array type
//   only has three array spots, myArray[100] = 10 fails
var myArray : [Int] = [3,5,7]
//2. first item in the array
myArray[0]
//3. change array
myArray[0] = 10
//4. second way to create array
var myArray2: [Int] = Array()
myArray2.append(5)

//5. store any type of array
var complexArray : [Any] = Array()

complexArray.append(3)
complexArray.append("String value")

//6. count array number
myArray.count

//7. remove array
myArray.removeAtIndex(0)

                                                //Dictionary
//create dictionary 1
var myDictionary = ["apple":"red","banana":"yellow"]
//create dictionary 2
var myDictionary2 : [String:Int] = Dictionary()
myDictionary2["key1"] = 4
myDictionary2["key2"] = 15

myDictionary2["key1"]

//create dictionary without specific type
var myDictionary3 : [String:Any] = Dictionary()

myDictionary3["key1"] = 3
myDictionary3["key2"] = "text string"

myDictionary3

                                                //Optionals

var c2 : Int?
//c2 may nil may not

c2 = 3
var d = c2! + 5
//!: force unwrapping

                                                //Basic Expression
var intVar = 4
var doubleVar = 3.5

var result = Double(intVar) + doubleVar

                                                //Conditional Statement
let myBool = false

if (myBool) {
    print("true")
} else {
    print("false")
}

let animal = "dog"
switch(animal) {
    case "dog":
    print("Canine")
    fallthrough
    //fallthrough make the switch continue moving to the next case
    case "cat":
    print("Feline")
    //break added automatically
    case "mouse":
    print("Rodent")
    default:
    print("Unknown")
}

//Guard Statement
func printPositiveNumber(t : Int) {
    guard(t > 0) else {
    //guard check if the condition is true
    //if the statement isn't true, it executes what is in the curly brackets
        return
        //stop running
    }
    print(t)
}

printPositiveNumber(3)
printPositiveNumber(-1)// stop running

                                                //Loops
var i = 0
while(true) {
    i += 1
    if (i >= 10) {
        break
    }
}

i = 0
while(i < 10){
    i += 1
}

i = 0
repeat {
    i += 1
} while(i < 10)

//repeat run the loop first, then check the condition
repeat {
    i += 1
} while(i < 10)

//for loop
for (var j = 0; j < 20; j += 1){
    j
}

let myLoopArray = [1, 5, 10]

//loop that will iterate over each element
//a: no need to defined in advance
for a in myLoopArray{
    a
}

for (var index = 1; index <= 15; index += 1){
    index
}

for index2 in 1...15 {
    index2
}

//Challenge: 1. Create a loop that runs 100 times
//           2. Each time the loop runs, add an item to an array that is the square of the current index
//           3. Loop through the finished array and print any item evenly divisible by three

var loopChallengeArray : [Int] = Array()

for (var i = 1; i <= 100; i += 1){
    i
    loopChallengeArray.append(i * i)

    
    if (loopChallengeArray[i-1] % 3 == 0)
    {
        print(loopChallengeArray[i-1])
    }

}

                                                //Functions
//pre-defined function
//get the absolute value
let returnValue = abs(-5)

let maxNumber = max(100,200,-8)

print("1","2","3", separator:"--")

//Wrinting user-defined function
//1. With return value (return String)
func sayHello() -> String{
    return "Hello"
}

sayHello()

//2. With Parameter
//2.1
func sayHello2(name: String) -> String{
    return "Hello, \(name)"
}
sayHello2("Bob")

//2.2
func customGreeting(name: String, greeting: String) -> String{
    return "\(greeting), \(name)"
}
customGreeting("Bob", greeting: "Hi")

//2.3
func sayHelloToFullName(firstName: String, _ lastName: String) -> String
//                                         _: not use a name parameter, but I still need a variable name for it inside the function
{
    return "Hello, \(firstName) \(lastName)"
}
sayHelloToFullName("Bob", "Yang")
//                        so I don't need to put parameter's name here


//Challenge3:
//1. Create a function that takes three arguments (age, first name, and last name)
func profileInfo(age: Int, _ firstName: String, _ lastName: String) -> Bool {
//2. Return true if age is 18 or above or if the full name has more than 12 letters
    if (age >= 18 || (firstName.characters.count) + (lastName.characters.count) > 12)
    {
        return true
    } else{
    return false
    }
}
//3. Test using Bob Jones (14), Samantha Brown (17), and Christopher Washington (33)
profileInfo(14, "Bob", "Jones")
profileInfo(17, "Samantha", "Brown")
profileInfo(33, "Christopher", "Washington")

                                                //Classes, Structs, and enums
class MyClass{
    var a : Int
    
    init(initialValue: Int){
        a = initialValue
    }
    
    func classMethod() -> String {
        return "Return value"
    }
}

var cl = MyClass(initialValue: 15)
cl.a
cl.a = 10
//assign new value to a

cl.classMethod()

struct MyStruct {
    var a : Int
    
    init(initialValue: Int){
        a = initialValue
    }
    
    func structMethod() -> String {
        return "Return value"
    }
}

var st = MyStruct(initialValue: 12)
st.a
st.a = 16
st.structMethod()

//Enum: to store a list of possible values
//      can't store properties
enum MyEnum{
    case Value1, Value2, Value3
    
    static var testValues = ["Test1", "Test2", "Test3"]
    
    func returnMyValueInStringForm() -> String{
        switch(self){
        case.Value1:
            return MyEnum.testValues[0]
        case.Value2:
            return MyEnum.testValues[1]
        case.Value3:
            return MyEnum.testValues[2]
        }
    }
}

var en = MyEnum.Value3
en.returnMyValueInStringForm()

                                        //Inheritance and Protocols
class Employee {
    
    //Default values
    var yearsWorked : Double = 0
    var hasStockOptions : Bool = false
    var currentStatus : EmployeeStatus = .Active
    
    enum EmployeeStatus {
        case Active, Vacation, LeaveOfAbsence, Temp, Retired
    }
}

//Protocol: is something that classes and structs can conform to, that guarantees they will behave or respone in certain ways
protocol ExecutiveMember{
    var bonusAmount : Int {
        
        //get from outside
        get
    }
    
    //everything that implement the protocol will have this method
    func returnFullTitle() -> String
}

//Subclass of Employee
class CEO: Employee, ExecutiveMember {
    
    //override the initializer from parent class
    override init() {
        
        //sent the initializer up the inheritance tree to the superclass, Employee
        super.init()
        
        hasStockOptions = true
    }
    
    var bonusAmount : Int {
        return 10000
    }
    
    func returnFullTitle() -> String {
        return "Chief Executive Officer"
    }
}

class CFO : Employee{
    override init() {
        super.init()
        hasStockOptions = true
    }
    
    var bounsAmount : Int {
        return 5000
    }
    
    func returnFullTitle() -> String {
        return "Chief Financial Officer"
    }
}

class Worker : Employee{

}

class TempEmployee: Employee {
    override init(){
        super.init()
        currentStatus = .Temp
    }
}
let bob = CEO()
bob.yearsWorked = 25
bob.bonusAmount
bob.returnFullTitle()
bob.currentStatus = .LeaveOfAbsence
bob.currentStatus

let david = CFO()
david.bounsAmount
david.returnFullTitle()

let worker = Worker()
worker.currentStatus

let temp = TempEmployee()
temp.currentStatus

//Challenge:
//1. Create data structures for shapes: quadrilaterals (square and rectangle), triangles (equilateral and right), and circles
class Shape{

    }

}