namespace EulerLibFSharp

type Problem0029() = 

    member x.distinctPowers(n) =
        seq { for a in {2..n} do
              for b in {2..n} do
                  yield pown (bigint(a)) b } 
        |> Seq.distinct
        |> Seq.length

