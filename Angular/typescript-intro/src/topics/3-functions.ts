function addNumbers(a: number, b: number) {
    return a + b;
}

const addNumbersArrow = (a: number, b: number) => {
    //return a + b;
    return `${a + b}`;
}

function multiply(firstNumber: number, secondNumber?:number, base: number = 2){
    return firstNumber * base;
}

const multiplyResult: number = multiply(5);
const multiplyResult2: number = multiply(5,2);
const multiplyResult3: number = multiply(5,2,2);

console.log({multiplyResult, multiplyResult2, multiplyResult3});

const result = addNumbers(1,2);
const result2 = addNumbersArrow(1,2);

console.log({result, result2});
console.log(result, result2)
console.log('result', result)
console.log('result', result2)

export {};