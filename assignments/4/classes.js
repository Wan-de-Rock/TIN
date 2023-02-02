class Person {
    #name;
    #age;

    constructor(name, age) {
        this.#name = name;
        this.#age = age;
    }

    getName() {
        return this.#name;
    }

    getAge() {
        return this.#age;
    }

    setAge(num) {
        this.#age = this.#age + num;
    }

    print() {
        return `Name: ${this.#name} Age: ${this.#age}`;
    }
}
class Employee extends Person {
    #company;

    constructor(name, age, company) {
        super(name, age);
        this.#company = company;
    }

    getCompany(){
        return this.#company;
    }

    setCompany(company){
        this.#company = company;
    }

    print() {
        return `${super.print()} Company: ${this.getCompany()}`;
    }
}

let person = new Person('p1', 50);
let employee = new Employee('e1', 19, 'soft1');

document.writeln(person.print());
document.write("<br>");
document.writeln(employee.print());
document.write("<br>");
employee.setAge(5)
employee.company = "soft2";
document.writeln(employee.print());
document.write("<br>");

console.log(person.print())
console.log(employee.print())