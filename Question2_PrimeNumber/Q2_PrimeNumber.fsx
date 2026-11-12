
// Question 2: Check Whether a Number Is Prime

// Recursive function to check prime number
let isPrime n =
    if n < 2 then
        false
    else
        let rec check divisor =
            if divisor * divisor > n then
                true
            elif n % divisor = 0 then
                false
            else
                check (divisor + 1)

        check 2

// Test inputs
let numbers = [7; 10; 13; 1; 17]

// Check each number
numbers
|> List.iter (fun n ->
    if isPrime n then
        printfn "%d is a Prime Number" n
    else
        printfn "%d is Not a Prime Number" n
)
