
open System
open System.Text.RegularExpressions

// 1. Reverse a string
let reverseString (str: string) =
    str.ToCharArray()
    |> Array.rev
    |> fun chars -> String(chars)

// Check palindrome
let isPalindrome (str: string) =
    let reversed = reverseString str
    String.Equals(str, reversed, StringComparison.OrdinalIgnoreCase)

// 2. Transform a string
let transformString (str: string) =
    if str.Length > 0 && (str |> Seq.forall Char.IsLetter) then
        str.ToUpper()
    elif str.Length > 0 && (str |> Seq.forall Char.IsDigit) then
        str + str
    else
        str

// 3. Validate email using Regex
let isValidEmail (email: string) =
    Regex.IsMatch(
        email,
        @"^[A-Za-z0-9._%+-]+@[A-Za-z0-9.-]+\.[A-Za-z]{2,}$"
    )

// Task 1: Reverse and Palindrome
printfn "---- String Reversal and Palindrome ----"

let words = ["madam"; "hello"; "level"]

words |> List.iter (fun word ->
    printfn "Original: %s" word
    printfn "Reversed: %s" (reverseString word)
    printfn "Palindrome: %b" (isPalindrome word)
    printfn ""
)

// Task 2: String Transformation
printfn "---- String Transformation ----"

let inputs = ["hello"; "1234"; "hello123"; "WORLD"]

inputs |> List.iter (fun str ->
    printfn "Input: %s -> Output: %s"
        str (transformString str)
)

// Task 3: Email Validation
printfn "\n---- Email Validation ----"

let emails =
    ["student@gmail.com";
     "hello123@yahoo.in";
     "invalid-email";
     "user@domain"]

emails |> List.iter (fun email ->
    if isValidEmail email then
        printfn "%s : Valid Email" email
    else
        printfn "%s : Invalid Email" email
)
