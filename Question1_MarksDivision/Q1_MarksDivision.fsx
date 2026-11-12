
printfn "Enter marks for four subjects:"

let marks =
    [1..4]
    |> List.map (fun i ->
        printf "Subject %d: " i
        float (System.Console.ReadLine())
    )

// Calculate total and percentage
let total = List.sum marks
let percentage = total / 4.0

// Determine division using pattern matching
let division =
    match percentage with
    | p when p >= 60.0 -> "First Division"
    | p when p >= 50.0 -> "Second Division"
    | p when p >= 40.0 -> "Third Division"
    | _ -> "Fail"

// Display the result
printfn "\nTotal Marks: %.2f" total
printfn "Percentage: %.2f%%" percentage
printfn "Division: %s" division
