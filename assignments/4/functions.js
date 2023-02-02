function fibonacci(n) {
    if (n < 2) {
        return 1;
    } else {
        return fibonacci(n - 2) + fibonacci(n - 1);
    }
}

function palindrome(str) {
    str = str.toLowerCase().replace(/[^a-z]+/g, "");
    return str === str.split("").reverse().join("")
}

function type(obj) {
    return typeof (obj);
}

function amountToCoins(amount, coins){
    let res = [];
    for (i = 0; i < coins.length; i++) {
        while ((amount - coins[i]) >= 0) {
            res.push(coins[i]);
            amount = amount - coins[i];
        }
    }
    return res.toString();
}

let result = `<br>
Fibonacci: ${fibonacci(5)} <br>
Palindrome: ${palindrome("parap")} <br>
Type: ${type(5)} <br>
Coins: ${amountToCoins(46, [25, 10, 5, 2, 1])} <br>
`;

document.write(result);
console.log(result);