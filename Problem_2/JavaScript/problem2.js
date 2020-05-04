//Solution: 4613732
let value =1;
let prev =1;
let next =1;
let sum = 0;

while (value<4000000) {
    if (value % 2 == 0) {
        console.log(value);  
        sum = sum + value;
    }
    
    value = next + prev;
    prev = next;
    next = value;  


}
console.log("...................");
console.log(sum);
