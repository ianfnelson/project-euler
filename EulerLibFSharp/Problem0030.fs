namespace EulerLibFSharp

type Problem0030() = 

    let powerArray n = [| 0 .. 9 |] |> Array.map (fun x -> pown x n)

    let reverseDigits b number  =
        Seq.unfold (function
                        | 0 -> None
                        | x -> Some (x % b, x / b) )
                   number
        |> Seq.toList

    member m.sumOfNthPowersOfDigits x n =
        let pa = powerArray(n)
        reverseDigits 10 x
        |> Seq.map(fun d -> pa.[d])
        |> Seq.sum

    member m.sumOfNumbersThatCanBeBeWrittenAsSumOfNthPower n =
        {2..((pown 9 n)*(n+1))}
        |> Seq.filter (fun x -> m.sumOfNthPowersOfDigits x n = x)
        |> Seq.sum


